namespace QLCuaHangDienThoai
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnuHT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDT = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHT,
            this.mnuDT,
            this.menu_DatHang,
            this.menu_NhanVien,
            this.mnu_KhachHang,
            this.mnu_HoaDon});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(120, 427);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // mnuHT
            // 
            this.mnuHT.BackColor = System.Drawing.Color.Transparent;
            this.mnuHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDN,
            this.mnuDX,
            this.mnuThoat});
            this.mnuHT.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuHT.ForeColor = System.Drawing.Color.Black;
            this.mnuHT.Name = "mnuHT";
            this.mnuHT.Size = new System.Drawing.Size(107, 27);
            this.mnuHT.Text = "Hệ Thống";
            this.mnuHT.Click += new System.EventHandler(this.mnuHT_Click);
            // 
            // mnuDN
            // 
            this.mnuDN.BackColor = System.Drawing.SystemColors.Control;
            this.mnuDN.ForeColor = System.Drawing.Color.Red;
            this.mnuDN.Image = ((System.Drawing.Image)(resources.GetObject("mnuDN.Image")));
            this.mnuDN.Name = "mnuDN";
            this.mnuDN.Size = new System.Drawing.Size(183, 28);
            this.mnuDN.Text = "Đăng nhập";
            this.mnuDN.Click += new System.EventHandler(this.mnuDN_Click);
            // 
            // mnuDX
            // 
            this.mnuDX.BackColor = System.Drawing.SystemColors.Control;
            this.mnuDX.ForeColor = System.Drawing.Color.Red;
            this.mnuDX.Image = ((System.Drawing.Image)(resources.GetObject("mnuDX.Image")));
            this.mnuDX.Name = "mnuDX";
            this.mnuDX.Size = new System.Drawing.Size(183, 28);
            this.mnuDX.Text = "Đăng xuất";
            this.mnuDX.Visible = false;
            this.mnuDX.Click += new System.EventHandler(this.mnuDX_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.BackColor = System.Drawing.SystemColors.Control;
            this.mnuThoat.ForeColor = System.Drawing.Color.Red;
            this.mnuThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuThoat.Image")));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(183, 28);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDT
            // 
            this.mnuDT.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuDT.ForeColor = System.Drawing.Color.Black;
            this.mnuDT.Name = "mnuDT";
            this.mnuDT.Size = new System.Drawing.Size(129, 27);
            this.mnuDT.Text = "Điện Thoại";
            this.mnuDT.Visible = false;
            this.mnuDT.Click += new System.EventHandler(this.mnuDT_Click);
            // 
            // menu_DatHang
            // 
            this.menu_DatHang.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_DatHang.Name = "menu_DatHang";
            this.menu_DatHang.Size = new System.Drawing.Size(129, 27);
            this.menu_DatHang.Text = "Mua Hàng";
            this.menu_DatHang.Visible = false;
            this.menu_DatHang.Click += new System.EventHandler(this.menu_DatHang_Click);
            // 
            // menu_NhanVien
            // 
            this.menu_NhanVien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_NhanVien.Name = "menu_NhanVien";
            this.menu_NhanVien.Size = new System.Drawing.Size(129, 27);
            this.menu_NhanVien.Text = "Nhân Viên";
            this.menu_NhanVien.Visible = false;
            this.menu_NhanVien.Click += new System.EventHandler(this.menu_NhanVien_Click);
            // 
            // mnu_KhachHang
            // 
            this.mnu_KhachHang.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_KhachHang.Name = "mnu_KhachHang";
            this.mnu_KhachHang.Size = new System.Drawing.Size(129, 27);
            this.mnu_KhachHang.Text = "Khách Hàng";
            this.mnu_KhachHang.Visible = false;
            this.mnu_KhachHang.Click += new System.EventHandler(this.mnu_KhachHang_Click);
            // 
            // mnu_HoaDon
            // 
            this.mnu_HoaDon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.mnu_HoaDon.Name = "mnu_HoaDon";
            this.mnu_HoaDon.Size = new System.Drawing.Size(107, 27);
            this.mnu_HoaDon.Text = "Hóa Đơn";
            this.mnu_HoaDon.Visible = false;
            this.mnu_HoaDon.Click += new System.EventHandler(this.mnu_HoaDon_Click);
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.Location = new System.Drawing.Point(909, 9);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(0, 33);
            this.lbTenNhanVien.TabIndex = 3;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 427);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuHT;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Label lbTenNhanVien;
        public System.Windows.Forms.ToolStripMenuItem mnuDT;
        public System.Windows.Forms.ToolStripMenuItem menu_DatHang;
        public System.Windows.Forms.ToolStripMenuItem menu_NhanVien;
        public System.Windows.Forms.ToolStripMenuItem mnuDN;
        public System.Windows.Forms.ToolStripMenuItem mnu_KhachHang;
        public System.Windows.Forms.ToolStripMenuItem mnuDX;
        public System.Windows.Forms.ToolStripMenuItem mnu_HoaDon;
    }
}