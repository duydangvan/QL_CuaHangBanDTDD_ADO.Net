using QLCuaHangDienThoai.BLL;
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
    public partial class frmNhanVien : Form
    {
        ketnoi kn = new ketnoi();
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        public frmNhanVien()
        {
            InitializeComponent();
            loadNV();
            ChucVu();
        }


        public void ChucVu()
        {
            List<string> ds = new List<string>();
            ds.Add("Chủ");
            ds.Add("Nhân Viên");
            cbbChucVu.DataSource = ds;
        }

       

        void reSet()
        {
            txtMaNV.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtCMND.Text = string.Empty;
            txtNgaySinh.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbbChucVu.SelectedItem = string.Empty;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string queryTrung = "select count(*) from nhanvien where manv = '" + txtMaNV.Text + "'";
            if (!kn.KiemTraTrung(queryTrung))
            {
                if (!kiemTraRong())
                {
                    if (kiemTraEmailHopLe())
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên " + txtHoTen.Text + " vào chưa ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            //string query = "SET DATEFORMAT DMY INSERT INTO NHANVIEN VALUES ('" + txtMaNV.Text + "', N'" + txtHoTen.Text + "', N'" + txtDiaChi.Text + "', '" + txtCMND.Text + "', '" + DateTime.Parse(txtNgaySinh.Text).ToString("dd/MM/yyyy") + "', '" + txtSDT.Text + "', '" + txtEmail.Text + "', N'" + cbbChucVu.SelectedItem + "')";
                            //kn.thuchien(query);
                            NhanVien nv = new NhanVien(txtMaNV.Text.Trim(), txtHoTen.Text.Trim(), txtDiaChi.Text.Trim(), txtCMND.Text.Trim(), DateTime.Parse(txtNgaySinh.Text).ToString("dd/MM/yyyy"), txtSDT.Text.Trim(), txtEmail.Text.Trim(), cbbChucVu.SelectedItem.ToString().Trim());
                            nhanVienBLL.addNV(nv);

                            loadNV();
                            MessageBox.Show("Đã thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                            reSet();
                            taoMaNVKhongTrung();
                        }
                    }
                    else
                        MessageBox.Show("Email không hợp lệ, Vui lòng nhập lại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin nhân viên","Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Mã nhân viên đã bị trùng","Thông báo");
            }
        }

        void loadNV()
        {
            dtgvNhanVien.DataSource = nhanVienBLL.loadNV() ;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            btnLuuNV.Visible = true;
        }

        void taoMaNVKhongTrung()
        {
            //string manv = tuDongTaoMaNV();
            //string query = "select count(*) from nhanvien where manv='" + manv + "'";
            //while (kn.KiemTraTrung(query))
            //{
            //    manv = tuDongTaoMaNV();
            //    query = "select count(*) from nhanvien where manv='" + manv + "'";
            //}
            //txtMaNV.Text = manv;
            txtMaNV.Text = nhanVienBLL.tuDongTaoMaNVKhongTrung();

        }


        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            taoMaNVKhongTrung();
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dtgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dtgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dtgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtCMND.Text = dtgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtNgaySinh.Text = dtgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dtgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dtgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            cbbChucVu.SelectedItem = dtgvNhanVien.CurrentRow.Cells[7].Value.ToString().Trim();
        }

        Boolean kiemTraRong()
        {
            if(txtCMND.Text==string.Empty || txtDiaChi.Text==string.Empty || txtEmail.Text==string.Empty || txtHoTen.Text==string.Empty || txtSDT.Text == string.Empty)
            {
                return true;
            }
            return false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reSet();
            taoMaNVKhongTrung();
            loadNV();
        }

        public Boolean kiemTraEmailHopLe()
        {
            if (txtEmail.Text.Contains("@gmail.com"))
                return true;
            return false;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                if (kiemTraEmailHopLe())

                    if (MessageBox.Show("Bạn có chắc chắn muốn lưu thông tin nhân viên " + txtHoTen.Text + " vào chưa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //string query = "set DATEFORMAT DMY UPDATE NHANVIEN SET HOTEN = N'" + txtHoTen.Text.Trim() + "',DIACHI = N'" + txtDiaChi.Text.Trim() + "',SDT = '" + txtSDT.Text.Trim() + "',NGAYSINH = '" + DateTime.Parse(txtNgaySinh.Text).ToString("dd/MM/yyyy") + "',CMND = '" + txtCMND.Text.Trim() + "',EMAIL = '" + txtEmail.Text.Trim() + "',CHUCVU = N'" + cbbChucVu.SelectedItem + "' WHERE MANV = '" + txtMaNV.Text.Trim() + "'";
                        //kn.thuchien(query);
                        NhanVien nv = new NhanVien(txtMaNV.Text.Trim(), txtHoTen.Text.Trim(), txtDiaChi.Text.Trim(), txtCMND.Text.Trim(), DateTime.Parse(txtNgaySinh.Text).ToString("dd/MM/yyyy"), txtSDT.Text.Trim(), txtEmail.Text.Trim(), cbbChucVu.SelectedItem.ToString().Trim());
                        nhanVienBLL.saveNV(nv);

                        loadNV();
                        reSet();
                        taoMaNVKhongTrung();
                        MessageBox.Show("Đã sửa thông tin thành công", "Thông báo");
                        txtHoTen.Focus();
                    }
                
                else
                    MessageBox.Show("Email không hợp lệ, Vui lòng nhập lại", "Thông báo");
            }
            else
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin nhân viên", "Thông báo");
        }
    }
}
