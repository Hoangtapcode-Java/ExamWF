﻿namespace QUANLYBANMAYTINH
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1076, 553);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Đăng Nhập:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Gainsboro;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(272, 331);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 24);
            this.label.TabIndex = 3;
            this.label.Text = "Mật Khẩu:";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(501, 257);
            this.txt_TenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(229, 22);
            this.txt_TenDangNhap.TabIndex = 4;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(501, 332);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(229, 22);
            this.txt_MatKhau.TabIndex = 5;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Location = new System.Drawing.Point(337, 437);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(151, 59);
            this.btn_DangNhap.TabIndex = 6;
            this.btn_DangNhap.Text = "ĐĂNG NHẬP";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(540, 437);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(145, 59);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "THOÁT";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 554);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DangNhap";
            this.Text = "ĐĂNG NHẬP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Thoat;
    }
}