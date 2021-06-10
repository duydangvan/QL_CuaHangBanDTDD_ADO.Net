using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDienThoai.DAL
{
   public class HangSX
    {
        ketnoi kn = new ketnoi();
        string maHang;
        string tenHang;
        string diaChi;

        public HangSX(string maHang, string tenHang, string diaChi)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.diaChi = diaChi;
        }

        public HangSX()
        { }

        public List<string> loadHangSX()
        {
            SqlConnection con = new SqlConnection(kn.connectionSTR);
            string query = "select TENHANGSX from HANGSX";
            List<string> ds = new List<string>();
            ds.Add("Chọn tất cả");
            kn.moKetNoi(con);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ds.Add(rd[0].ToString());
            }
            kn.dongKetNoi(con);
            return ds;
        }
       
    }
}
