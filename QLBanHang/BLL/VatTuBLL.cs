using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class VatTuBLL
    {
        VatTuDAL vtDAL = new VatTuDAL();
        public List<VatTu> HienThiDanhSachVatTu()
        {
            return vtDAL.HienThiDanhSachVatTu();
        }

        public bool ThemVT(VatTu vt)
        {
            return vtDAL.ThemVT(vt);
        }
        public bool XoaVT(VatTu vt)
        {
            return vtDAL.XoaVT(vt);
        }
        public bool SuaVT(VatTu vt)
        {
            return vtDAL.SuaVT(vt);
        }
    }
}
