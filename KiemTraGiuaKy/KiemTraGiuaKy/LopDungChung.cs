using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace KiemTraGiuaKy
{
    class LopDungChung
    {
        SqlConnection conn = new SqlConnection();
        public LopDungChung()
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\KiemTraNET\KiemTraGiuaKy\KiemTraGiuaKy\QLQUANCAFE.mdf;Integrated Security=True";
        }

        public int ThemSuaXoa(string sql)
        {
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            int kq = command.ExecuteNonQuery();
            conn.Close();
            return kq;
        }

        public object LayGT(string sql)
        {
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            object kq = command.ExecuteScalar();
            conn.Close();
            return kq;
        }

        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
