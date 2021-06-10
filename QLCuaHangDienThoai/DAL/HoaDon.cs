using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDienThoai.BLL
{
    public class HoaDon
    {
        ketnoi kn = new ketnoi();

        string maHD;

public string MaHD1
{
  get { return maHD; }
  set { maHD = value; }
}
string maNV;

public string MaNV
{
    get { return maNV; }
    set { maNV = value; }
}
string maKh;

public string MaKh
{
    get { return maKh; }
    set { maKh = value; }
}
string ngayLapHD;

public string NgayLapHD
{
    get { return ngayLapHD; }
    set { ngayLapHD = value; }
}
string phuongThucThanhToan;

public string PhuongThucThanhToan
{
    get { return phuongThucThanhToan; }
    set { phuongThucThanhToan = value; }
}





        public HoaDon(string maHD, string maNV, string maKh, string ngayLapHD, string phuongThucThanhToan)
        {
            this.maHD = maHD;
            this.maNV = maNV;
            this.maKh = maKh;
            this.ngayLapHD = ngayLapHD;
            this.phuongThucThanhToan = phuongThucThanhToan;
        }

        public HoaDon()
        { }

        public DataTable loadCbbTenKH()
        {
            DataTable table = new DataTable();
            string query = "select * from khachhang";
            table = kn.getTable(query);
            return table;
        }

        public void themHD(HoaDon hd)
        {
            string queryHD = "SET DATEFORMAT DMY INSERT INTO HOADON VALUES ('" + hd.maHD + "', '" + hd.maNV + "', '" + hd.maKh + "', "+hd.NgayLapHD+", N'"+hd.phuongThucThanhToan+"')";
            kn.thuchien(queryHD);
        }

        public string getMaHDKhongTrung()
        {
            Random rd = new Random();
            string mahd = "HD0" + rd.Next(0, 500);
            string query = "select count(*) from HOADON where MAHD='" + mahd + "'";
            int kq = kn.getCount(query);
            while (kq > 0)
            {
                mahd = "HD0" + rd.Next(0, 500);
                query = "select count(*) from HOADON where MAHD='" + mahd + "'";
                kq = kn.getCount(query);
            }
            return mahd;
        }

        public DataTable loadDonHang()
        {
            string query = "select HOADON.MAHD,nhanvien.HOTEN,KHACHHANG.TENKH,NGAYLAPHD,TENSP,chitiet_hd.SOLUONG, DONGIA, chitiet_hd.SOLUONG* DONGIA as N'thanhTien'  from hoadon, CHITIET_HD, NHANVIEN, KHACHHANG, SANPHAM where HOADON.MAHd = CHITIET_HD.MAHD and HOADON.MANV = NHANVIEN.MANV and HOADON.MAKH = KHACHHANG.MAKH and CHITIET_HD.MASP = SANPHAM.MASP";
            return kn.getTable(query);
        }

        public DataTable timHoaDon(string maHD)
        {
            string query = "select HOADON.MAHD,nhanvien.HOTEN,KHACHHANG.TENKH,NGAYLAPHD,TENSP,chitiet_hd.SOLUONG, DONGIA, chitiet_hd.SOLUONG* DONGIA as N'thanhTien'  from hoadon, CHITIET_HD, NHANVIEN, KHACHHANG, SANPHAM where HOADON.MAHd = CHITIET_HD.MAHD and HOADON.MANV = NHANVIEN.MANV and HOADON.MAKH = KHACHHANG.MAKH and CHITIET_HD.MASP = SANPHAM.MASP and hoadon.mahd='"+maHD+"'";
            return kn.getTable(query);
        }


    }
}
