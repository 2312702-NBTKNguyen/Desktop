using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
    }

    // Lớp quản lý Category: DA = DataAccess
    public class CategoryDA
    {
        // Phương thức lấy hết dữ liệu theo thủ tục Food_GetAll
        public List<Category> GetAll()
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            // Đối tượng SqlConnection truyền vào chuỗi kết nối trong App.config
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();

            // Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Category_GetAll;

            // Đọc dữ liệu, lưu vào danh sách đối tượng Category
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

            // Đóng kết nối và trả về danh sách
            sqlConn.Close();
            return list;
        }

        // Phương thức thêm, xóa, sửa theo thủ tục Category_InsertUpdateDelete
        public int Insert_Update_Delete(Category category, int action)
        {
            // Khai báo đối tượng SqlConnection và mở kết nối
            SqlConnection sqlConn = new SqlConnection(Utilities.ConnectionString);
            sqlConn.Open();

            // Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Utilities.Category_InsertUpdateDelete;

            // Thêm các tham số cho thủ tục; Các tham số này chính là các tham số có trong thủ tục
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput; // Vừa vào vừa ra
            command.Parameters.Add(IDPara);
            command.Parameters["@ID"].Value = category.ID;

            command.Parameters.Add("@Name", SqlDbType.NVarChar, 200);
            command.Parameters["@Name"].Value = category.Name;

            command.Parameters.Add("@Type", SqlDbType.Int);
            command.Parameters["@Type"].Value = category.Type;

            command.Parameters.Add("@Action", SqlDbType.Int);
            command.Parameters["@Action"].Value = action;

            // Thực thi lệnh
            int result = command.ExecuteNonQuery();
            if (result > 0) // Nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@ID"].Value;

            return 0;
        }
    }

}
