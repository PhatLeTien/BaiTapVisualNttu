using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DAL
{
    public class MatHang_DAL : Database
    {
        public List<MatHang_DTO> HienThiDanhSachMatHang()
        {
            List<MatHang_DTO> productList = new List<MatHang_DTO>();
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM MatHang";
                command.Connection = conn;

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MatHang_DTO matHang = new MatHang_DTO();
                    matHang.MaSP = (int)reader["MaSP"];
                    matHang.TenSP = (string)reader["TenSP"];
                    matHang.NgaySX = (DateTime)reader["NgaySX"];
                    matHang.NgayHH = (DateTime)reader["NgayHH"];
                    matHang.Dongia = (decimal)reader["DonGia"];
                    matHang.Donvi = (string)reader["DonVi"];
                    matHang.GhiChu = (string)reader["GhiChu"];

                    productList.Add(matHang); // Thêm đối tượng vào danh sách productList
                }
                reader.Close();
            }
            return productList;
        }
        public bool ThemSP(MatHang_DTO product)
        {
            using (SqlConnection conn = SqlConnectionData.Connect())
            {
                conn.Open();
                string query = "INSERT INTO MatHang (MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu) " +
                              "VALUES (@MaSP, @Name, @NgayXX, @NgayHH, @DonVi, @DonGia, @GhiChu)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("MaSP", product.MaSP);
                    command.Parameters.AddWithValue("@Name", product.TenSP);
                    command.Parameters.AddWithValue("@NgayXX", product.NgaySX);
                    command.Parameters.AddWithValue("@NgayHH", product.NgayHH);
                    command.Parameters.AddWithValue("@DonVi", product.Donvi);
                    command.Parameters.AddWithValue("@DonGia", product.Dongia);
                    command.Parameters.AddWithValue("@GhiChu", product.GhiChu);

                    command.Connection = conn;
                    int kt = command.ExecuteNonQuery();
                    if (kt > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
        }
    }
}
