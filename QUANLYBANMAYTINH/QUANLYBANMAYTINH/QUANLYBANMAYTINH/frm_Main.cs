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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void qUẢNLÝKHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_KhachHang"] == null)
            {
                frm_KhachHang kh = new frm_KhachHang();
                kh.MdiParent = this;
                kh.Show();
            }
            else Application.OpenForms["frm_KhachHang"].Activate();
        }

        private void qUẢNLÝNHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien nv = new frm_NhanVien();
                nv.MdiParent = this;
                nv.Show();
            }
            else Application.OpenForms["frm_NhanVien"].Activate();
        }

        private void lOẠITHIẾTBỊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThietBi"] == null)
            {
                frm_ThietBi tb = new frm_ThietBi();
                tb.MdiParent = this;
                tb.Show();
            }
            else Application.OpenForms["frm_ThietBi"].Activate();
        }

        private void lOẠITHIẾTBỊToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_LoaiThietBi"] == null)
            {
                frm_LoaiThietBi ltb = new frm_LoaiThietBi();
                ltb.MdiParent = this;
                ltb.Show();
            }
            else Application.OpenForms["frm_LoaiThietBi"].Activate();
        }
    }
}
