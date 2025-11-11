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
    public partial class OrderDetailsForm : Form
    {
        private int invoiceId;
        public OrderDetailsForm(int invoiceId)
        {
            InitializeComponent();
            this.invoiceId = invoiceId;
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            LoadDetails();
        }
        private void LoadDetails()
        {
            string connectionString = @"server=.\NGUYEN; database=RestaurantManagement; Integrated Security = true;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetBillDetailsProcedure", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@invoiceID", SqlDbType.Int).Value = invoiceId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtDetails = new DataTable();
                conn.Open();
                adapter.Fill(dtDetails);
                dgvDetails.AutoGenerateColumns = true;
                dgvDetails.DataSource = dtDetails;
                decimal total = 0;
                foreach (DataRow row in dtDetails.Rows)
                {
                    total += Convert.ToDecimal(row["TotalPrice"]);
                }
                lblTotal.Text = "Total: " + total.ToString("N0") + " đ";
            }
        }
    }
}
