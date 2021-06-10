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
    public partial class frmQLDienThoai : Form
    {
        Xuly xl = new Xuly();
        public frmQLDienThoai()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSanPham themSanPham = new frmThemSanPham();
            themSanPham.btnThemSP.Visible = true;
            themSanPham.btnSave.Visible = false;
            themSanPham.btnSuaSP.Visible = false;
            themSanPham.ShowDialog();
            dtgvSanPham.DataSource = xl.loadDT();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmThemSanPham themSanPham = new frmThemSanPham();
            themSanPham.btnThemSP.Visible = false;
            themSanPham.btnSave.Visible = false;
            themSanPham.btnSuaSP.Visible = true;
            themSanPham.lbMaSP.Text = string.Empty;
            themSanPham.btnLoadMa.Visible = false;
            themSanPham.txtBoNhoTrong.Enabled=false;
            themSanPham.txtChieuDai.Enabled = false;
            themSanPham.txtChieuRong.Enabled = false;
            themSanPham.txtDoDay.Enabled = false;
            themSanPham.txtDonGia.Enabled = false;
            themSanPham.txtHeDieuHanh.Enabled = false;
            themSanPham.txtManHinh.Enabled = false;
            themSanPham.txtMoTa.Enabled = false;
            themSanPham.txtRam.Enabled = false;
            themSanPham.txtSoLuong.Enabled = false;
            themSanPham.txtTenSP.Enabled = false;
            themSanPham.txtThoiGianBaoHanh.Enabled = false;
            themSanPham.txtTrongLuong.Enabled = false;
            themSanPham.txtXuatXu.Enabled = false;
            themSanPham.ShowDialog();
            dtgvSanPham.DataSource = xl.loadDT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDienThoai_Load(object sender, EventArgs e)
        {
            dtgvSanPham.DataSource = xl.loadDT();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemCTSP_Click(object sender, EventArgs e)
        {
            if (dtgvSanPham.Rows.Count > 0)
            {
                frmXemCTSP themCTSP = new frmXemCTSP();
                string maSP = dtgvSanPham.CurrentRow.Cells[0].Value.ToString();
                themCTSP.layDL(maSP);
                themCTSP.ShowDialog();
            }
            else
                MessageBox.Show("Chưa có sản phẩm nào trong bảng","Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
