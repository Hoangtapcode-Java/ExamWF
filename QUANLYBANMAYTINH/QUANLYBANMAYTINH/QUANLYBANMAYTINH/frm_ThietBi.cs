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
    public partial class frm_ThietBi : Form
    {
        public frm_ThietBi()
        {
            InitializeComponent();
        }
        LopDungChung lopDungChung = new LopDungChung();

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into THIETBI values('" + txt_MaTB.Text + "','" + txt_TenTB.Text + "','" + cb_TenLoai.SelectedValue + "','" + txt_SoLuong.Text + "','"+ txt_DonGia.Text +"','" + txt_DonViTinh.Text +"','" + txt_TenHinhAnh.Text + "')";
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE THIETBI set TENTHIETBI = '" + txt_TenTB.Text + "', MALOAITHIETBI = '" + cb_TenLoai.SelectedValue + "', SOLUONG = '" + txt_SoLuong.Text + "', DONGIA = '" + txt_DonGia.Text + "', DONVITINH = '" + txt_DonViTinh.Text + "', HINHANH = '" + txt_TenHinhAnh.Text + "' where MATHIETBI = '" + txt_MaTB + "'";
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE THIETBI where MATHIETBI = '" + txt_MaTB.Text + "'";
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

        private void frm_ThietBi_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM THIETBI";
            data_GridViewTB.DataSource = lopDungChung.LoadDL(sql);
            string sqlLoai = "SELECT * FROM LOAITHIETBI";
            cb_TenLoai.DataSource = lopDungChung.LoadDL(sqlLoai);
            cb_TenLoai.ValueMember = "MALOAITHIETBI";
            cb_TenLoai.DisplayMember = "TENLOAITHIETBI";
        }

        private void data_GridViewTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaTB.Text = data_GridViewTB.CurrentRow.Cells["MATHIETBI"].Value.ToString();
            txt_TenTB.Text = data_GridViewTB.CurrentRow.Cells["TENTHIETBI"].Value.ToString();
            txt_SoLuong.Text = data_GridViewTB.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txt_DonGia.Text = data_GridViewTB.CurrentRow.Cells["DONGIA"].Value.ToString();
            txt_DonViTinh.Text = data_GridViewTB.CurrentRow.Cells["DONVITINH"].Value.ToString();
            cb_TenLoai.Text = data_GridViewTB.CurrentRow.Cells["MALOAITHIETBI"].Value.ToString();
            txt_TenHinhAnh.Text = data_GridViewTB.CurrentRow.Cells["HINHANH"].Value.ToString();
        }
    }
}
