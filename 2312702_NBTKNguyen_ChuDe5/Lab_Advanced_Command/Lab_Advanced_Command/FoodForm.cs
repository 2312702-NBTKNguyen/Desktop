using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab_Advanced_Command
{
    public partial class FoodForm : Form
    {
        private DataTable foodTable;
        
        public FoodForm()
        {
            InitializeComponent();
            dgvFoodList.CellMouseDown += dgvFoodList_CellMouseDown;
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        public void LoadCategory()
        {
            string connectionString = @"server=.\NGUYEN; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1)
                return;
            string connectionString = @"server=.\NGUYEN; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryID";

            cmd.Parameters.Add("@categoryID", SqlDbType.Int);

            if (cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                cmd.Parameters["@categoryID"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@categoryID"].Value = cbbCategory.SelectedValue;
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            foodTable = new DataTable(); 
            conn.Open();
            adapter.Fill(foodTable);
            conn.Close();
            conn.Dispose();
            dgvFoodList.DataSource = foodTable;

            lblQuantity.Text = foodTable.Rows.Count.ToString();
            lblCatName.Text = cbbCategory.Text;
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            var selectedRow = (dgvFoodList.SelectedRows.Count > 0)
                        ? dgvFoodList.SelectedRows[0]
                        : dgvFoodList.CurrentRow;

            if (selectedRow == null)
            {
                MessageBox.Show("Bạn chưa chọn món ăn nào.");
                return;
            }

            DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
            int foodId = (int)rowView["ID"];
            string connectionString = @"server=.\NGUYEN; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT @numSaleFood = ISNULL(SUM(Quantity), 0)
                            FROM BillDetails
                            WHERE FoodID = @foodId";
            cmd.Parameters.Add("@foodId", SqlDbType.Int).Value = foodId;
            cmd.Parameters.Add("@numSaleFood", SqlDbType.Int).Direction = ParameterDirection.Output;

            conn.Open();
            cmd.ExecuteNonQuery();

            int numSale = (int)cmd.Parameters["@numSaleFood"].Value;
            string unit = rowView["Unit"].ToString();
            string name = rowView["Name"].ToString();
            MessageBox.Show($"Tổng số lượng món {name} đã bán là: {numSale} {unit}");

            conn.Close();
                cmd.Dispose();
                conn.Dispose();
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodInfoForm foodForm = new FoodInfoForm();
            foodForm.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);

            foodForm.Show(this);
        }
        void foodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }
        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                FoodInfoForm foodForm = new FoodInfoForm();
                foodForm.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);

                foodForm.Show(this);
                foodForm.DisplayFoodInfo(rowView);
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;

            string filterExpression = "Name like '%" + txtSearchByName.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;

            DataView foodView = new DataView(foodTable,
                filterExpression, sortExpression, rowStateFilter);

            dgvFoodList.DataSource = foodView;
        }

        private void dgvFoodList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvFoodList.ClearSelection();
                dgvFoodList.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnViewBills_Click(object sender, EventArgs e)
        {
            using (var f = new OrdersForm())
            {
                f.ShowDialog(this);
            }
        }
    }
}
