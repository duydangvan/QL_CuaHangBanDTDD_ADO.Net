using QLCuaHangDienThoai.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDienThoai.BLL
{
    public class KhachHangBLL
    {
        KhachHang kh = new KhachHang();
        public KhachHangBLL() { }

        public string loadMaKH(string tenKH)
        {
            return kh.loadMaKH(tenKH);
        }

        public DataTable loadKH()
        {
            return kh.loadKH();
        }

        public int soLuongKhachHanhTrung(string maKH)
        {
            return kh.soLuongTrungMaKH(maKH);
        }

        public void addKhachHang(KhachHang khachhang)
        {
            kh.themKH(khachhang);
        }

        public void saveKH(KhachHang khachhang)
        {
            kh.saveKH(khachhang);
        }

        public string taoMaKHTuDongKhongTrung()
        {
            return kh.taoMaKHTuDong();
        }
    }
}
