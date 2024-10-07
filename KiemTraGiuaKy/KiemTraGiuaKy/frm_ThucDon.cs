using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraGiuaKy
{
    public partial class frm_ThucDon : Form
    {
        LopDungChung LopDungChung = new LopDungChung();
        public frm_ThucDon()
        {
            InitializeComponent();
        }

        private void frm_ThucDon_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM THUCDON";
            dt_GridViewTD.DataSource = LopDungChung.LoadDL(sql);
            string sqlKhoa = "SELECT * FROM LOAIKHACH";
            cb_LoaiKhach.DataSource = LopDungChung.LoadDL(sqlKhoa);
            cb_LoaiKhach.ValueMember = "MA_LOAIKHACH";
            cb_LoaiKhach.DisplayMember = "LOAIKHACH";
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT(*) from THUCDON ";
            int kq = (int)LopDungChung.LayGT(sql);
            txt_Dem.Text = kq.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int namHetHan = date_NgayCapThe.Value.Year + 1;
            txt_NamHetHan.Text = namHetHan.ToString();
            string sql = "Insert into THUCDON values('" + txt_MaTD.Text + "','" + txt_TenTD.Text + "',Convert(datetime,'" + date_NgayCapThe.Text + "',103),'" + namHetHan.ToString() + "','" + cb_LoaiKhach.SelectedValue + "')";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE THUCDON where MA_THUCDON = '" + txt_MaTD.Text + "'";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int namHetHan = date_NgayCapThe.Value.Year + 1;
            
            string sql = "UPDATE THUCDON set TEN_THUCDON = '" + txt_TenTD.Text + "', NGAY_CAPTHE_THANHVIEN = " + "Convert(datetime, '" + date_NgayCapThe.Text + "', 103), NAMHETHAN_THE = '" + namHetHan.ToString() + "', MA_LOAIKHACH = '" + cb_LoaiKhach.SelectedValue + "' where MA_THUCDON = '" + txt_MaTD.Text + "'";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
    
}
