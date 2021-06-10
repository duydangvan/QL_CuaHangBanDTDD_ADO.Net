using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDienThoai.BLL
{
    public class SanPham
    {
        ketnoi kn = new ketnoi();
        string maSP;
        string tenSP;
        string maHSX;
        int donGia;
        int soLuong;
        string xuatXu;
        int thoiGianBaoHanh;

        public SanPham ()
        { }

        public DataTable tblSanPham()
        {
            string query = "select SANPHAM.MASP,SANPHAM.TENSP, CHITIET_SP.RAM, SANPHAM.DONGIA,BONHOTRONG,SOLUONG from SANPHAM, CHITIET_SP where SANPHAM.MASP=CHITIET_SP.MASP";
            return kn.getTable(query);
        }

        public void updateSP(int soLuongConLai, string pMASP )
        {
            string query = "update SANPHAM set SOLUONG = '" + soLuongConLai.ToString() + "' where MASP = '" + pMASP + "'";
            kn.thuchien(query);
        }

        public void updateSPDonGia(int soluong,string tenSP,int donGia)
        {
            string query = "Update SANPHAM set SOLUONG = '" + soluong + "' where TENSP = '" + tenSP + "' and DONGIA = '" + donGia + "'";
            kn.thuchien(query);
        }

        public DataTable loadSanPhamTheoHSX(string tenHSX)
        {
            
            string query = "select SANPHAM.MASP,SANPHAM.TENSP, CHITIET_SP.RAM, SANPHAM.DONGIA,BONHOTRONG,SOLUONG from SANPHAM, CHITIET_SP,HANGSX where SANPHAM.MASP = CHITIET_SP.MASP and CHITIET_SP.MAHANGSX = HANGSX.MAHANGSX and TENHANGSX = N'"+tenHSX+"'";
            return kn.getTable(query);
        }

        public int soLuongSPDuoiKho(string pMaSP)
        {
            string query = "select SOLUONG from sanPham where masp='"+pMaSP+"'";
            return kn.getCount(query);
        }

       

    }
}
