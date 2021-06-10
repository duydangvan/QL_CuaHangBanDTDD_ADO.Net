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
    public partial class frmThemSanPham : Form
    {
        ketnoi kn = new ketnoi();
        Xuly xl = new Xuly();
        public frmThemSanPham()
        {
            InitializeComponent();
        }


        private void btnThemCTSP_Click(object sender, EventArgs e)
        {
        }
        private void frmThemSanPham_Load(object sender, EventArgs e)
        {
            loadSanPham();
            loadCbbHangSX();
        }

        void loadSanPham()
        {
            dtgvThemSP.DataSource = xl.loadDT();
        }
        void loadCbbHangSX()
        {
            string query = "select * from HANGSX";
            DataTable table = new DataTable();
            table = kn.getTable(query);
            cbbMaSX.DataSource = table;
            cbbMaSX.DisplayMember = "TENHANGSX";
            cbbMaSX.ValueMember = "MAHANGSX";
        }

       string loadMaSPKhongTrung()
        {
            Random rd = new Random();
            string maSP = "SP"+rd.Next(0,500);
            string query = "select count(*) from sanpham where masp='"+maSP+"'";
            int kq = kn.getCount(query);
            while(kq>0)
            {
                maSP = "SP" + rd.Next(0,500);
                query = "select count(*) from sanpham where masp='" + maSP + "'";
                kq = kn.getCount(query);
            }
            return maSP;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (lbMaSP.Text != string.Empty)
            {
                if (!kiemTraRong())
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm sản phẩm " + txtTenSP.Text + " vào chưa ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string query = "INSERT INTO SANPHAM VALUES ('" + lbMaSP.Text + "', '" + txtTenSP.Text + "', '" + cbbMaSX.SelectedValue + "', '" + txtDonGia.Text + "', '" + txtSoLuong.Text + "', N'" + txtXuatXu.Text + "', '" + txtThoiGianBaoHanh.Text + "')";
                        string queryChiTiet = "INSERT INTO CHITIET_SP VALUES ('" + lbMaSP.Text + "', '" + cbbMaSX.SelectedValue + "', '" + txtChieuDai.Text + "', '" + txtChieuRong.Text + "', '" + txtDoDay.Text + "', '" + txtTrongLuong.Text + "', '" + txtManHinh.Text + "', '" + txtRam.Text + "', '" + txtBoNhoTrong.Text + "', N'" + txtHeDieuHanh.Text + "', N'" + txtMoTa.Text + "')";
                        kn.thuchien(query);
                        kn.thuchien(queryChiTiet);
                        MessageBox.Show("Đã thêm sản phẩm " + txtTenSP.Text + " thành công", "Thông báo");
                        loadSanPham();
                        reset();
                    }
                }
                else
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin của sản phẩm", "Thông báo");
            }
            else
                MessageBox.Show("Chưa có mã sản phẩm", "Thông báo");
        }

        private void txtChieuRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        Boolean kiemTraRong()
        {
            if (txtBoNhoTrong.Text == string.Empty && txtChieuDai.Text == string.Empty && txtChieuRong.Text == string.Empty && txtDoDay.Text == string.Empty && txtDonGia.Text == string.Empty && txtHeDieuHanh.Text == string.Empty && txtManHinh.Text == string.Empty && txtMoTa.Text == string.Empty && txtRam.Text == string.Empty && txtSoLuong.Text == string.Empty && txtTenSP.Text == string.Empty && txtThoiGianBaoHanh.Text == string.Empty && txtTrongLuong.Text == string.Empty && txtXuatXu.Text == string.Empty)
                return true;
            else
                return false;
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnSuaSP.Visible = false;
            txtBoNhoTrong.Enabled = true;
            txtChieuDai.Enabled = true;
            txtChieuRong.Enabled = true;
            txtDoDay.Enabled = true;
            txtDonGia.Enabled = true;
            txtHeDieuHanh.Enabled = true;
            txtManHinh.Enabled = true;
            txtMoTa.Enabled = true;
           txtRam.Enabled = true;
            txtSoLuong.Enabled = true;
            txtTenSP.Enabled = true;
            txtThoiGianBaoHanh.Enabled = true;
            txtTrongLuong.Enabled = true;
            txtXuatXu.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!kiemTraRong())
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn lưu sản sản phẩm " + txtTenSP.Text + " vào chưa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string querySanPham = "update SANPHAM set TENSP = N'" + txtTenSP.Text + "', MAHANGSX = '" + cbbMaSX.SelectedValue.ToString().Trim() + "',DONGIA = '" + txtDonGia.Text + "',SOLUONG = '" + txtSoLuong.Text + "',XUATXU = N'" + txtXuatXu.Text + "',THOIGIAN_BH = '" + txtThoiGianBaoHanh.Text + "' where MASP = '" + lbMaSP.Text + "'";
                    string queryChiTiet = "update CHITIET_SP set MAHANGSX = '" + cbbMaSX.SelectedValue.ToString().Trim() + "', CHIEUDAI = '" + txtChieuDai.Text + "', CHIEURONG = '" + txtChieuRong.Text + "', DODAY = '" + txtDoDay.Text + "', TRONGLUONG = '" + txtTrongLuong.Text + "', MANHINH = '" + txtManHinh.Text + "', RAM = '" + txtRam.Text + "', BONHOTRONG = '" + txtBoNhoTrong.Text + "', HEDIEUHANH = N'" + txtHeDieuHanh.Text + "',MOTA = N'" + txtMoTa.Text + "' where masp = '" + lbMaSP.Text + "'";
                    kn.thuchien(querySanPham);
                    kn.thuchien(queryChiTiet);
                    MessageBox.Show("Đã sửa thông tin sản phẩm " + txtTenSP.Text + " thành công", "Thông báo");
                    loadSanPham();
                    reset();
                }
            }
            else
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin sản phẩm","Thông báo");
        }

        private void dtgvThemSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbMaSP.Text = dtgvThemSP.CurrentRow.Cells[0].Value.ToString().Trim();
            string query = "select* from SANPHAM, CHITIET_SP where SANPHAM.MASP = CHITIET_SP.MASP and SANPHAM.MASP = '"+lbMaSP.Text+"'";
            DataTable table = new DataTable();
            table = kn.getTable(query);
            txtBoNhoTrong.Text=table.Rows[0][15].ToString();
            txtChieuDai.Text = table.Rows[0][9].ToString();
            txtChieuRong.Text = table.Rows[0][10].ToString();
            txtDoDay.Text = table.Rows[0][11].ToString();
            txtDonGia.Text = table.Rows[0][3].ToString();
            txtHeDieuHanh.Text = table.Rows[0][16].ToString();
            txtManHinh.Text = table.Rows[0][13].ToString();
            txtMoTa.Text = table.Rows[0][17].ToString();
            txtRam.Text = table.Rows[0][14].ToString();
            txtSoLuong.Text = table.Rows[0][4].ToString();
            txtTenSP.Text = table.Rows[0][1].ToString();
            txtThoiGianBaoHanh.Text = table.Rows[0][6].ToString();
            txtTrongLuong.Text = table.Rows[0][12].ToString();
            txtXuatXu.Text = table.Rows[0][5].ToString();
            cbbMaSX.SelectedValue= table.Rows[0][2].ToString();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        void reset()
        {
            txtBoNhoTrong.Text = string.Empty;
            txtChieuDai.Text = string.Empty;
            txtChieuRong.Text = string.Empty;
            txtDoDay.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtHeDieuHanh.Text = string.Empty;
            txtManHinh.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtRam.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtThoiGianBaoHanh.Text = string.Empty;
            txtTrongLuong.Text = string.Empty;
            txtXuatXu.Text = string.Empty;
            lbMaSP.Text = string.Empty;
        }

        private void btnLoadMa_Click(object sender, EventArgs e)
        {
            lbMaSP.Text = loadMaSPKhongTrung();
        }
    }
}
