using QLCuaHangDienThoai.BLL;
using QLCuaHangDienThoai.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDienThoai
{
    public partial class frmHome : Form
    {
        ketnoi kn = new ketnoi();
        NhanVienBLL nhanVienBLL = new NhanVienBLL(); 
        string tenDangNhap=string.Empty;
        string MatKhau=string.Empty;
        string maNV = string.Empty;

        //nhận và gán tên đăng nhập và mật khẩu từ form đăng nhập
        public delegate void nhanTDN_MK(string tenDN, string mk);

        public nhanTDN_MK nhan;

        void ganGT(string tenDN, string mk)
        {
            tenDangNhap = tenDN;
            MatKhau = mk;
        }
        public frmHome()
        {
            InitializeComponent();
            nhan = new nhanTDN_MK(ganGT);
        }

        private void mnuDN_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.ShowDialog();
            //string query = "select count(*) from nhanvien n, thanhvien t where n.MANV=t.MANV and TAIKHOAN='" + tenDangNhap + "' and MATKHAU='" + MatKhau + "'";
            //int chucvu = kn.getCount(query);
            //if (chucvu==1)
            //{
            //    this.Close();
            //}
            //else
            //{
                
            //}
        }

        private void mnuDX_Click(object sender, EventArgs e)
        {
            menu_NhanVien.Visible = false;
            mnuDT.Visible = false;
            menu_DatHang.Visible = false;
            mnuDN.Visible = true;
            lbTenNhanVien.Text = string.Empty;
            mnu_KhachHang.Visible = false;
            mnu_HoaDon.Visible = false;
            mnuDX.Visible = false;
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDT_Click(object sender, EventArgs e)
        {
            frmQLDienThoai dt = new frmQLDienThoai();
            dt.ShowDialog();
        }

        private void menu_DatHang_Click(object sender, EventArgs e)
        {
            //gửi mã nhân viên qua form đặt hàng
            frmDatHang dathang = new frmDatHang();
            dathang.layDL(maNV);
            dathang.ShowDialog();
        }

        private void menu_NhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        


        private void frmHome_Load(object sender, EventArgs e)
        {
            //string query = "select nhanvien.MANV from NHANVIEN, THANHVIEN WHERE NHANVIEN.MANV = THANHVIEN.MANV AND TAIKHOAN = '"+tenDangNhap+"' AND MATKHAU = '"+MatKhau+"'";
            //maNV = kn.layDLDangChuoi(query);
            maNV = nhanVienBLL.getMaNV(tenDangNhap,MatKhau);

            //string query1 = "select HoTEN from NHANVIEN, THANHVIEN WHERE NHANVIEN.MANV = THANHVIEN.MANV AND TAIKHOAN = '" + tenDangNhap + "' AND MATKHAU = '" + MatKhau + "'";
            //lbTenNhanVien.Text = kn.layDLDangChuoi(query1); 
            lbTenNhanVien.Text = nhanVienBLL.getNameNV(tenDangNhap,MatKhau);

        }

        private void mnu_KhachHang_Click(object sender, EventArgs e)
        {
            GUI.frmKhachHang f = new GUI.frmKhachHang();
            f.ShowDialog();
        }

        private void mnuHT_Click(object sender, EventArgs e)
        {

        }

        private void mnu_HoaDon_Click(object sender, EventArgs e)
        {
            frmXemHoaDon f = new frmXemHoaDon();
            f.ShowDialog();
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
