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
    public partial class frmHoaDon : Form
    {
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        KhachHangBLL KhachHangBLL = new KhachHangBLL();
        SanPhamBLL sp = new SanPhamBLL();
        public frmHoaDon()
        {
            InitializeComponent();
            laydl = new nhanDL(ganDL);
        }

        ketnoi kn = new ketnoi();

        public delegate void nhanDL(DataTable table,string maHD,int tongTien,string maNV);

        public nhanDL laydl;

        DataTable tableHoaDon = new DataTable();
        List<string> dSTenSP = new List<string>();
        List<int> dSSoLuongSP = new List<int>();
        List<string> dsMaSP = new List<string>();

        void ganDL(DataTable table,string pMaHD,int pTongTien,string pMaNV)
        {
            tableHoaDon = table;
            lbMaHD.Text = pMaHD;
            txtTongTien.Text = pTongTien.ToString();
            lbMaNV.Text = pMaNV;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadChiTiet()
        {
            string tenSP = string.Empty;
            string maSP = string.Empty;
            lbTenSP.Text = string.Empty;
            lbSoLuong.Text = string.Empty;
            int SL = 0;
            for (int i=0;i<tableHoaDon.Rows.Count;i++)
            {
                maSP = tableHoaDon.Rows[i][0].ToString();
                tenSP = tableHoaDon.Rows[i][1].ToString();
                SL = int.Parse(tableHoaDon.Rows[i][2].ToString());
                dsMaSP.Add(maSP);
                dSTenSP.Add(tenSP);
                dSSoLuongSP.Add(SL);
                
            }

            for(int i=0;i<dSTenSP.Count;i++)
            {
                lbTenSP.Text += dSTenSP[i].ToString()+" \n";
                lbSoLuong.Text += dSSoLuongSP[i].ToString() + "\n";
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadChiTiet();
            loadCbbTenKH();
        }

        void loadCbbTenKH()
        {
            cbbKhachHang.DataSource = hoaDonBLL.loadCbbKH();
            cbbKhachHang.DisplayMember = "tenkh";
            cbbKhachHang.ValueMember = "tenkh";
        }


        private void cbbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMaKH.Text = KhachHangBLL.loadMaKH(cbbKhachHang.SelectedValue.ToString());
        }

        private void txtTienKhachTra_TextChanged(object sender, EventArgs e)
        {
            txtTienTraLai.Text = (int.Parse(txtTienKhachTra.Text) - int.Parse(txtTongTien.Text)).ToString();
        }

        private void txtTienKhachTra_Click(object sender, EventArgs e)
        {
            if (txtTienKhachTra.Text == "Nhập tiền khách trả")
            {
                txtTienKhachTra.Text = string.Empty;

            }
        }

        private void txtTienKhachTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        void updateSP()
        {
            for(int i=0;i<tableHoaDon.Rows.Count;i++)
            {
                string masp = tableHoaDon.Rows[i][0].ToString().Trim();
                int soLuongMua = int.Parse(tableHoaDon.Rows[i][2].ToString().Trim());
                int soLuongSPDuoiKho = sp.soLuongSPDuoiKho(masp);
                int soLuongCuoiCung = soLuongSPDuoiKho - soLuongMua;
                sp.updateSP(soLuongCuoiCung, masp);
            }
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            if (txtTienKhachTra.Text != "Nhập tiền khách trả" && txtTienKhachTra.Text != string.Empty)
            {
                if (int.Parse(txtTienKhachTra.Text) > int.Parse(txtTongTien.Text))
                {
                    if (lbMaKH.Text != string.Empty)
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn thanh toán hóa đơn này chưa ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            HoaDon hd = new HoaDon(lbMaHD.Text, lbMaNV.Text, lbMaKH.Text, "getdate()", "");
                            //string queryHD = "SET DATEFORMAT DMY INSERT INTO HOADON VALUES ('" + lbMaHD.Text + "', '" + lbMaNV.Text + "', '" + lbMaKH.Text + "', getdate(), N'')";
                            //kn.thuchien(queryHD);
                            hoaDonBLL.themHD(hd);
                            for (int i = 0; i < dsMaSP.Count; i++)
                            {
                                string queryChiTietHD = "INSERT INTO CHITIET_HD VALUES ('" + lbMaHD.Text + "', '" + dsMaSP[i].ToString() + "', '" + dSSoLuongSP[i].ToString() + "', '')";
                                kn.thuchien(queryChiTietHD);
                            }

                            updateSP();

                            MessageBox.Show("Đã thanh toán xong", "Thông báo");
                            this.Close();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Bạn chưa chọn tên khách hàng cần thanh toán", "Thông báo");
                        txtTienKhachTra.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Số tiền của quý khách chưa đủ để thanh toán hóa đơn", "Thông báo");
                    txtTienKhachTra.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tiền khách trả", "Thông báo");
                txtTienKhachTra.Focus();
            }
        }

    }
}
