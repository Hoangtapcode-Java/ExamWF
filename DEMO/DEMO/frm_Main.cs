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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            
        }
        frm_CUAHANG ch = new frm_CUAHANG();
        private void oPENCUAHANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_CUAHANG"] == null)
            {
                
                ch.MdiParent = this;
                ch.Show();
            }
            else Application.OpenForms["frm_CUAHANG"].Activate();
        }

        private void cLOSECUAHANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ch.Hide();
        }
    }
}
