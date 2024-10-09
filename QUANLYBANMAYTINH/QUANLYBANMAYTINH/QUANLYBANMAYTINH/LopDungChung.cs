﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QUANLYBANMAYTINH
{
    internal class LopDungChung
    {
        SqlConnection conn = new SqlConnection();
        public LopDungChung()
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LapTrinhNet\ExamWF\QUANLYBANMAYTINH\QUANLYBANMAYTINH\QUANLYBANMAYTINH\QLBanMayTinh.mdf;Integrated Security=True";
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