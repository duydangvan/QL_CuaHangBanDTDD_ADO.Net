﻿namespace QLCuaHangDienThoai
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.btnDong = new System.Windows.Forms.ToolStripButton();
            this.btnLuuNV = new System.Windows.Forms.ToolStripButton();
            this.btnSuaNV = new System.Windows.Forms.ToolStripButton();
            this.btnThemNV = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLamMoi = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(64, 28);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuNV.Image")));
            this.btnLuuNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuuNV.Name = "btnLuuNV";
            this.btnLuuNV.Size = new System.Drawing.Size(55, 28);
            this.btnLuuNV.Text = "Lưu";
            this.btnLuuNV.Visible = false;
            this.btnLuuNV.Click += new System.EventHandler(this.btnLuuNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNV.Image")));
            this.btnSuaNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(54, 28);
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.Image")));
            this.btnThemNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(65, 28);
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemNV,
            this.btnSuaNV,
            this.btnLuuNV,
            this.btnDong,
            this.btnLamMoi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(847, 31);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(82, 28);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.ToolTipText = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.cbbChucVu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(863, 165);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Nhân viên";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(518, 88);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 23);
            this.txtEmail.TabIndex = 39;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(518, 57);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(260, 23);
            this.txtSDT.TabIndex = 38;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Chức vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "SĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ngày Sinh:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(129, 125);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(260, 23);
            this.txtCMND.TabIndex = 33;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(129, 90);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(260, 23);
            this.txtDiaChi.TabIndex = 32;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(129, 55);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(260, 23);
            this.txtHoTen.TabIndex = 31;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(129, 22);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(260, 23);
            this.txtMaNV.TabIndex = 30;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(518, 125);
            this.cbbChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(260, 23);
            this.cbbChucVu.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySinh.Location = new System.Drawing.Point(518, 20);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(260, 23);
            this.txtNgaySinh.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên: ";
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.AllowUserToAddRows = false;
            this.dtgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dtgvNhanVien.Location = new System.Drawing.Point(9, 200);
            this.dtgvNhanVien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.ReadOnly = true;
            this.dtgvNhanVien.RowHeadersVisible = false;
            this.dtgvNhanVien.RowTemplate.Height = 28;
            this.dtgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNhanVien.Size = new System.Drawing.Size(821, 211);
            this.dtgvNhanVien.TabIndex = 26;
            this.dtgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhanVien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANV";
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HOTEN";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIACHI";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CMND";
            this.Column4.HeaderText = "CMND";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NGAYSINH";
            this.Column5.HeaderText = "Ngày Sinh";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.HeaderText = "Số Điện Thoại";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "EMAIL";
            this.Column7.HeaderText = "Email";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CHUCVU";
            this.Column8.HeaderText = "Chức vụ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(847, 418);
            this.Controls.Add(this.dtgvNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton btnDong;
        private System.Windows.Forms.ToolStripButton btnLuuNV;
        private System.Windows.Forms.ToolStripButton btnSuaNV;
        private System.Windows.Forms.ToolStripButton btnThemNV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ToolStripButton btnLamMoi;
    }
}