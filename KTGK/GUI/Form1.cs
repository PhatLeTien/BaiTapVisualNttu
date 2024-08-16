    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Xml.Linq;

namespace GUI
{
    public partial class Form1 : Form
    {
        MatHang_BLL productBLL = new MatHang_BLL();
        public Form1()
        {
            InitializeComponent();
        }
        private void HienThiDanhSachMatHang() // Hiển thị danh sách mặt hàng.
        {
            MatHang_BLL productBLL = new MatHang_BLL();
            List<MatHang_DTO> dsspGUI = productBLL.HienThiDanhSachMatHang();// danhsachSanPham ở BLL
            gvProduct.DataSource = dsspGUI;
            gvProduct.Refresh();
            gvProduct.Columns[0].HeaderText = "MaSP";
            gvProduct.Columns[1].HeaderText = "TenSP";
            gvProduct.Columns[2].HeaderText = "NgaySX";
            gvProduct.Columns[3].HeaderText = "NgayHH";
            gvProduct.Columns[4].HeaderText = "DonVi";
            gvProduct.Columns[5].HeaderText = "DonGia";
            gvProduct.Columns[6].HeaderText = "GhiChu";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MatHang_DTO product = new MatHang_DTO();

            product.MaSP = Int32.Parse(txtNhapMasp.Text.Trim());
            product.TenSP = txtNhapTensp.Text.Trim();
            product.NgaySX = DateTime.Parse(dtNgayhh.Text.Trim());
            product.NgayHH = DateTime.Parse(dtNgayhh.Text.Trim());
            product.Dongia = Decimal.Parse(txtNhapDongia.Text.Trim());
            product.Donvi = txtNhapDonvi.Text.Trim();
            product.GhiChu = txtGhichu.Text.Trim();

            MatHang_BLL traketqua = new MatHang_BLL();
            bool kt = traketqua.ThemSP(product);
            if (kt)
            {
                MessageBox.Show("Thêm thành công");
                HienThiDanhSachMatHang();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gvProduct.DataSource = productBLL.HienThiDanhSachMatHang    ();
        }
    }
}
