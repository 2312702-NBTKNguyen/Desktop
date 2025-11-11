using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDA
    {
        public List<Category> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Category_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Category> list = new List<Category>();

            while (reader.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(reader["ID"]);
                category.Name = reader["Name"].ToString();
                category.Type = Convert.ToInt32(reader["Type"]);
                list.Add(category);
            }

            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(Category category, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Category_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara);
            command.Parameters["@ID"].Value = category.ID;

            command.Parameters.Add("@Name", SqlDbType.NVarChar, 200);
            command.Parameters["@Name"].Value = category.Name;

            command.Parameters.Add("@Type", SqlDbType.Int);
            command.Parameters["@Type"].Value = category.Type;

            command.Parameters.Add("@Action", SqlDbType.Int);
            command.Parameters["@Action"].Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@ID"].Value;

            return 0;
        }
    }
}
