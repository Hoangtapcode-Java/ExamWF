namespace QUANLYBANMAYTINH
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNLÝTHIẾTBỊToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOẠITHIẾTBỊToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOẠITHIẾTBỊToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem,
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem,
            this.qUẢNLÝTHIẾTBỊToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qUẢNLÝNHÂNVIÊNToolStripMenuItem
            // 
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem.Name = "qUẢNLÝNHÂNVIÊNToolStripMenuItem";
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem.Text = "QUẢN LÝ NHÂN VIÊN";
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem.Click += new System.EventHandler(this.qUẢNLÝNHÂNVIÊNToolStripMenuItem_Click);
            // 
            // qUẢNLÝKHÁCHHÀNGToolStripMenuItem
            // 
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Name = "qUẢNLÝKHÁCHHÀNGToolStripMenuItem";
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Click += new System.EventHandler(this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem_Click);
            // 
            // qUẢNLÝTHIẾTBỊToolStripMenuItem
            // 
            this.qUẢNLÝTHIẾTBỊToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOẠITHIẾTBỊToolStripMenuItem,
            this.lOẠITHIẾTBỊToolStripMenuItem1});
            this.qUẢNLÝTHIẾTBỊToolStripMenuItem.Name = "qUẢNLÝTHIẾTBỊToolStripMenuItem";
            this.qUẢNLÝTHIẾTBỊToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.qUẢNLÝTHIẾTBỊToolStripMenuItem.Text = "QUẢN LÝ THIẾT BỊ";
            // 
            // lOẠITHIẾTBỊToolStripMenuItem
            // 
            this.lOẠITHIẾTBỊToolStripMenuItem.Name = "lOẠITHIẾTBỊToolStripMenuItem";
            this.lOẠITHIẾTBỊToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lOẠITHIẾTBỊToolStripMenuItem.Text = "THIẾT BỊ";
            this.lOẠITHIẾTBỊToolStripMenuItem.Click += new System.EventHandler(this.lOẠITHIẾTBỊToolStripMenuItem_Click);
            // 
            // lOẠITHIẾTBỊToolStripMenuItem1
            // 
            this.lOẠITHIẾTBỊToolStripMenuItem1.Name = "lOẠITHIẾTBỊToolStripMenuItem1";
            this.lOẠITHIẾTBỊToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.lOẠITHIẾTBỊToolStripMenuItem1.Text = "LOẠI THIẾT BỊ";
            this.lOẠITHIẾTBỊToolStripMenuItem1.Click += new System.EventHandler(this.lOẠITHIẾTBỊToolStripMenuItem1_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.Text = "DANH MỤC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝNHÂNVIÊNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝKHÁCHHÀNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝTHIẾTBỊToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOẠITHIẾTBỊToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOẠITHIẾTBỊToolStripMenuItem1;
    }
}