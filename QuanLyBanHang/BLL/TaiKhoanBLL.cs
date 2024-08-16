using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();
        public string CheckLogin(TaiKhoan taikhoan)
        {
            //Kiểm tra nghiệp vụ
            if (taikhoan.sTaiKhoan == "")
            {
                return "requeid_taikhoan";
            }
            if (taikhoan.sMatKhau == "")
            {
                return "requeid_password";
            }
            string info = tkAccess.ChecLogin(taikhoan);
            return info;
        }
    }
}
