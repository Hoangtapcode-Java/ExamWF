namespace KiemTraGiuaKy
{
    partial class frm_ThucDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NamHetHan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaTD = new System.Windows.Forms.TextBox();
            this.txt_TenTD = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_Dem = new System.Windows.Forms.TextBox();
            this.date_NgayCapThe = new System.Windows.Forms.DateTimePicker();
            this.cb_LoaiKhach = new System.Windows.Forms.ComboBox();
            this.btn_Dem = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dt_GridViewTD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dt_GridViewTD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã TD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại Khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Cấp Thẻ TV";
            // 
            // txt_NamHetHan
            // 
            this.txt_NamHetHan.AutoSize = true;
            this.txt_NamHetHan.Location = new System.Drawing.Point(476, 230);
            this.txt_NamHetHan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_NamHetHan.Name = "txt_NamHetHan";
            this.txt_NamHetHan.Size = new System.Drawing.Size(163, 24);
            this.txt_NamHetHan.TabIndex = 3;
            this.txt_NamHetHan.Text = "Năm Hết Hạn Thẻ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên TD";
            // 
            // txt_MaTD
            // 
            this.txt_MaTD.Location = new System.Drawing.Point(184, 84);
            this.txt_MaTD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaTD.Name = "txt_MaTD";
            this.txt_MaTD.Size = new System.Drawing.Size(202, 29);
            this.txt_MaTD.TabIndex = 5;
            // 
            // txt_TenTD
            // 
            this.txt_TenTD.Location = new System.Drawing.Point(184, 147);
            this.txt_TenTD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenTD.Name = "txt_TenTD";
            this.txt_TenTD.Size = new System.Drawing.Size(202, 29);
            this.txt_TenTD.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(652, 226);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 29);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_Dem
            // 
            this.txt_Dem.Location = new System.Drawing.Point(971, 85);
            this.txt_Dem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Dem.Name = "txt_Dem";
            this.txt_Dem.Size = new System.Drawing.Size(66, 29);
            this.txt_Dem.TabIndex = 8;
            // 
            // date_NgayCapThe
            // 
            this.date_NgayCapThe.CustomFormat = "dd/MM/yyyy";
            this.date_NgayCapThe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgayCapThe.Location = new System.Drawing.Point(184, 224);
            this.date_NgayCapThe.Name = "date_NgayCapThe";
            this.date_NgayCapThe.Size = new System.Drawing.Size(200, 29);
            this.date_NgayCapThe.TabIndex = 9;
            // 
            // cb_LoaiKhach
            // 
            this.cb_LoaiKhach.FormattingEnabled = true;
            this.cb_LoaiKhach.Location = new System.Drawing.Point(652, 84);
            this.cb_LoaiKhach.Name = "cb_LoaiKhach";
            this.cb_LoaiKhach.Size = new System.Drawing.Size(121, 32);
            this.cb_LoaiKhach.TabIndex = 10;
            // 
            // btn_Dem
            // 
            this.btn_Dem.Location = new System.Drawing.Point(879, 84);
            this.btn_Dem.Name = "btn_Dem";
            this.btn_Dem.Size = new System.Drawing.Size(75, 26);
            this.btn_Dem.TabIndex = 11;
            this.btn_Dem.Text = "Đếm";
            this.btn_Dem.UseVisualStyleBackColor = true;
            this.btn_Dem.Click += new System.EventHandler(this.btn_Dem_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(444, 335);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 26);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(233, 335);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 26);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(39, 335);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 26);
            this.btn_Them.TabIndex = 14;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dt_GridViewTD
            // 
            this.dt_GridViewTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_GridViewTD.Location = new System.Drawing.Point(39, 400);
            this.dt_GridViewTD.Name = "dt_GridViewTD";
            this.dt_GridViewTD.RowHeadersWidth = 51;
            this.dt_GridViewTD.Size = new System.Drawing.Size(998, 211);
            this.dt_GridViewTD.TabIndex = 15;
            // 
            // frm_ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.dt_GridViewTD);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Dem);
            this.Controls.Add(this.cb_LoaiKhach);
            this.Controls.Add(this.date_NgayCapThe);
            this.Controls.Add(this.txt_Dem);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt_TenTD);
            this.Controls.Add(this.txt_MaTD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NamHetHan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ThucDon";
            this.Text = "THỰC ĐƠN";
            this.Load += new System.EventHandler(this.frm_ThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_GridViewTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_NamHetHan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaTD;
        private System.Windows.Forms.TextBox txt_TenTD;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txt_Dem;
        private System.Windows.Forms.DateTimePicker date_NgayCapThe;
        private System.Windows.Forms.ComboBox cb_LoaiKhach;
        private System.Windows.Forms.Button btn_Dem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dt_GridViewTD;
    }
}