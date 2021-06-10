using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDienThoai.BLL
{
    public class HoaDonBLL
    {
        public HoaDonBLL()
        { }

        HoaDon hd = new HoaDon();
        public DataTable loadCbbKH()
        {
            return hd.loadCbbTenKH();
        }

        public void themHD(HoaDon hoadon)
        {
            hd.themHD(hoadon);
        }

        public string getMaHDKhongtrung()
        {
            return hd.getMaHDKhongTrung();
        }

        public DataTable loadHoaDon()
        {
            return hd.loadDonHang();
        }

        public DataTable searchHD(string pMaHD)
        {
            return hd.timHoaDon(pMaHD);
        }
    }
}
