using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDienThoai.BLL
{
    public class SanPhamBLL
    {
        SanPham sanPham = new SanPham();
        public DataTable tableSanPham()
        {
            return sanPham.tblSanPham();
        }

        public void updateSP(int soLuong, string pMASP)
        {
            sanPham.updateSP(soLuong,pMASP);
        }

        public void updateSPDonGia(int soLuong, string tenSP,int donGia)
        {
            sanPham.updateSPDonGia(soLuong,tenSP,donGia);
        }

        public DataTable LoadSPWithNameHSX(string tenHSX)
        {
           return sanPham.loadSanPhamTheoHSX(tenHSX);
        }

        public int soLuongSPDuoiKho(string pMaSP)
        {
            return sanPham.soLuongSPDuoiKho(pMaSP);
        }
    }
}
