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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        LopDungChung lopDungChung = new LopDungChung();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NHANVIEN values('" + txt_MaNV.Text + "','" + txt_TenNV.Text + "'," + "Convert(datetime,'" + date_NgaySinh.Text + "',103),'" + txt_GioiTinh.Text + "','" + txt_DiaChi.Text + "','"  + txt_SoDienThoai.Text + "','" + txt_TenHinhAnh.Text + "')";
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
            string sql = "UPDATE NHANVIEN set TENNHANVIEN = '" + txt_TenNV.Text + "',NGAYSINH =  Convert(datetime, '" + date_NgaySinh.Text + "', 103),  GIOITINH = '" + txt_GioiTinh.Text + "',DIACHI = '" + txt_DiaChi.Text + "', SODIENTHOAI = '" + txt_SoDienThoai.Text + "', HINHANH = '" + txt_TenHinhAnh.Text + "' where MANV = '" + txt_MaNV.Text + "'";
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

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NHANVIEN";
            data_GridViewNV.DataSource = lopDungChung.LoadDL(sql);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE NHANVIEN where MANV = '" + txt_MaNV.Text + "'";
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

        private void data_GridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = data_GridViewNV.CurrentRow.Cells["MANV"].Value.ToString();
            txt_TenNV.Text = data_GridViewNV.CurrentRow.Cells["TENNHANVIEN"].Value.ToString();
            txt_GioiTinh.Text = data_GridViewNV.CurrentRow.Cells["GIOITINH"].Value.ToString();
            date_NgaySinh.Text = data_GridViewNV.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_SoDienThoai.Text = data_GridViewNV.CurrentRow.Cells["SODIENTHOAI"].Value.ToString();
            txt_TenHinhAnh.Text = data_GridViewNV.CurrentRow.Cells["HINHANH"].Value.ToString();
            txt_DiaChi.Text = data_GridViewNV.CurrentRow.Cells["DIACHI"].Value.ToString();
        }
    }
}
