using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGR.Entities;
using System.Data;
using System.Data.SqlClient;

namespace QLGR.DataLayer
{
    public class TienCongDAL
    {
        public TienCongDAL() { }

        public static DataTable GetNoiDung()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETLISTTIENCONG");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static decimal GetTienCong(string noiDung)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETTIENCONG");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOIDUNG", noiDung);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return decimal.Parse(db.dt.Rows[0][0].ToString());
        }

        public static void ThayDoiTienCong(TienCong tienCong)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMTIENCONG");

            cmd.Parameters.AddWithValue("@NOIDUNG", tienCong.NoiDung);
            cmd.Parameters.AddWithValue("@TIENCONG", tienCong.TienCongXe);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void ThemTienCong(TienCong tienCong)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMTIENCONG");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOIDUNG", tienCong.NoiDung);
            cmd.Parameters.AddWithValue("@TIENCONG", tienCong.TienCongXe);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaTienCong(string noiDung)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOATIENCONG");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOIDUNG", noiDung);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
