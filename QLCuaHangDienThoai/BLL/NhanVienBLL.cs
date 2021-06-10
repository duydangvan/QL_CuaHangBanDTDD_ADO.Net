using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDienThoai.BLL
{
    public class NhanVienBLL
    {
        NhanVien nhanVien = new NhanVien();

        public string getNameNV(string pMaNV)
        {
            return nhanVien.getNameNV(pMaNV);
        }

        public string getMaNV(string tenDangNhap,string matKhau)
        {
            return nhanVien.getMaNV(tenDangNhap,matKhau);
        }

        public string getNameNV(string tenDangNhap, string matKhau)
        {
            return nhanVien.getNameNV(tenDangNhap,matKhau);
        }

        public DataTable loadNV()
        {
            return nhanVien.loadNV();
        }

        public void addNV(NhanVien nv)
        {
            nhanVien.themNV(nv);
        }

        public void saveNV(NhanVien nv)
        {
            nhanVien.luuNV(nv);
        }

        public string tuDongTaoMaNVKhongTrung()
        {
           return nhanVien.taoMaNVKhongTrung();
        }
    }
}
