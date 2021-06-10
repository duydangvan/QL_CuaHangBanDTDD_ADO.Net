using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHangDienThoai
{
    class ketnoi
    {
        SqlConnection con;
        public string connectionSTR = "Data Source=DESKTOP-94A2BA9\\SQLEXPRESS;Initial Catalog=CH_DIENTHOAIDIDONG;User ID=sa; Password=sa2012";

        public ketnoi()
        {
            con = new SqlConnection(connectionSTR);
            con.Open();

        }
        public DataTable getTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;

        }

    
        public void thuchien(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                moKetNoi(conn);
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.ExecuteNonQuery();
                dongKetNoi(conn);
            }
        }
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public int moKetNoi(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                return 1;
            }
            return 0;
        }

        public void dongKetNoi(SqlConnection conn)
        {
            conn.Close();
        }

        public string layDLDangChuoi(string query)
        {
            string data = string.Empty;
            using (SqlConnection connn = new SqlConnection(connectionSTR))
            {
                
                moKetNoi(connn);
                SqlCommand cmd = new SqlCommand(query, connn);
                data = (string)cmd.ExecuteScalar();
                dongKetNoi(connn);
                return data;
            }
        }

        public int getCount(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = strSQL;
            int count = (int)cmd.ExecuteScalar();
            closeConnection();
            return count;
        }
        public bool KiemTraTrung(string strSQL)
        {
            return getCount(strSQL) > 0 ? true : false;
        }
    }
}

