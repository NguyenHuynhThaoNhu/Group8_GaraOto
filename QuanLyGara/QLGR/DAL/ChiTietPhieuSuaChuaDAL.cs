using System.Collections.Generic;
using QLGR.Entities;
using System.Data.SqlClient;
using System.Data;

namespace QLGR.DataLayer
{
    class ChiTietPhieuSuaChuaDAL
    {
        public static void NhapChiTietPhieuSuaChua(ChiTietPhieuSuaChua ctpsc)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMCT_PSC");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTPSC", ctpsc.MaChiTietPhieuSuaChua);
            cmd.Parameters.AddWithValue("@MAPSC", ctpsc.MaPhieuSuaChua);
            cmd.Parameters.AddWithValue("@NOIDUNG", ctpsc.NoiDung);
            cmd.Parameters.AddWithValue("@MAPT", ctpsc.MaPhuTung);
            cmd.Parameters.AddWithValue("@SL", ctpsc.SoLuong);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static List<ChiTietPhieuSuaChua> ListTheoPSC(string maPSC)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETLISTCHITIETSUACHUA");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPSC", maPSC);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            List<ChiTietPhieuSuaChua> list = new List<ChiTietPhieuSuaChua>();
            foreach (DataRow row in db.dt.Rows)
            {
                list.Add(new ChiTietPhieuSuaChua(row));
            }
            return list;
        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MACTSC from CT_PSC order by MACTSC desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static string GetNoiDung(string maChiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETNOIDUNGTUCTSC");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACT", maChiTiet);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static string GetMaPT(string maChiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETMAPTTUCTSC");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACT", maChiTiet);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static DataTable GetList()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETLISTCT_PSC");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static void XoaCTPSC(string maCTPSC)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOACHITIETPSC");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACT", maCTPSC);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
