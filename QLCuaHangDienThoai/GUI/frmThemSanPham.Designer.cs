namespace QLCuaHangDienThoai
{
    partial class frmThemSanPham
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemSanPham));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dtgvThemSP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadMa = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbbMaSX = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtManHinh = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.txtHeDieuHanh = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtBoNhoTrong = new System.Windows.Forms.TextBox();
            this.txtTrongLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDoDay = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThoiGianBaoHanh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dtgvThemSP
            // 
            this.dtgvThemSP.AllowUserToAddRows = false;
            this.dtgvThemSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThemSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThemSP.Location = new System.Drawing.Point(33, 402);
            this.dtgvThemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvThemSP.Name = "dtgvThemSP";
            this.dtgvThemSP.ReadOnly = true;
            this.dtgvThemSP.RowHeadersVisible = false;
            this.dtgvThemSP.RowTemplate.Height = 28;
            this.dtgvThemSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvThemSP.Size = new System.Drawing.Size(1538, 438);
            this.dtgvThemSP.TabIndex = 31;
            this.dtgvThemSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThemSP_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(594, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 60);
            this.label1.TabIndex = 22;
            this.label1.Text = " SẢN PHẨM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btnLoadMa);
            this.groupBox1.Controls.Add(this.btnSuaSP);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cbbMaSX);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnThemSP);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.txtManHinh);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtChieuDai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtXuatXu);
            this.groupBox1.Controls.Add(this.lbMaSP);
            this.groupBox1.Controls.Add(this.txtHeDieuHanh);
            this.groupBox1.Controls.Add(this.txtRam);
            this.groupBox1.Controls.Add(this.txtBoNhoTrong);
            this.groupBox1.Controls.Add(this.txtTrongLuong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDoDay);
            this.groupBox1.Controls.Add(this.txtChieuRong);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtThoiGianBaoHanh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(33, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1551, 318);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLoadMa
            // 
            this.btnLoadMa.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadMa.Image")));
            this.btnLoadMa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadMa.Location = new System.Drawing.Point(297, 40);
            this.btnLoadMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadMa.Name = "btnLoadMa";
            this.btnLoadMa.Size = new System.Drawing.Size(42, 46);
            this.btnLoadMa.TabIndex = 80;
            this.btnLoadMa.UseVisualStyleBackColor = true;
            this.btnLoadMa.Click += new System.EventHandler(this.btnLoadMa_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.BackColor = System.Drawing.Color.Silver;
            this.btnSuaSP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSP.ForeColor = System.Drawing.Color.Black;
            this.btnSuaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSP.Image")));
            this.btnSuaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaSP.Location = new System.Drawing.Point(1389, 48);
            this.btnSuaSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(156, 69);
            this.btnSuaSP.TabIndex = 79;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = false;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1389, 48);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 69);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbbMaSX
            // 
            this.cbbMaSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaSX.FormattingEnabled = true;
            this.cbbMaSX.Location = new System.Drawing.Point(192, 192);
            this.cbbMaSX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbMaSX.Name = "cbbMaSX";
            this.cbbMaSX.Size = new System.Drawing.Size(145, 31);
            this.cbbMaSX.TabIndex = 77;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Silver;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(1389, 157);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(156, 69);
            this.btnHome.TabIndex = 76;
            this.btnHome.Text = "Quay lại";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.Silver;
            this.btnThemSP.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSP.Image")));
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSP.Location = new System.Drawing.Point(1389, 48);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(156, 69);
            this.btnThemSP.TabIndex = 75;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1062, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 23);
            this.label13.TabIndex = 72;
            this.label13.Text = "Bộ nhớ trong:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1058, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 23);
            this.label14.TabIndex = 73;
            this.label14.Text = "Hệ điều hành:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1062, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 23);
            this.label15.TabIndex = 74;
            this.label15.Text = "Mô tả:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1058, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 23);
            this.label16.TabIndex = 71;
            this.label16.Text = "Ram:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(724, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 23);
            this.label10.TabIndex = 68;
            this.label10.Text = "Độ dày:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(724, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 23);
            this.label11.TabIndex = 69;
            this.label11.Text = "Trọng Lượng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(729, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 23);
            this.label12.TabIndex = 70;
            this.label12.Text = "Màn Hình:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(384, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 67;
            this.label8.Text = "Chiều dài:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 66;
            this.label6.Text = "Thời Gian BH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 65;
            this.label5.Text = "Đơn Giá:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(1222, 232);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(320, 78);
            this.txtMoTa.TabIndex = 64;
            // 
            // txtManHinh
            // 
            this.txtManHinh.Location = new System.Drawing.Point(879, 262);
            this.txtManHinh.Multiline = true;
            this.txtManHinh.Name = "txtManHinh";
            this.txtManHinh.Size = new System.Drawing.Size(145, 33);
            this.txtManHinh.TabIndex = 62;
            this.txtManHinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChieuRong_KeyPress);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(192, 262);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(145, 33);
            this.txtDonGia.TabIndex = 58;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChieuRong_KeyPress);
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(540, 262);
            this.txtChieuDai.Multiline = true;
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(145, 33);
            this.txtChieuDai.TabIndex = 59;
            this.txtChieuDai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChieuRong_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 23);
            this.label7.TabIndex = 55;
            this.label7.Text = "Số Lượng:";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(540, 117);
            this.txtXuatXu.Multiline = true;
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(145, 33);
            this.txtXuatXu.TabIndex = 56;
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.BackColor = System.Drawing.Color.Transparent;
            this.lbMaSP.Location = new System.Drawing.Point(188, 52);
            this.lbMaSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(0, 23);
            this.lbMaSP.TabIndex = 54;
            // 
            // txtHeDieuHanh
            // 
            this.txtHeDieuHanh.Location = new System.Drawing.Point(1222, 191);
            this.txtHeDieuHanh.Multiline = true;
            this.txtHeDieuHanh.Name = "txtHeDieuHanh";
            this.txtHeDieuHanh.Size = new System.Drawing.Size(145, 33);
            this.txtHeDieuHanh.TabIndex = 52;
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(1222, 48);
            this.txtRam.Multiline = true;
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(145, 33);
            this.txtRam.TabIndex = 53;
            // 
            // txtBoNhoTrong
            // 
            this.txtBoNhoTrong.Location = new System.Drawing.Point(1222, 122);
            this.txtBoNhoTrong.Multiline = true;
            this.txtBoNhoTrong.Name = "txtBoNhoTrong";
            this.txtBoNhoTrong.Size = new System.Drawing.Size(145, 33);
            this.txtBoNhoTrong.TabIndex = 51;
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.Location = new System.Drawing.Point(879, 191);
            this.txtTrongLuong.Multiline = true;
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.Size = new System.Drawing.Size(145, 33);
            this.txtTrongLuong.TabIndex = 46;
            this.txtTrongLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChieuRong_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(724, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 23);
            this.label9.TabIndex = 44;
            this.label9.Text = "Chiều rộng:";
            // 
            // txtDoDay
            // 
            this.txtDoDay.Location = new System.Drawing.Point(879, 117);
            this.txtDoDay.Multiline = true;
            this.txtDoDay.Name = "txtDoDay";
            this.txtDoDay.Size = new System.Drawing.Size(145, 33);
            this.txtDoDay.TabIndex = 45;
            this.txtDoDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChieuRong_KeyPress);
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(879, 48);
            this.txtChieuRong.Multiline = true;
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(145, 33);
            this.txtChieuRong.TabIndex = 41;
            this.txtChieuRong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChieuRong_KeyPress);
            // 
            // txtMa
            // 
            this.txtMa.AutoSize = true;
            this.txtMa.BackColor = System.Drawing.Color.Transparent;
            this.txtMa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(33, 52);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(133, 23);
            this.txtMa.TabIndex = 23;
            this.txtMa.Text = "Mã Sản Phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Xuất Xứ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tên Sản Phẩm:";
            // 
            // txtThoiGianBaoHanh
            // 
            this.txtThoiGianBaoHanh.Location = new System.Drawing.Point(540, 191);
            this.txtThoiGianBaoHanh.Multiline = true;
            this.txtThoiGianBaoHanh.Name = "txtThoiGianBaoHanh";
            this.txtThoiGianBaoHanh.Size = new System.Drawing.Size(145, 33);
            this.txtThoiGianBaoHanh.TabIndex = 38;
            this.txtThoiGianBaoHanh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChieuRong_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tên Hãng SX:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(540, 48);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(145, 33);
            this.txtSoLuong.TabIndex = 36;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChieuRong_KeyPress);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(192, 117);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(145, 33);
            this.txtTenSP.TabIndex = 34;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // frmThemSanPham
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1600, 855);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvThemSP);
            this.Controls.Add(this.label1);
            this.Name = "frmThemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sản Phẩm";
            this.Load += new System.EventHandler(this.frmThemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dtgvThemSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.ComboBox cbbMaSX;
        public System.Windows.Forms.Button btnSuaSP;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnThemSP;
        public System.Windows.Forms.Label lbMaSP;
        public System.Windows.Forms.Button btnLoadMa;
        public System.Windows.Forms.TextBox txtHeDieuHanh;
        public System.Windows.Forms.TextBox txtRam;
        public System.Windows.Forms.TextBox txtBoNhoTrong;
        public System.Windows.Forms.TextBox txtTrongLuong;
        public System.Windows.Forms.TextBox txtDoDay;
        public System.Windows.Forms.TextBox txtChieuRong;
        public System.Windows.Forms.TextBox txtThoiGianBaoHanh;
        public System.Windows.Forms.TextBox txtSoLuong;
        public System.Windows.Forms.TextBox txtTenSP;
        public System.Windows.Forms.TextBox txtMoTa;
        public System.Windows.Forms.TextBox txtManHinh;
        public System.Windows.Forms.TextBox txtDonGia;
        public System.Windows.Forms.TextBox txtChieuDai;
        public System.Windows.Forms.TextBox txtXuatXu;
    }
}