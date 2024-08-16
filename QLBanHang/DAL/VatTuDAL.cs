using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class VatTuDAL : Database
    {

        public List<VatTu> HienThiDanhSachVatTu()
        {
            List<VatTu> ds = new List<VatTu>();
            OpenConnection();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from tblQuanLyCHN2";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string ma = reader.GetString(0);
                string ten = reader.GetString(1);
                string dvt = reader.GetString(2);
                double dg = (double)reader.GetDouble(3);

                VatTu vt = new VatTu();
                vt.MaVTu = ma;
                vt.TenVTu = ten;
                vt.DVTinh = dvt;
                vt.DGia = dg;

                ds.Add(vt);
            }
            reader.Close();
            return ds;
        }
        public bool ThemVT(VatTu vt)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into tblQuanLyCHN2 values (@ma, @ten, @dvt, @dg)";

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Char);
            parMa.Value = vt.MaVTu;
            sqlCmd.Parameters.Add(parMa);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = vt.TenVTu;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parDVT = new SqlParameter("@dvt", SqlDbType.NVarChar);
            parDVT.Value = vt.DVTinh;
            sqlCmd.Parameters.Add(parDVT);

            SqlParameter parDG = new SqlParameter("@dg", SqlDbType.Real);
            parDG.Value = vt.DGia;
            sqlCmd.Parameters.Add(parDG);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool XoaVT(VatTu vt)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "delete from tblQuanLyCHN2 where MaVTu = @ma ";

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Char);
            parMa.Value = vt.MaVTu;
            sqlCmd.Parameters.Add(parMa);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
            if (kt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SuaVT(VatTu vt)
        {
            OpenConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update tblQuanLyCHN2 set MaVTu= @ma, TenVtu = @ten, DonVi = @dvt, DonGia = @dg where MaVTu = @ma ";

            SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Char);
            parMa.Value = vt.MaVTu;
            sqlCmd.Parameters.Add(parMa);

            SqlParameter parTen = new SqlParameter("@ten", SqlDbType.NVarChar);
            parTen.Value = vt.TenVTu;
            sqlCmd.Parameters.Add(parTen);

            SqlParameter parDVT = new SqlParameter("@dvt", SqlDbType.NVarChar);
            parDVT.Value = vt.DVTinh;
            sqlCmd.Parameters.Add(parDVT);

            SqlParameter parDG = new SqlParameter("@dg", SqlDbType.Real);
            parDG.Value = vt.DGia;
            sqlCmd.Parameters.Add(parDG);

            sqlCmd.Connection = sqlCon;
            int kt = sqlCmd.ExecuteNonQuery();
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
