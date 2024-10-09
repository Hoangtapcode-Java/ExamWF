namespace QUANLYBANMAYTINH
{
    partial class frm_LoaiThietBi
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
            this.txt_MaLTB = new System.Windows.Forms.TextBox();
            this.txt_TenLTB = new System.Windows.Forms.TextBox();
            this.data_GridViewLTB = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sửa = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_GridViewLTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại Thiết Bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Loại Thiết Bị";
            // 
            // txt_MaLTB
            // 
            this.txt_MaLTB.Location = new System.Drawing.Point(260, 45);
            this.txt_MaLTB.Name = "txt_MaLTB";
            this.txt_MaLTB.Size = new System.Drawing.Size(236, 22);
            this.txt_MaLTB.TabIndex = 2;
            // 
            // txt_TenLTB
            // 
            this.txt_TenLTB.Location = new System.Drawing.Point(260, 141);
            this.txt_TenLTB.Name = "txt_TenLTB";
            this.txt_TenLTB.Size = new System.Drawing.Size(236, 22);
            this.txt_TenLTB.TabIndex = 3;
            // 
            // data_GridViewLTB
            // 
            this.data_GridViewLTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_GridViewLTB.Location = new System.Drawing.Point(642, 26);
            this.data_GridViewLTB.Name = "data_GridViewLTB";
            this.data_GridViewLTB.RowHeadersWidth = 51;
            this.data_GridViewLTB.RowTemplate.Height = 24;
            this.data_GridViewLTB.Size = new System.Drawing.Size(387, 150);
            this.data_GridViewLTB.TabIndex = 4;
            this.data_GridViewLTB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_GridViewLTB_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(75, 232);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(103, 42);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sửa
            // 
            this.btn_Sửa.Location = new System.Drawing.Point(285, 232);
            this.btn_Sửa.Name = "btn_Sửa";
            this.btn_Sửa.Size = new System.Drawing.Size(103, 42);
            this.btn_Sửa.TabIndex = 6;
            this.btn_Sửa.Text = "Sửa";
            this.btn_Sửa.UseVisualStyleBackColor = true;
            this.btn_Sửa.Click += new System.EventHandler(this.btn_Sửa_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(503, 232);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(103, 42);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // frm_LoaiThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sửa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.data_GridViewLTB);
            this.Controls.Add(this.txt_TenLTB);
            this.Controls.Add(this.txt_MaLTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_LoaiThietBi";
            this.Text = "LOẠI THIẾT BỊ";
            this.Load += new System.EventHandler(this.frm_LoaiThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_GridViewLTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaLTB;
        private System.Windows.Forms.TextBox txt_TenLTB;
        private System.Windows.Forms.DataGridView data_GridViewLTB;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sửa;
        private System.Windows.Forms.Button btn_Xoa;
    }
}