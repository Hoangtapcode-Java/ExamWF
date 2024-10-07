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
    public partial class frm_DanhMuc : Form
    {
        public frm_DanhMuc()
        {
            InitializeComponent();
        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThucDon"] == null)
            {
                frm_ThucDon td = new frm_ThucDon();
                td.MdiParent = this;
                td.Show();
            }
            else Application.OpenForms["frm_ThucDon"].Activate();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
