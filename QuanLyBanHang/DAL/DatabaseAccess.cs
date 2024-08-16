using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class SqlConnectionData
    {
        // Tạo chuỗi kết nối cơ sỡ dữ liệu
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=DESKTOP-JLT1UUT\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon); // Khởi tạo Connect
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public static string CheckLoginDTO(TaiKhoan taikhoan)
        {
            string user = null;
            //Hàm connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_login", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.sTaiKhoan);
            command.Parameters.AddWithValue("@pass", taikhoan.sMatKhau);
            //Kiểm tra quyền thêm 1 cái parameter...
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác !";
            }
            return user;  
        }
    }
}
