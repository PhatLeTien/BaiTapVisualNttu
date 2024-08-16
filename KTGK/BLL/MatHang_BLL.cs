using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class MatHang_BLL
    {
        private MatHang_DAL mhDAL = new MatHang_DAL();
        public List<MatHang_DTO> HienThiDanhSachMatHang()
        {
            return mhDAL.HienThiDanhSachMatHang();
        }

        public bool ThemSP(MatHang_DTO vt)
        {
            return mhDAL.ThemSP(vt);
        }
    }
}
