using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLGR.Entities;

namespace QLGR.DataLayer
{
    class ChiTietBaoCaoTonDAL
    {
        public static string  getMaChiTietBCT(string maBC, string tenPT)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETMACTBCT");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MABCT", maBC);
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
        public static void themChiTietBCT(ChiTietBaoCaoTon chitiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMCT_BCT");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTBCT", chitiet.MaCTBCT);
            cmd.Parameters.AddWithValue("@MABC", chitiet.MaBCT);
            cmd.Parameters.AddWithValue("@TENPT", chitiet.TenPT);
            cmd.Parameters.AddWithValue("@TONDAU", chitiet.TonDau);
            cmd.Parameters.AddWithValue("@PHATSINH", chitiet.PhatSinh);
            cmd.Parameters.AddWithValue("@TONCUOI", chitiet.TonCuoi);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

        }
        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MACTBCT from CT_BCT order by MACTBCT desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }
        public static void CapNhatPhatSinh(ChiTietBaoCaoTon chiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAPNHATPHATSINH");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTBCT", chiTiet.MaCTBCT);
            cmd.Parameters.AddWithValue("@SL", chiTiet.PhatSinh);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
        public static void CapNhatTonCuoi(ChiTietBaoCaoTon chiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAPNHATTONCUOI");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SL", chiTiet.TonCuoi);
            cmd.Parameters.AddWithValue("@MACTBCT", chiTiet.MaCTBCT);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
