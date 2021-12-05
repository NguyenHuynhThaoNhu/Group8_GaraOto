using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLGR.Entities;

namespace QLGR.DataLayer
{
    class PhuTungDAL
    {
        public static DataTable GetPhuTung()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETLISTPHUTUNG");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static string LaySoLuongPhuTung(string tenPT)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETSLPHUTUNG");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENPT", tenPT);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static decimal GetTienPhuTung(string maPT)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETDONGIAPHUTUNG");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPT", maPT);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return decimal.Parse(db.dt.Rows[0][0].ToString());
        }

        public static void ThayDoiSoLuongPhuTung(PhuTung phuTung)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THAYDOISLPT");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPT", phuTung.MaPhuTung);
            cmd.Parameters.AddWithValue("@SL", phuTung.SoLuong);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void ThayDoiPhuTung(PhuTung phuTung)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THAYDOIVTPT");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPT", phuTung.MaPhuTung);
            cmd.Parameters.AddWithValue("@TENPT", phuTung.TenPhuTung);
            cmd.Parameters.AddWithValue("@DONGIA", phuTung.DonGia);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MAPT from PHUTUNG order by MAPT desc");
            return dt.Rows[0][0].ToString();
        }

        public static void ThemPhuTung(PhuTung phuTung)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMPHUTUNG");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPT", phuTung.MaPhuTung);
            cmd.Parameters.AddWithValue("@TENPT", phuTung.TenPhuTung);
            cmd.Parameters.AddWithValue("@SL", phuTung.SoLuong);
            cmd.Parameters.AddWithValue("@DONGIA", phuTung.DonGia);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaPhuTung(string maPT)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOAPHUTUNG");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPT", maPT);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
