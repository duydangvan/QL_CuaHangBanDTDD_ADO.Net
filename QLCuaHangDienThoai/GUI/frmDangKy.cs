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
    public partial class frmDangKy : Form
    {
        ketnoi kn = new ketnoi();
        XulyTV xl = new XulyTV();

        public frmDangKy()
        {
            InitializeComponent();
            loadCbbNV();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {

            //try
            //{
                if (txtTK.Text != "" && txtMK.Text != "" && txtTK.Text != "Nhập tên TK" && txtMK.Text != "Nhập MK")
                {
                    string sqlTK = "select count(*) from THANHVIEN where TAIKHOAN='" + txtTK.Text + "'";
                    string queryMaNV = "select count(*) from thanhvien where manv='" + cbbMaNV.SelectedValue.ToString().Trim() + "'";
                    if (kn.KiemTraTrung(sqlTK) || kn.KiemTraTrung(queryMaNV))
                    {
                        MessageBox.Show("Đã tồn tại tài khoản này. Vui lòng nhập tên tài khoản khác", "Thông Báo");
                        txtTK.Clear();
                        txtTK.Focus();
                    }
                    else
                    {
                        thanhvien tv = new thanhvien();
                        tv.Taikhoan = txtTK.Text;
                        tv.Matkhau = txtMK.Text;
                        tv.Manv = cbbMaNV.SelectedValue.ToString().Trim();
                        xl.them(tv);
                        MessageBox.Show("Đăng ký thành công", "Thông Báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !!", "Thông Báo");
                }

            }
            //catch (Exception)
            //{
            //    MessageBox.Show("Đăng ký Thất bại", "Thông báo");
        //    //}
        //}

        private void frmDangKy_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txtHT_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            txtHT.Focus();
        }

        private void txtHT_Click(object sender, EventArgs e)
        {
            if (txtHT.Text == "Nhập họ tên")
                txtHT.Clear();

        }

        private void loadCbbNV()
        {
            string query = "select MANV from NHANVIEN ";
            DataTable table = new DataTable();
            cbbMaNV.DataSource = kn.getTable(query);
            cbbMaNV.DisplayMember = "MANV";
            cbbMaNV.ValueMember = "MANV";
        }


        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHT.Text = string.Empty;
            string query = "select HOTEN from Nhanvien where manv='" + cbbMaNV.SelectedValue + "'";
            string hoten = kn.layDLDangChuoi(query);
            txtHT.Text = hoten;
        }

        private void txtTK_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "Nhập tên TK")
                txtTK.Clear();
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            if (txtMK.Text == "Nhập MK")
                txtMK.Clear();
        }
    }
}
