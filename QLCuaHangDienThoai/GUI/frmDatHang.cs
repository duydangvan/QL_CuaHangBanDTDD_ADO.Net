using QLCuaHangDienThoai.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDienThoai
{
    public partial class frmDatHang : Form
    {
        static SanPhamBLL sp = new SanPhamBLL();
        HangSX_BLL hang = new HangSX_BLL();
        NhanVienBLL nhanvien = new NhanVienBLL();
        HoaDonBLL hd = new HoaDonBLL();

        public frmDatHang()
        {
            InitializeComponent();
            layDL = new nhanTenNV(ganDL);
        }
        //nhận tên nhân viên từ form Home
        public delegate void nhanTenNV(string MaNV);

        public nhanTenNV layDL;

        void ganDL(string MaNV)
        {
            lbMaNV.Text = MaNV;
        }

        DataTable ViewHoaDon = new DataTable();
        DataTable tableSanPham = new DataTable();
         DataTable tblTam = sp.tableSanPham();
        
        public DataTable tblSanPham()
        {
            // string query = "select SANPHAM.MASP,SANPHAM.TENSP, CHITIET_SP.RAM, SANPHAM.DONGIA,BONHOTRONG,SOLUONG from SANPHAM, CHITIET_SP where SANPHAM.MASP=CHITIET_SP.MASP";
            // tableSanPham = kn.getTable(query);
            tableSanPham = sp.tableSanPham();

            return tableSanPham;
            
        }

        private void loadHangSX()
        {
            //SqlConnection con = new SqlConnection(kn.connectionSTR);
            //string query = "select TENHANGSX from HANGSX";
            //List<string> ds = new List<string>();
            //ds.Add("Chọn tất cả");
            //kn.moKetNoi(con);
            //SqlCommand cmd = new SqlCommand(query, con);
            //SqlDataReader rd = cmd.ExecuteReader();
            //while (rd.Read())
            //{
            //    ds.Add(rd[0].ToString());
            //}
            //kn.dongKetNoi(con);
            cbbHangDienThoai.DataSource = hang.dsHangSX();
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            btnThemDH.Hide();
            btnXoaDH.Hide();
            loadDT();
            loadHangSX();
            taoViewHoaDon();
            layTenNV();
            lbMaHD.Text = layMaHDTuDongKhongTrung();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtgvHoaDon.Rows.Count > 0)
            {
                frmHoaDon hoaDon = new frmHoaDon();
                hoaDon.laydl(ViewHoaDon, lbMaHD.Text, int.Parse(txtTongTien.Text), lbMaNV.Text);
                hoaDon.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Chưa có sản phẩm nào trong hóa đơn luôn á", "Thông báo");
            
        }

        private void taoViewHoaDon()
        {
            ViewHoaDon.Columns.Add("MaSP");
            ViewHoaDon.Columns.Add("TenSP");
            ViewHoaDon.Columns.Add("SoLuong");
            ViewHoaDon.Columns.Add("DonGia");
            ViewHoaDon.Columns.Add("ThanhTien");
        }

        private void btnThemDH_Click(object sender, EventArgs e)
        {
            if (txtsl.Text != string.Empty)
            {
                int soLuong, SLConLai = 0;
                string tenSp = dtgvSanPham.CurrentRow.Cells[1].Value.ToString();
                int soLuongSPTrongKho = 0;
                soLuong = int.Parse(txtsl.Text);
                soLuongSPTrongKho = int.Parse(dtgvSanPham.CurrentRow.Cells[5].Value.ToString());
                if (soLuongSPTrongKho >= soLuong)
                {
                    if (soLuongSPTrongKho > 0)
                    {
                        if (soLuong.ToString() != string.Empty)
                        {
                            if (soLuong != 0)
                            {
                                if (soLuong > 0)
                                {
                                    int thanhTien = 0, tongTien = 0;
                                    string maSP = dtgvSanPham.CurrentRow.Cells[0].Value.ToString();
                                    string boNhoTrong = dtgvSanPham.CurrentRow.Cells[4].Value.ToString();
                                    string ram = dtgvSanPham.CurrentRow.Cells[2].Value.ToString();
                                    int gia = int.Parse(dtgvSanPham.CurrentRow.Cells[3].Value.ToString());
                                    thanhTien = soLuong * gia;
                                    SLConLai = soLuongSPTrongKho - soLuong;
                                    dtgvSanPham.CurrentRow.Cells[5].Value = SLConLai;

                                    //string query = "update SANPHAM set SOLUONG = '" + SLConLai.ToString() + "' where TENSP = '" + tenSp + "'";
                                    //kn.thuchien(query);
                                    //sp.updateSP(SLConLai, tenSp);

                                    //loadDT();

                                    if (tenSp != string.Empty)
                                    {
                                        DataRow row = ViewHoaDon.NewRow();
                                        row["MaSP"] = maSP;
                                        row["TenSP"] = tenSp;
                                        row["SoLuong"] = soLuong;
                                        row["DonGia"] = gia;
                                        row["ThanhTien"] = thanhTien;
                                        ViewHoaDon.Rows.Add(row);
                                        dtgvHoaDon.DataSource = ViewHoaDon;


                                        //cập nhật số lương khi thêm mã sản phẩm trùng nhưng bị lỗi
                                        if (ViewHoaDon.Rows.Count > 1)
                                        {
                                            for (int m = 0; m < ViewHoaDon.Rows.Count; m++)
                                            {
                                                DataRow row1 = ViewHoaDon.Rows[m];
                                                string tensp1 = row1[1].ToString().Trim();
                                                int dongia1 = int.Parse(row1[3].ToString());
                                                int soLuong1 = int.Parse(row1[2].ToString());
                                                for (int n = m + 1; n < ViewHoaDon.Rows.Count; n++)
                                                {
                                                    DataRow row2 = ViewHoaDon.Rows[n];
                                                    string tensp2 = row2[1].ToString().Trim();
                                                    int dongia2 = int.Parse(row2[3].ToString());
                                                    int soLuong2 = int.Parse(row2[2].ToString());
                                                    if (tensp1 == tensp2 && dongia1 == dongia2)
                                                    {
                                                        soLuong1 += soLuong2;
                                                        row1["SoLuong"] = soLuong1;
                                                        row1["ThanhTien"] = soLuong1*dongia1;
                                                        ViewHoaDon.Rows[n].Delete();
                                                        ViewHoaDon.AcceptChanges();
                                                    }
                                                }
                                            }
                                        }

                                        //trùng là không cho nhập nhưng lỗi
                                        //if (ViewHoaDon.Rows.Count >= 1)
                                        //{
                                        //    for (int m = 0; m < ViewHoaDon.Rows.Count; m++)
                                        //    {
                                        //        DataRow row1 = ViewHoaDon.Rows[m];
                                        //        string tensp2 = row1[0].ToString();
                                        //        if (tenSp == tensp2)
                                        //        {
                                        //            MessageBox.Show("Sản phẩm đã tồn tại trong hóa đơn", "Thông báo");
                                        //        }
                                        //    }
                                        //}

                                        for (int i = 0; i < ViewHoaDon.Rows.Count; i++)
                                        {
                                            tongTien += int.Parse(ViewHoaDon.Rows[i][4].ToString());
                                        }
                                        txtTongTien.Text = tongTien.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bạn chưa chọn sản phẩm cần mua");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Số lượng không được để âm bạn nhé", "Thông báo");
                                }
                            }
                            else
                                MessageBox.Show("Số lượng bạn cần mua là 0 \n  \t ????", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Số lượng không được để trống bạn nhé", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sản Phẩm " + tenSp + " đã hết hàng trong kho", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng trong kho chỉ còn "+soLuongSPTrongKho+"","Thông báo");
                }
            }
            else
                MessageBox.Show("Số lượng sản phẩm hiện đang trống đó nha", "Thông báo");
        }


        private void btnTaoHoaDonMoi_Click(object sender, EventArgs e)
        {
            
                btnThemDH.Visible = true;
                btnXoaDH.Visible = true;
                btnThanhToan.Enabled = true;
            
        }

        private void loadDT()
        {
            dtgvSanPham.DataSource = sp.tableSanPham();
        }


        private void dtgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoaDH_Click(object sender, EventArgs e)
        {
            if (ViewHoaDon.Rows.Count>0)
            {
                int soLuongXoa = int.Parse(txtsl.Text);
                string tensp2 = dtgvHoaDon.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show("Bạn muốn đưa sản phẩm " + tensp2 +" với số lượng "+soLuongXoa+" ra khỏi đơn hàng", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int soLuong2 = int.Parse(dtgvHoaDon.CurrentRow.Cells[2].Value.ToString());
                    if (soLuong2 >= soLuongXoa)
                    {
                        string masp = dtgvHoaDon.CurrentRow.Cells[0].Value.ToString().Trim();
                        int dongia2 = int.Parse(dtgvHoaDon.CurrentRow.Cells[3].Value.ToString());
                        int tongTienViewHoaDon = 0;
                        int vt = dtgvHoaDon.CurrentRow.Index;
                        int tongDong = tblSanPham().Rows.Count;
                        for (int y = 0; y < tongDong; y++)
                        {
                            DataRow row = tableSanPham.Rows[y];
                            int dongia1 = 0;
                            int soLuong1 = int.Parse(row[5].ToString());
                            dongia1 = int.Parse(row[3].ToString());
                            string tensp1 = row[1].ToString();
                            if (tensp2 == tensp1 && dongia1 == dongia2)
                            {
                                soLuong2 -= soLuongXoa;
                                dtgvHoaDon.CurrentRow.Cells[2].Value = soLuong2;

                                dtgvHoaDon.CurrentRow.Cells[4].Value = soLuong2 * dongia2;
                                for (int i = 0; i < dtgvSanPham.Rows.Count; i++)
                                {
                                    int soLuongSPTrongKho = int.Parse(dtgvSanPham.Rows[i].Cells[5].Value.ToString().Trim());
                                    if (masp == dtgvSanPham.Rows[i].Cells[0].Value.ToString().Trim())
                                    {
                                        soLuongSPTrongKho += soLuongXoa;
                                        dtgvSanPham.Rows[i].Cells[5].Value = soLuongSPTrongKho;
                                    }
                                }


                                //string query = "Update SANPHAM set SOLUONG = '" + soluongCuoiCung + "' where TENSP = '" + tensp2 + "' and DONGIA = '" + dongia2 + "'";
                                //kn.thuchien(query);
                                //sp.updateSPDonGia(soluongCuoiCung,tensp2,dongia2);
                                if (int.Parse(dtgvHoaDon.CurrentRow.Cells[2].Value.ToString().Trim()) <= 0)
                                {
                                    ViewHoaDon.Rows[vt].Delete();
                                    ViewHoaDon.AcceptChanges();
                                }
                            }

                        }

                        int soDongViewHoaDon = dtgvHoaDon.Rows.Count;
                        int tongtien = 0;
                        for (int i = 0; i < soDongViewHoaDon; i++)
                        {
                            tongtien += int.Parse(ViewHoaDon.Rows[i][4].ToString());
                        }
                        txtTongTien.Text = tongtien.ToString();
                    }
                    else
                        MessageBox.Show("Ăn gian sản phẩm hả","Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Hóa đơn hiện chưa có sản phẩm nào","Thông báo");
            }
        }

        void layTenNV()
        {

            //string query = "select hoten from NHANVIEN where manv = N'"+lbMaNV.Text+"'";
            //lbTenNV.Text = kn.layDLDangChuoi(query);

            lbTenNV.Text = nhanvien.getNameNV(lbMaNV.Text.Trim());
        }

        string layMaHDTuDongKhongTrung()
        {
            //Random rd = new Random();
            //string mahd = "HD0"+rd.Next(0,500);

            //string query = "select count(*) from HOADON where MAHD='" + mahd + "'";
            //int kq = kn.getCount(query);
            //int kq;
            //while(kq>0)
            //{
            //    mahd = "HD0" + rd.Next(0,500);
            //    query = "select count(*) from HOADON where MAHD='" + mahd + "'";
            //    kq = kn.getCount(query);
            //}
            //return mahd;  

            return hd.getMaHDKhongtrung();
        }

        private void cbbHangDienThoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbHangDienThoai.SelectedIndex==0)
            {
                loadDT();
            }
            else
            dtgvSanPham.DataSource = sp.LoadSPWithNameHSX(cbbHangDienThoai.SelectedItem.ToString().Trim());
        }
    }
}
