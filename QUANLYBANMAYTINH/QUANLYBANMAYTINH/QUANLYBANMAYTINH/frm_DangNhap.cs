using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANMAYTINH
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        LopDungChung lopDungChung = new LopDungChung();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT(*) from TAIKHOAN where TenTaiKhoan = '" + txt_TenDangNhap.Text + "'and MatKhau = '" + txt_MatKhau.Text + "'";
            int kq = (int)lopDungChung.LayGT(sql);
            if (kq == 1)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                frm_Main main = new frm_Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
