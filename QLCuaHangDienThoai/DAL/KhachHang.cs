using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDienThoai.DAL
{
    public class KhachHang
    {
        ketnoi kn = new ketnoi();
        string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        string tenKH;

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        string sDT;

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
        string ngaySinh;

        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        string eMail;

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }

        public KhachHang(string maKH, string tenKH, string diaChi, string sDT, string ngaySinh, string eMail)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.diaChi = diaChi;
            this.sDT = sDT;
            this.ngaySinh = ngaySinh;
            this.eMail = eMail;
        }

        public KhachHang() { }

        public string loadMaKH(string tenKH)
        {
            string maKH = string.Empty;
            string query = "select makh from khachhang where tenkh=N'" + tenKH + "'";
            maKH = kn.layDLDangChuoi(query);
            return maKH;


        }

        public DataTable loadKH()
        {
            string query = "select * from khachhang";
            return kn.getTable(query);
        }

        public int soLuongTrungMaKH(string maKH)
        {
            string query = "select count(*) from khachhang where makh='" + maKH + "'";
            return int.Parse(kn.getCount(query).ToString());
        }

        public void themKH(KhachHang kh)
        {
            string query = "SET DATEFORMAT DMY INSERT INTO KHACHHANG VALUES ('" + kh.maKH + "', N'" + kh.tenKH + "', N'" + kh.diaChi + "', '" + kh.sDT + "', '" + kh.ngaySinh + "', '" + kh.eMail + "')";
            kn.thuchien(query);
        }

        public void saveKH(KhachHang kh)
        {
            string query = "set DATEFORMAT DMY update KHACHHANG set TENKH = N'" + kh.tenKH + "', DIACHI = N'" + kh.diaChi + "',SDT = '" + kh.sDT + "',NgaySinh = '" + kh.ngaySinh + "',EMAIL = '" + kh.eMail + "' where MAKH = '" + kh.maKH + "'";
            kn.thuchien(query);
        }

       public string taoMaKHTuDong()
        {
            Random rd = new Random();
            string maKH = "KH0" + rd.Next(0, 500);
            string query = "select count(*) from khachhang where makh='" + maKH + "'";
            int kq = kn.getCount(query);
            while (kq >= 1)
            {
                maKH = "KH0" + rd.Next(0, 500);
                query = "select count(*) from khachhang where makh='" + maKH + "'";
                kq = kn.getCount(query);
            }
            return maKH;
        }
    }
}
