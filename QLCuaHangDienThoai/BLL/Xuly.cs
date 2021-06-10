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
    
    class Xuly
    {
        ketnoi kn = new ketnoi();
        public DataTable loadDT()
        {
            String sql = "select MASP as N'Mã SP',TENSP as N'Tên SP',SoLuong as N'Số Lượng',DONGIA as N'Đơn Giá',XUATXU as N'Xuất Xứ', THOIGIAN_BH as N'Thời Gian Bảo Hàng'  from SANPHAM ";
            return kn.getTable(sql);
        }
        public void xoa(String MASP)
        {
            String sql = "delete from SANPHAM where MASP ='" + MASP + "'";
            kn.thuchien(sql);
        }
    }
}
