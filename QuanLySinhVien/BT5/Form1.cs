using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            lstBandau.Items.Add(txtHoten.Text); 
            txtHoten.Text = ""; 
            txtHoten.Focus();
        }

        private void btTraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.SelectedItems.Count; //Tổng số mục được chọn 
            for (int i = 0; i < n; i++)
                lstKetqua.Items.Add(lstBandau.SelectedItems[i].ToString());

            for (int j = n - 1; j >= 0; j--)
                lstBandau.Items.Remove(lstBandau.SelectedItems[j]);
        }

        private void btTatcatraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.Items.Count;
            for (int i = 0; i < n; i++)
                lstKetqua.Items.Add(lstBandau.Items[i].ToString());

            lstBandau.Items.Clear();

        }

        private void btPhaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count; //Tổng số mục được chọn 
            for (int i = 0; i < n; i++)
                lstBandau.Items.Add(lstKetqua.SelectedItems[i].ToString());

            for (int j = n - 1; j >= 0; j--)
                lstKetqua.Items.Remove(lstKetqua.SelectedItems[j]);
        }

        private void btTatcaphaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = 0; i < n; i++)
                lstBandau.Items.Add(lstKetqua.Items[i].ToString());

            lstKetqua.Items.Clear();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            // Xóa các mục đã chọn khỏi lstBandau
            foreach (var selectedItem in lstBandau.SelectedItems.Cast<string>().ToList())
            {
                lstBandau.Items.Remove(selectedItem);
            }

            // Xóa các mục đã chọn khỏi lstKetqua
            foreach (var selectedItem in lstKetqua.SelectedItems.Cast<string>().ToList())
            {
                lstKetqua.Items.Remove(selectedItem);
            }
        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {
            // Yêu cầu người dùng xác nhận việc thoát ứng dụng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra xem người dùng đã chọn "Yes" để thoát hay không
            if (result == DialogResult.Yes)
            {
                // Đóng Form (ứng dụng)
                this.Close();
            }
        }
    }
}
