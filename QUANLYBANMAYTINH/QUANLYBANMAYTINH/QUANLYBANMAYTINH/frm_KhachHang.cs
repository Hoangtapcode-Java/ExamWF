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
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }
        LopDungChung lopDungChung = new LopDungChung(); 
        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KHACHHANG values('" + txt_MaKH.Text + "','" + txt_TenKH.Text + "','" + txt_GioiTinh.Text + "','" + txt_DiaChi.Text + "'," + "Convert(datetime,'" + date_NgaySinh.Text + "',103),'" + txt_SoDienThoai.Text + "','" + txt_TenHinhAnh.Text + "')";
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

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM KHACHHANG";
            data_GridViewKH.DataSource = lopDungChung.LoadDL(sql);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE KHACHHANG set TENKHACHHANG = '" + txt_TenKH.Text + "', GIOITINH = '" + txt_GioiTinh.Text + "',DIACHI = '" + txt_DiaChi + "', NGAYSINH =  " + "Convert(datetime, '" + date_NgaySinh.Text + "', 103), SODIENTHOAI = '" + txt_SoDienThoai.Text + "', HINHANH = '" + txt_TenHinhAnh.Text + "' where MAKH = '" + txt_MaKH.Text + "'";
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

        private void data_GridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKH.Text = data_GridViewKH.CurrentRow.Cells["MAKH"].Value.ToString();
            txt_TenKH.Text = data_GridViewKH.CurrentRow.Cells["TENKHACHHANG"].Value.ToString();
            txt_GioiTinh.Text = data_GridViewKH.CurrentRow.Cells["GIOITINH"].Value.ToString();
            date_NgaySinh.Text = data_GridViewKH.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_SoDienThoai.Text = data_GridViewKH.CurrentRow.Cells["SODIENTHOAI"].Value.ToString();
            txt_TenHinhAnh.Text = data_GridViewKH.CurrentRow.Cells["HINHANH"].Value.ToString();
            txt_DiaChi.Text = data_GridViewKH.CurrentRow.Cells["DIACHI"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE KHACHHANG where MAKH = '" + txt_MaKH.Text + "'";
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
