namespace DEMO
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
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENCUAHANGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLOSECUAHANGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPENCUAHANGToolStripMenuItem,
            this.cLOSECUAHANGToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // oPENCUAHANGToolStripMenuItem
            // 
            this.oPENCUAHANGToolStripMenuItem.Name = "oPENCUAHANGToolStripMenuItem";
            this.oPENCUAHANGToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.oPENCUAHANGToolStripMenuItem.Text = "OPEN CUAHANG";
            this.oPENCUAHANGToolStripMenuItem.Click += new System.EventHandler(this.oPENCUAHANGToolStripMenuItem_Click);
            // 
            // cLOSECUAHANGToolStripMenuItem
            // 
            this.cLOSECUAHANGToolStripMenuItem.Name = "cLOSECUAHANGToolStripMenuItem";
            this.cLOSECUAHANGToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cLOSECUAHANGToolStripMenuItem.Text = "CLOSE CUAHANG";
            this.cLOSECUAHANGToolStripMenuItem.Click += new System.EventHandler(this.cLOSECUAHANGToolStripMenuItem_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "frm_Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENCUAHANGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLOSECUAHANGToolStripMenuItem;
    }
}