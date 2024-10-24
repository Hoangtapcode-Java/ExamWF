using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public partial class frm_CuaHang : Form
    {
        public frm_CuaHang()
        {
            InitializeComponent();
        }
        LopDungChung lopDungChung = new LopDungChung();

        private void btn_Them_Click(object sender, EventArgs e)
        {   
            string sql = "Insert into CUAHANG values('" + txt_MaH.Text + "','" + txt_TenHang.Text + "',Convert(datetime,'" + date_NgaySX.Text + "',103),'" + txt_NamHH.Text + "','" + cb_NhaCC.SelectedValue + "')";
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

        private void frm_CuaHang_Load(object sender, EventArgs e)
        {
            string CuaHang = "SELECT * FROM CUAHANG";
            dt_GridViewCH.DataSource = lopDungChung.LoadDL(CuaHang);
            string NhaCC = "SELECT * FROM NHACUNGCAP";
            cb_NhaCC.DataSource = lopDungChung.LoadDL(NhaCC);
            cb_NhaCC.ValueMember = "MANHACUNGCAP";
            cb_NhaCC.DisplayMember = "TEN";
        }

        private void dt_GridViewCH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaH.Text = dt_GridViewCH.CurrentRow.Cells["MAHANG"].Value.ToString();
            txt_TenHang.Text = dt_GridViewCH.CurrentRow.Cells["TENHANG"].Value.ToString();
            date_NgaySX.Text = dt_GridViewCH.CurrentRow.Cells["NGAYSANXUAT"].Value.ToString();
            txt_NamHH.Text = dt_GridViewCH.CurrentRow.Cells["NAMHETHAN"].Value.ToString();
         
        }

        private void btn_Đếm_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT(*) from CUAHANG ";
            int kq = (int)lopDungChung.LayGT(sql);
            txt_Dem.Text = kq.ToString();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            string CuaHang = "SELECT * FROM CUAHANG";
            dt_GridViewCH.DataSource = lopDungChung.LoadDL(CuaHang);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE CUAHANG set TENHANG = '" + txt_TenHang.Text + "', NGAYSANXUAT = " + "Convert(datetime, '" + date_NgaySX.Text + "', 103), NAMHETHAN = '" + txt_NamHH.Text + "', MANHACUNGCAP = '" + cb_NhaCC.SelectedValue + "' where MAHANG = '" + txt_MaH.Text + "'";
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
            string sql = "DELETE CUAHANG where MAHANG = '" + txt_MaH.Text + "'";
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

       

        private void date_NgaySX_ValueChanged(object sender, EventArgs e)
        {
            int NamHetHan = date_NgaySX.Value.Year + 3;
            txt_NamHH.Text = NamHetHan.ToString();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txt_TimKiem.Text;
            string sql = "SELECT * FROM CUAHANG WHERE TENHANG LIKE @TENHANG";
            dt_GridViewCH.DataSource = lopDungChung.TimKiem(sql, timKiem);
        }

        
    }
}
