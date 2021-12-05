using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLGR.Entities;

namespace QLGR.DataLayer
{
    class HieuXeDAL
    {
        public HieuXeDAL() { }

        public static DataTable GetHieuXe()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETLISTHIEUXE");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable ThemHieuXe(string hieuXe)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMHIEUXE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HIEUXE", hieuXe);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static void XoaHieuXe(string hieuXe)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOAHIEUXE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@HIEUXE", hieuXe);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
