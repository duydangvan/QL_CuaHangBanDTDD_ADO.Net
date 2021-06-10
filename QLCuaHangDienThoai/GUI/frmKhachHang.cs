using QLCuaHangDienThoai.BLL;
using QLCuaHangDienThoai.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDienThoai.GUI
{
    public partial class frmKhachHang : Form
    {
        ketnoi kn = new ketnoi();
        KhachHangBLL khachHangBLL = new KhachHangBLL(); 
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void loadKH()
        {
            //string query = "select * from khachhang";
            //dtgvKhachHang.DataSource = kn.getTable(query);

            dtgvKhachHang.DataSource = khachHangBLL.loadKH();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadKH();
            txtMaKH.Text = taoMaKHTuDong();
        }

        void reSet()
        {
            txtMaKH.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtNgaySinh.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private string taoMaKHTuDong()
        {
            //Random rd = new Random();
            //string maKH="KH0"+rd.Next(0,500);
            //string query = "select count(*) from khachhang where makh='"+maKH+"'";
            //int kq = kn.getCount(query);
            //while(kq>=1)
            //{
            //    maKH = "KH0" + rd.Next(0, 500);
            //    query = "select count(*) from khachhang where makh='" + maKH + "'";
            //    kq = kn.getCount(query);
            //}
            //return maKH;

            return khachHangBLL.taoMaKHTuDongKhongTrung();
        }

        private void dtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dtgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text= dtgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dtgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtNgaySinh.Text = dtgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text= dtgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text= dtgvKhachHang.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reSet();
            txtMaKH.Text = taoMaKHTuDong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            btnLuuNV.Visible = true;
        }

        public Boolean kiemTraTrungMakh()
        {
            //string query = "select count(*) from khachhang where makh='"+txtMaKH.Text+"'";
            //int kq = int.Parse(kn.getCount(query).ToString());

            int kq = khachHangBLL.soLuongKhachHanhTrung(txtMaKH.Text);
            if (kq >= 1)
            {
                return true;
            }
            else
                return false;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (!kiemTraTrungMakh())
            {
                if (txtHoTen.Text != string.Empty && txtSDT.Text != string.Empty && txtDiaChi.Text != string.Empty)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên " + txtHoTen.Text + " vào chưa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //string query = "SET DATEFORMAT DMY INSERT INTO KHACHHANG VALUES ('" + txtMaKH.Text.Trim() + "', N'" + txtHoTen.Text.Trim() + "', N'" + txtDiaChi.Text.Trim() + "', '" + txtSDT.Text.Trim() + "', '" + DateTime.Parse(txtNgaySinh.Text).ToString("dd/MM/yyyy") + "', '" + txtEmail.Text.Trim() + "')";
                        //kn.thuchien(query);
                        KhachHang kh = new KhachHang(txtMaKH.Text.Trim(), txtHoTen.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim(), DateTime.Parse(txtNgaySinh.Text).ToString("dd/MM/yyyy"), txtEmail.Text.Trim());
                        khachHangBLL.addKhachHang(kh);

                        MessageBox.Show("Đã thêm khách hàng " + txtHoTen.Text + " thành công", "Thông báo");
                        loadKH();
                        reSet();
                    }
                }
                else
                {
                    MessageBox.Show("Không được bỏ trống hị tên khách hàng, địa chỉ, số điện thoại", "Thông báo");
                }
            }
            else
                MessageBox.Show("Mã khách hàng đã bị trùng ","Thông báo");
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != string.Empty && txtSDT.Text != string.Empty && txtDiaChi.Text != string.Empty)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn lưu thông tin nhân viên " + txtHoTen.Text + " vào chưa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //string query = "set DATEFORMAT DMY update KHACHHANG set TENKH = N'" + txtHoTen.Text.Trim() + "', DIACHI = N'" + txtDiaChi.Text.Trim() + "',SDT = '" + txtSDT.Text.Trim() + "',NgaySinh = '" + DateTime.Parse(txtNgaySinh.Text).ToString("dd/MM/yyyy") + "',EMAIL = '" + txtEmail.Text.Trim() + "' where MAKH = '" + txtMaKH.Text.Trim() + "'";
                    //kn.thuchien(query);
                    KhachHang kh = new KhachHang(txtMaKH.Text.Trim(), txtHoTen.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim(), DateTime.Parse(txtNgaySinh.Text).ToString("dd/MM/yyyy"), txtEmail.Text.Trim());
                    khachHangBLL.saveKH(kh);

                    
                    MessageBox.Show("Đã sửa thông tin khách hàng " + txtHoTen.Text.Trim() + " thành công", "Thông báo");
                    loadKH();
                    reSet();
                }
            }
            else
                MessageBox.Show("Không được bỏ trống hị tên khách hàng, địa chỉ, số điện thoại", "Thông báo");
        }

    }
}
