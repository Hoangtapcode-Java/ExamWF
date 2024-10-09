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
    public partial class frm_DangKy : Form
    {
        public frm_DangKy()
        {
            InitializeComponent();
        }
        LopDungChung lop = new LopDungChung();

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if(txt_MatKhau.Text == txt_NhapLaiMatKhau.Text)
            {
                string sql = "Insert into TAIKHOAN values('" + txt_TenDangKy.Text + "','" + txt_MatKhau.Text + "')";
                int kq = lop.ThemSuaXoa(sql);
                if(kq >= 1)
                {
                    MessageBox.Show("Thêm thành công! Đến trang đăng nhập", "Thông báo");
                    frm_DangNhap frm_DangNhap = new frm_DangNhap();
                    frm_DangNhap.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu và Nhập lại mật khẩu không khớp", "Thông báo");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            frm_DangNhap frm_DangNhap = new frm_DangNhap();
            frm_DangNhap.Show();
            this.Hide();
        }
    }
}
