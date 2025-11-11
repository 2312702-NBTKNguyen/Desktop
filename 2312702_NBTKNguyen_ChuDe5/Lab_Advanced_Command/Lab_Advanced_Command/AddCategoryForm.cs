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
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"server=.\NGUYEN; database=RestaurantManagement; Integrated Security = true;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE InsertCategory @id OUTPUT, @name, @type";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000).Value = txtName.Text;
                    cmd.Parameters.Add("@type", SqlDbType.Int).Value = int.Parse(txtType.Text);
                    conn.Open();
                    int numRowAffected = cmd.ExecuteNonQuery();

                    if (numRowAffected > 0)
                    {
                        MessageBox.Show("Successfully added food category. ID = " + cmd.Parameters["@id"].Value.ToString());
                        txtName.Clear();
                        txtType.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Add food category failed.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
