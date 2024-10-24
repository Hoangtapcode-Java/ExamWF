using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    public partial class frm_CUAHANG : Form
    {
        Lopdungchung lopdungchung = new Lopdungchung();
        public frm_CUAHANG()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string sql = "Insert into CUAHANG values('" + txt_MaHang.Text + "','" + txt_TenHang.Text + "',Convert(datetime,'" + date_NgaySX.Text + "',103),'" + txt_NamHH.Text + "','" + cb_NhaCC.SelectedValue + "')";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }

        private void cb_NhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_CUAHANG_Load(object sender, EventArgs e)
        {
            string CuaHang = "SELECT * FROM CUAHANG";
            dt_GridViewCH.DataSource = lopdungchung.LoadDL(CuaHang);
            string NhaCC = "SELECT * FROM NHACUNGCAP";
            cb_NhaCC.DataSource = lopdungchung.LoadDL(NhaCC);
            cb_NhaCC.ValueMember = "MANHACUNGCAP";
            cb_NhaCC.DisplayMember = "TEN";
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            string sql = "DELETE CUAHANG where MAHANG = '" + txt_MaHang.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string CuaHang = "SELECT * FROM CUAHANG";
            dt_GridViewCH.DataSource = lopdungchung.LoadDL(CuaHang);
        }

        private void txt_de_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT(*) from CUAHANG ";
            int kq = (int)lopdungchung.LayGT(sql);
            txt_Dem.Text = kq.ToString();
        }

        private void date_NgaySX_ValueChanged(object sender, EventArgs e)
        {
            int NamHetHan = date_NgaySX.Value.Year + 3;
            txt_NamHH.Text = NamHetHan.ToString();
        }

        private void dt_GridViewCH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHang.Text = dt_GridViewCH.CurrentRow.Cells["MAHANG"].Value.ToString();
            txt_TenHang.Text = dt_GridViewCH.CurrentRow.Cells["TENHANG"].Value.ToString();
            date_NgaySX.Text = dt_GridViewCH.CurrentRow.Cells["NGAYSANXUAT"].Value.ToString();
            txt_NamHH.Text = dt_GridViewCH.CurrentRow.Cells["NAMHETHAN"].Value.ToString();
        }
    }
}
