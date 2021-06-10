using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLCuaHangDienThoai
{
    class XulyTV
    {
        ketnoi kn = new ketnoi();
        public DataTable dangnhap(string taikhoan, string matkhau)
        {
            String sql = "select * from thanhvien where taikhoan='" + taikhoan + "' and matkhau='" + matkhau + "'";
            return kn.getTable(sql);
        }
        public void them(thanhvien tv)
        {
            String sql = "insert into thanhvien values('" + tv.Taikhoan + "','" + tv.Matkhau + "','" + tv.Manv + "')";
            kn.thuchien(sql);
        }
    }
}
