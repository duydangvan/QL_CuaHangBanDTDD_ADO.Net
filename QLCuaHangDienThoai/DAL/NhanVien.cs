using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDienThoai.BLL
{
    public class NhanVien
    {
        ketnoi kn = new ketnoi();

        string maNV;
        string hoTen;
        string diaChi;
        string CMND;
        string ngaySinh;
        string sDT;
        string eMail;
        string chucVu;

        public NhanVien() { }

        public NhanVien(string maNV, string hoTen, string diaChi, string cMND, string ngaySinh, string sDT, string eMail, string chucVu)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            CMND = cMND;
            this.ngaySinh = ngaySinh;
            this.sDT = sDT;
            this.eMail = eMail;
            this.chucVu = chucVu;
        }

        public string getNameNV(string pMaNV)
        {
                string query = "select hoten from NHANVIEN where manv = N'" + pMaNV + "'";
                return kn.layDLDangChuoi(query);
        }

        public string getMaNV(string tenDAngNhap, string pMatKhau)
        {
            string query = "select nhanvien.MANV from NHANVIEN, THANHVIEN WHERE NHANVIEN.MANV = THANHVIEN.MANV AND TAIKHOAN = '" + tenDAngNhap + "' AND MATKHAU = '" + pMatKhau + "'";
            return kn.layDLDangChuoi(query);
        }

        public string getNameNV(string tenDAngNhap, string pMatKhau)
        {
            string query1 = "select HoTEN from NHANVIEN, THANHVIEN WHERE NHANVIEN.MANV = THANHVIEN.MANV AND TAIKHOAN = '" + tenDAngNhap + "' AND MATKHAU = '" + pMatKhau + "'";
            return kn.layDLDangChuoi(query1);
        }

        public DataTable loadNV()
        {
            string query = "select * from nhanvien";
            return kn.getTable(query);
        }

        public void themNV(NhanVien nv)
        {
            string query = "SET DATEFORMAT DMY INSERT INTO NHANVIEN VALUES ('" + nv.maNV + "', N'" + nv.hoTen + "', N'" + nv.diaChi + "', '" + nv.CMND + "', '" + nv.ngaySinh + "', '" + nv.sDT + "', '" + nv.eMail + "', N'" + nv.chucVu + "')";
            kn.thuchien(query);
        }

        public void luuNV(NhanVien nv)
        {
            string query = "set DATEFORMAT DMY UPDATE NHANVIEN SET HOTEN = N'" + nv.hoTen + "',DIACHI = N'" + nv.diaChi + "',SDT = '" + nv.sDT + "',NGAYSINH = '" + nv.ngaySinh + "',CMND = '" + nv.CMND + "',EMAIL = '" + nv.eMail + "',CHUCVU = N'" + nv.chucVu + "' WHERE MANV = '" + nv.maNV + "'";
            kn.thuchien(query);
        }

        public string tuDongTaoMaNV()
        {
            string nv = "NV0";
            Random rd = new Random();
            int so = rd.Next(0, 500);
            return nv + so;
        }

        public string taoMaNVKhongTrung()
        {
            string manv = tuDongTaoMaNV();
            string query = "select count(*) from nhanvien where manv='" + manv + "'";
            while (kn.KiemTraTrung(query))
            {
                manv = tuDongTaoMaNV();
                query = "select count(*) from nhanvien where manv='" + manv + "'";
            }
            return manv;
        }
    }
}
