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
    public partial class frm_LoaiThietBi : Form
    {
        public frm_LoaiThietBi()
        {
            InitializeComponent();
        }
        LopDungChung lopDungChung = new LopDungChung();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into LOAITHIETBI values('" + txt_MaLTB.Text + "','" + txt_TenLTB.Text + "')";
            int kq = lopDungChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE LOAITHIETBI set TENLOAITHIETBI = '" + txt_TenLTB.Text + "' where MAKH = '" + txt_MaLTB.Text + "'";
            int kq = lopDungChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo");
            }
        }

        private void frm_LoaiThietBi_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM LOAITHIETBI";
            data_GridViewLTB.DataSource = lopDungChung.LoadDL(sql);
        }

        private void data_GridViewLTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaLTB.Text = data_GridViewLTB.CurrentRow.Cells["MALOAITHIETBI"].Value.ToString();
            txt_TenLTB.Text = data_GridViewLTB.CurrentRow.Cells["TENLOAITHIETBI"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE LOAITHIETBI where MALOAITHIETBI = '" + txt_MaLTB.Text + "'";
            int kq = lopDungChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
        }
    }
}
