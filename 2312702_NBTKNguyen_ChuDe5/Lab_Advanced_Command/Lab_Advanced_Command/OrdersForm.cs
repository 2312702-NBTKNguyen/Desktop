using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Advanced_Command
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void btnViewBills_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=.\NGUYEN; database=RestaurantManagement; Integrated Security = true;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetBillsByDateRangeProcedure", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtpFrom.Value.Date;
                cmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtpTo.Value.Date.AddDays(1);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtBills = new DataTable();

                conn.Open();
                adapter.Fill(dtBills);

                dgvBills.AutoGenerateColumns = true;
                dgvBills.DataSource = dtBills;

                decimal totalAmount = 0;
                decimal totalDiscount = 0;
                decimal totalRevenue = 0;
                foreach (DataRow row in dtBills.Rows)
                {
                    decimal amount = Convert.ToDecimal(row["Amount"]);
                    decimal discount = row["Discount"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Discount"]);
                    decimal tax = row["Tax"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Tax"]);

                    totalAmount += amount;
                    totalDiscount += amount * discount;
                    totalRevenue += amount - amount * discount + tax;
                }

                txtTotalAmount.Text = totalAmount.ToString("N0");
                txtTotalDiscount.Text = totalDiscount.ToString("N0");
                txtRevenue.Text = totalRevenue.ToString("N0");
            }
        }

        private void dgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int invoiceId = Convert.ToInt32(dgvBills.Rows[e.RowIndex].Cells["ID"].Value);
                OrderDetailsForm detailsForm = new OrderDetailsForm(invoiceId);
                detailsForm.ShowDialog();
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
