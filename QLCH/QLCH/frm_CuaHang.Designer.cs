namespace QLCH
{
    partial class frm_CuaHang
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
            this.txt_MaH = new System.Windows.Forms.TextBox();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.date_NgaySX = new System.Windows.Forms.DateTimePicker();
            this.txt_NamHH = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dt_GridViewCH = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Đếm = new System.Windows.Forms.Button();
            this.txt_Dem = new System.Windows.Forms.TextBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.cb_NhaCC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_GridViewCH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MÃ HÀNG";
            // 
            // txt_MaH
            // 
            this.txt_MaH.Location = new System.Drawing.Point(211, 55);
            this.txt_MaH.Name = "txt_MaH";
            this.txt_MaH.Size = new System.Drawing.Size(164, 22);
            this.txt_MaH.TabIndex = 2;
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.Location = new System.Drawing.Point(211, 132);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(164, 22);
            this.txt_TenHang.TabIndex = 3;
            // 
            // date_NgaySX
            // 
            this.date_NgaySX.CustomFormat = "dd/MM/yyyy";
            this.date_NgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgaySX.Location = new System.Drawing.Point(211, 212);
            this.date_NgaySX.Name = "date_NgaySX";
            this.date_NgaySX.Size = new System.Drawing.Size(200, 22);
            this.date_NgaySX.TabIndex = 4;
            this.date_NgaySX.ValueChanged += new System.EventHandler(this.date_NgaySX_ValueChanged);
            // 
            // txt_NamHH
            // 
            this.txt_NamHH.Location = new System.Drawing.Point(680, 206);
            this.txt_NamHH.Name = "txt_NamHH";
            this.txt_NamHH.Size = new System.Drawing.Size(100, 22);
            this.txt_NamHH.TabIndex = 5;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(120, 266);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dt_GridViewCH
            // 
            this.dt_GridViewCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_GridViewCH.Location = new System.Drawing.Point(103, 347);
            this.dt_GridViewCH.Name = "dt_GridViewCH";
            this.dt_GridViewCH.RowHeadersWidth = 51;
            this.dt_GridViewCH.RowTemplate.Height = 24;
            this.dt_GridViewCH.Size = new System.Drawing.Size(627, 172);
            this.dt_GridViewCH.TabIndex = 8;
            this.dt_GridViewCH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_GridViewCH_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "NĂM HẾT HẠN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "NGÀY SẢN XUẤT";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(476, 266);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(289, 266);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Đếm
            // 
            this.btn_Đếm.Location = new System.Drawing.Point(517, 135);
            this.btn_Đếm.Name = "btn_Đếm";
            this.btn_Đếm.Size = new System.Drawing.Size(75, 23);
            this.btn_Đếm.TabIndex = 13;
            this.btn_Đếm.Text = "Đếm";
            this.btn_Đếm.UseVisualStyleBackColor = true;
            this.btn_Đếm.Click += new System.EventHandler(this.btn_Đếm_Click);
            // 
            // txt_Dem
            // 
            this.txt_Dem.Location = new System.Drawing.Point(680, 136);
            this.txt_Dem.Name = "txt_Dem";
            this.txt_Dem.Size = new System.Drawing.Size(100, 22);
            this.txt_Dem.TabIndex = 14;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(655, 266);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 15;
            this.btn_Load.Text = "Load lại danh sách";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // cb_NhaCC
            // 
            this.cb_NhaCC.FormattingEnabled = true;
            this.cb_NhaCC.Location = new System.Drawing.Point(680, 58);
            this.cb_NhaCC.Name = "cb_NhaCC";
            this.cb_NhaCC.Size = new System.Drawing.Size(121, 24);
            this.cb_NhaCC.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "MÃ NHÀ CUNG CẤP";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(897, 55);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(162, 23);
            this.btn_TimKiem.TabIndex = 18;
            this.btn_TimKiem.Text = "Tìm Theo Tên Hàng";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(897, 107);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(212, 22);
            this.txt_TimKiem.TabIndex = 19;
            // 
            // frm_CuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 560);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_NhaCC);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.txt_Dem);
            this.Controls.Add(this.btn_Đếm);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_GridViewCH);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_NamHH);
            this.Controls.Add(this.date_NgaySX);
            this.Controls.Add(this.txt_TenHang);
            this.Controls.Add(this.txt_MaH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_CuaHang";
            this.Text = "CỬA HÀNG";
            this.Load += new System.EventHandler(this.frm_CuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_GridViewCH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaH;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.DateTimePicker date_NgaySX;
        private System.Windows.Forms.TextBox txt_NamHH;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dt_GridViewCH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Đếm;
        private System.Windows.Forms.TextBox txt_Dem;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.ComboBox cb_NhaCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
    }
}