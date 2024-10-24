namespace DEMO
{
    partial class frm_CUAHANG
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.txt_Dem = new System.Windows.Forms.TextBox();
            this.txt_de = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.date_NgaySX = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_NamHH = new System.Windows.Forms.TextBox();
            this.dt_GridViewCH = new System.Windows.Forms.DataGridView();
            this.cb_NhaCC = new System.Windows.Forms.ComboBox();
            this.btn_Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_GridViewCH)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(72, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "labelControl1";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(72, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "labelControl2";
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.Location = new System.Drawing.Point(198, 23);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.Size = new System.Drawing.Size(100, 22);
            this.txt_MaHang.TabIndex = 2;
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.Location = new System.Drawing.Point(198, 85);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(100, 22);
            this.txt_TenHang.TabIndex = 3;
            // 
            // txt_Dem
            // 
            this.txt_Dem.Location = new System.Drawing.Point(422, 26);
            this.txt_Dem.Name = "txt_Dem";
            this.txt_Dem.Size = new System.Drawing.Size(100, 22);
            this.txt_Dem.TabIndex = 4;
            // 
            // txt_de
            // 
            this.txt_de.Location = new System.Drawing.Point(341, 26);
            this.txt_de.Name = "txt_de";
            this.txt_de.Size = new System.Drawing.Size(75, 23);
            this.txt_de.TabIndex = 5;
            this.txt_de.Text = "dem";
            this.txt_de.UseVisualStyleBackColor = true;
            this.txt_de.Click += new System.EventHandler(this.txt_de_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(72, 209);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Them";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(341, 209);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 7;
            this.btn_Remove.Text = "Xoa";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(198, 209);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 7;
            this.btn_Edit.Text = "Sua";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(72, 159);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "labelControl3";
            // 
            // date_NgaySX
            // 
            this.date_NgaySX.CustomFormat = "dd/MM/yyyy";
            this.date_NgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgaySX.Location = new System.Drawing.Point(198, 159);
            this.date_NgaySX.Name = "date_NgaySX";
            this.date_NgaySX.Size = new System.Drawing.Size(200, 22);
            this.date_NgaySX.TabIndex = 9;
            this.date_NgaySX.ValueChanged += new System.EventHandler(this.date_NgaySX_ValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(436, 164);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 16);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "labelControl4";
            // 
            // txt_NamHH
            // 
            this.txt_NamHH.Location = new System.Drawing.Point(528, 161);
            this.txt_NamHH.Name = "txt_NamHH";
            this.txt_NamHH.Size = new System.Drawing.Size(100, 22);
            this.txt_NamHH.TabIndex = 11;
            this.txt_NamHH.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dt_GridViewCH
            // 
            this.dt_GridViewCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_GridViewCH.Location = new System.Drawing.Point(85, 273);
            this.dt_GridViewCH.Name = "dt_GridViewCH";
            this.dt_GridViewCH.RowHeadersWidth = 51;
            this.dt_GridViewCH.RowTemplate.Height = 24;
            this.dt_GridViewCH.Size = new System.Drawing.Size(632, 150);
            this.dt_GridViewCH.TabIndex = 12;
            this.dt_GridViewCH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_GridViewCH_CellContentClick);
            // 
            // cb_NhaCC
            // 
            this.cb_NhaCC.FormattingEnabled = true;
            this.cb_NhaCC.Location = new System.Drawing.Point(422, 77);
            this.cb_NhaCC.Name = "cb_NhaCC";
            this.cb_NhaCC.Size = new System.Drawing.Size(121, 24);
            this.cb_NhaCC.TabIndex = 13;
            this.cb_NhaCC.SelectedIndexChanged += new System.EventHandler(this.cb_NhaCC_SelectedIndexChanged);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(467, 209);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 14;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_CUAHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.cb_NhaCC);
            this.Controls.Add(this.dt_GridViewCH);
            this.Controls.Add(this.txt_NamHH);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.date_NgaySX);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_de);
            this.Controls.Add(this.txt_Dem);
            this.Controls.Add(this.txt_TenHang);
            this.Controls.Add(this.txt_MaHang);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frm_CUAHANG";
            this.Text = "frm_CUAHANG";
            this.Load += new System.EventHandler(this.frm_CUAHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_GridViewCH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.TextBox txt_Dem;
        private System.Windows.Forms.Button txt_de;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Edit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker date_NgaySX;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txt_NamHH;
        private System.Windows.Forms.DataGridView dt_GridViewCH;
        private System.Windows.Forms.ComboBox cb_NhaCC;
        private System.Windows.Forms.Button btn_Load;
    }
}