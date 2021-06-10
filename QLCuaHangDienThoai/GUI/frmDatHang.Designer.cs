namespace QLCuaHangDienThoai
{
    partial class frmDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHang));
            this.btnThemDH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTaoHoaDonMoi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvSanPham = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbHangDienThoai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoaDH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemDH
            // 
            this.btnThemDH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDH.Image")));
            this.btnThemDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDH.Location = new System.Drawing.Point(208, 385);
            this.btnThemDH.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnThemDH.Name = "btnThemDH";
            this.btnThemDH.Size = new System.Drawing.Size(119, 35);
            this.btnThemDH.TabIndex = 30;
            this.btnThemDH.Text = "Thêm Đơn Hàng";
            this.btnThemDH.UseVisualStyleBackColor = true;
            this.btnThemDH.Click += new System.EventHandler(this.btnThemDH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(703, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(789, 297);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(155, 25);
            this.txtTongTien.TabIndex = 33;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(991, 320);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(114, 41);
            this.btnThanhToan.TabIndex = 35;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AllowUserToAddRows = false;
            this.dtgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgvHoaDon.Location = new System.Drawing.Point(504, 14);
            this.dtgvHoaDon.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.ReadOnly = true;
            this.dtgvHoaDon.RowHeadersVisible = false;
            this.dtgvHoaDon.RowTemplate.Height = 28;
            this.dtgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHoaDon.Size = new System.Drawing.Size(601, 267);
            this.dtgvHoaDon.TabIndex = 36;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MaSP";
            this.Column10.HeaderText = "Mã sản phẩm";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenSP";
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoLuong";
            this.Column2.HeaderText = "Số Lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DonGia";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ThanhTien";
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(949, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "VNĐ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(21, 391);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Số Lượng";
            // 
            // btnTaoHoaDonMoi
            // 
            this.btnTaoHoaDonMoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoHoaDonMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoHoaDonMoi.Image")));
            this.btnTaoHoaDonMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoHoaDonMoi.Location = new System.Drawing.Point(522, 309);
            this.btnTaoHoaDonMoi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTaoHoaDonMoi.Name = "btnTaoHoaDonMoi";
            this.btnTaoHoaDonMoi.Size = new System.Drawing.Size(133, 51);
            this.btnTaoHoaDonMoi.TabIndex = 38;
            this.btnTaoHoaDonMoi.Text = "Tạo Hóa Đơn Mới";
            this.btnTaoHoaDonMoi.UseVisualStyleBackColor = true;
            this.btnTaoHoaDonMoi.Click += new System.EventHandler(this.btnTaoHoaDonMoi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(500, 417);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tên Nhân Viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(676, 341);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ngày Tạo HĐ:";
            // 
            // txtsl
            // 
            this.txtsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsl.Location = new System.Drawing.Point(108, 385);
            this.txtsl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsl.Multiline = true;
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(86, 26);
            this.txtsl.TabIndex = 45;
            this.txtsl.Text = "0";
            this.txtsl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(804, 399);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Số Hóa Đơn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvSanPham);
            this.groupBox1.Controls.Add(this.cbbHangDienThoai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(487, 363);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Điện Thoại";
            // 
            // dtgvSanPham
            // 
            this.dtgvSanPham.AllowUserToAddRows = false;
            this.dtgvSanPham.AllowUserToOrderColumns = true;
            this.dtgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.SoLuong});
            this.dtgvSanPham.Location = new System.Drawing.Point(12, 52);
            this.dtgvSanPham.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgvSanPham.Name = "dtgvSanPham";
            this.dtgvSanPham.ReadOnly = true;
            this.dtgvSanPham.RowHeadersVisible = false;
            this.dtgvSanPham.RowTemplate.Height = 24;
            this.dtgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSanPham.Size = new System.Drawing.Size(463, 299);
            this.dtgvSanPham.TabIndex = 12;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MASP";
            this.Column9.HeaderText = "Mã Sản Phẩm";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenSP";
            this.Column5.FillWeight = 95.2381F;
            this.Column5.HeaderText = "Tên điện thoại";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DONGIA";
            this.Column6.FillWeight = 98.96977F;
            this.Column6.HeaderText = "Giá";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "RAM";
            this.Column7.FillWeight = 101.813F;
            this.Column7.HeaderText = "Ram";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "BONHOTRONG";
            this.Column8.FillWeight = 103.9792F;
            this.Column8.HeaderText = "Bộ nhớ trong";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SOLUONG";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // cbbHangDienThoai
            // 
            this.cbbHangDienThoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHangDienThoai.FormattingEnabled = true;
            this.cbbHangDienThoai.Location = new System.Drawing.Point(144, 25);
            this.cbbHangDienThoai.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbHangDienThoai.Name = "cbbHangDienThoai";
            this.cbbHangDienThoai.Size = new System.Drawing.Size(146, 21);
            this.cbbHangDienThoai.TabIndex = 11;
            this.cbbHangDienThoai.SelectedIndexChanged += new System.EventHandler(this.cbbHangDienThoai_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(39, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hãng Điện Thoại";
            // 
            // btnXoaDH
            // 
            this.btnXoaDH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDH.Image")));
            this.btnXoaDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDH.Location = new System.Drawing.Point(359, 385);
            this.btnXoaDH.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnXoaDH.Name = "btnXoaDH";
            this.btnXoaDH.Size = new System.Drawing.Size(119, 35);
            this.btnXoaDH.TabIndex = 49;
            this.btnXoaDH.Text = "Xóa Đơn Hàng";
            this.btnXoaDH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDH.UseVisualStyleBackColor = true;
            this.btnXoaDH.Click += new System.EventHandler(this.btnXoaDH_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(991, 385);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 43;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNgayLapHD
            // 
            this.txtNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayLapHD.Location = new System.Drawing.Point(789, 341);
            this.txtNgayLapHD.Name = "txtNgayLapHD";
            this.txtNgayLapHD.Size = new System.Drawing.Size(155, 20);
            this.txtNgayLapHD.TabIndex = 50;
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(900, 398);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(83, 19);
            this.lbMaHD.TabIndex = 52;
            this.lbMaHD.Text = "Mã hóa đơn";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(615, 416);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(190, 19);
            this.lbTenNV.TabIndex = 51;
            this.lbTenNV.Text = "Tên nhân viên lập hóa đơn";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(614, 385);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(185, 19);
            this.lbMaNV.TabIndex = 54;
            this.lbMaNV.Text = "Mã nhân viên lập hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(499, 386);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Mã Nhân Viên:";
            // 
            // frmDatHang
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(913, 478);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.txtNgayLapHD);
            this.Controls.Add(this.btnXoaDH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTaoHoaDonMoi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvHoaDon);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemDH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mua hàng";
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTaoHoaDonMoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbHangDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoaDH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txtNgayLapHD;
        private System.Windows.Forms.DataGridView dtgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}