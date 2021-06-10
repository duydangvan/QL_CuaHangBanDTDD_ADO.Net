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
    public partial class frmXemCTSP : Form
    {
        ketnoi kn = new ketnoi();
        public frmXemCTSP()
        {
            InitializeComponent();
            layDL = new nhanDL(ganDL);
        }

        public delegate void nhanDL(string maSp);

        public nhanDL layDL;

        void ganDL(string pMaSP)
        {
            lbMaSP.Text = pMaSP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        void loadChiTietSP()
        {
            string query = "select * from SANPHAM, CHITIET_SP where SANPHAM.MASP=CHITIET_SP.MASP and SANPHAM.masp='" + lbMaSP.Text + "'";
            DataTable table = new DataTable();
            table = kn.getTable(query);
            lbTenSP.Text = table.Rows[0][1].ToString();
            lbDonGia.Text = table.Rows[0][3].ToString();
            lbXuatXu.Text = table.Rows[0][5].ToString();
            lbThoiGianBaoHanh.Text = table.Rows[0][6].ToString();
            lbChieuDai.Text = table.Rows[0][9].ToString();
            lbChieuRong.Text = table.Rows[0][10].ToString();
            lbDoDay.Text = table.Rows[0][11].ToString();
            lbTrongLuong.Text = table.Rows[0][12].ToString();
            lbManHinh.Text = table.Rows[0][13].ToString();
            lbRam.Text = table.Rows[0][14].ToString();
            lbBoNhoTrong.Text = table.Rows[0][15].ToString();
            lbHeDieuHanh.Text = table.Rows[0][16].ToString();
            lbMoTa.Text = table.Rows[0][17].ToString();
            string queryTenHSX = "select TENHANGSX from SANPHAM, HANGSX where SANPHAM.MAHANGSX = HANGSX.MAHANGSX and SANPHAM.masp = '"+lbMaSP.Text+"'";
            lbTenHangSX.Text = kn.layDLDangChuoi(queryTenHSX);
        }

        private void frmXemCTSP_Load(object sender, EventArgs e)
        {
            loadChiTietSP();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
