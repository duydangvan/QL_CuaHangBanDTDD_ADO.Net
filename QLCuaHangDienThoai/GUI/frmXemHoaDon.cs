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

namespace QLCuaHangDienThoai.GUI
{
    public partial class frmXemHoaDon : Form
    {
        public frmXemHoaDon()
        {
            InitializeComponent();
        }

        HoaDonBLL hd = new HoaDonBLL();

        private void frmXemHoaDon_Load(object sender, EventArgs e)
        {
            loadHoaDon();
        }

        DataTable tableHD = new DataTable();

        public void loadtableHD()
        {
            tableHD= hd.loadHoaDon();
        }

        public void loadHoaDon()
        {
            dtgvHoaDon.DataSource = hd.loadHoaDon();
            DataTable table = hd.loadHoaDon();
            int tt = 0;
            for (int i = 0; i < table.Rows.Count; i++)
                tt += int.Parse(table.Rows[i][7].ToString());
            lbTongTien.Text = tt.ToString();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHD.Text == string.Empty)
            {
                int tt = 0;
                dtgvHoaDon.DataSource = hd.loadHoaDon();
                DataTable table = hd.loadHoaDon();
                for (int i = 0; i < table.Rows.Count; i++)
                    tt += int.Parse(table.Rows[i][7].ToString());
                lbTongTien.Text = tt.ToString();
            }
            else
            {
                dtgvHoaDon.DataSource = hd.searchHD(txtMaHD.Text);

                DataTable table = hd.searchHD(txtMaHD.Text);
                int tt =0;
                for (int i = 0; i < table.Rows.Count; i++)
                    tt +=int.Parse(table.Rows[i][7].ToString());
                lbTongTien.Text = tt.ToString();
            }
        }
    }
}
