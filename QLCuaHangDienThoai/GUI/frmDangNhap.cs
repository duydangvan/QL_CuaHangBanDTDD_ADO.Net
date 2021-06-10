using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLCuaHangDienThoai
{
    public partial class frmDangNhap : Form
    {
        XulyTV xl = new XulyTV();
        ketnoi kn = new ketnoi();
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(kn.connectionSTR);
            //try
            //{
                
                if (txtTK.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tài khoản !!!", "Thông Báo");
                    return;
                }
                conn.Open();
                string sql;
                sql = "select * from thanhvien where taikhoan='" + txtTK.Text + "' and matkhau='" + txtMK.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công", "Thông Báo");
                    string query = "select chucvu from nhanvien n, thanhvien t where n.MANV=t.MANV and TAIKHOAN='" + txtTK.Text + "' and MATKHAU='" + txtMK.Text + "'";
                    string chucvu = kn.layDLDangChuoi(query);
                    frmHome f = new frmHome();
                    if (chucvu == "Chủ")
                    {   
                        //gửi tên đăng nhập với mật khẩu qua form Home
                        f.nhan(txtTK.Text, txtMK.Text);
                        f.menu_NhanVien.Visible = true;
                        f.mnuDT.Visible = true;
                        f.menu_DatHang.Visible = true;
                        f.mnuDN.Visible = false;
                        this.Visible = false;
                    f.mnu_KhachHang.Visible = true;
                    f.mnuDX.Visible = true;
                    f.mnu_HoaDon.Visible = true;
                        f.ShowDialog();
                    }
                    else
                    {
                        if(chucvu=="Nhân Viên")
                        {
                            f.nhan(txtTK.Text, txtMK.Text);
                            f.mnuDT.Visible = true;
                            f.menu_DatHang.Visible = true;
                            f.mnuDN.Visible = false;
                            this.Visible = false;
                            f.mnu_KhachHang.Visible = true;
                        f.mnuDX.Visible = true;
                        f.mnu_HoaDon.Visible = true;
                        f.ShowDialog();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu của bạn sai rồi. Vui lòng nhập lại !!!", "Thông Báo");
                    txtMK.Clear();
                    txtMK.Focus();
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi kết nối");
            //}
            
        }
        private void btnDK_Click(object sender, EventArgs e)
        {
            frmDangKy dk = new frmDangKy();
            dk.ShowDialog();
            
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTK.Focus();
        }
    }
}
