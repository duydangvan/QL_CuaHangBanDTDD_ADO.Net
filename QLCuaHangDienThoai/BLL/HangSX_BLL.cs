using QLCuaHangDienThoai.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDienThoai.BLL
{
    public class HangSX_BLL
    {
        HangSX hangSX = new HangSX();

        public List<string> dsHangSX()
        {
            return hangSX.loadHangSX();
        }
    }
}
