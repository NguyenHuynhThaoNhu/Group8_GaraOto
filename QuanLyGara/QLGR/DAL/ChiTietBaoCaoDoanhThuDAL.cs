using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLGR.Entities;

namespace QLGR.DataLayer
{
    class ChiTietBaoCaoDoanhThuDAL
    {
        public static string GetMaBCDT(string maBC, string hieuXe)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETCT_BAOCAODOANHTHU");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MABC", maBC);
            cmd.Parameters.AddWithValue("@HIEUXE", hieuXe);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static void ThemCTBC(ChiTietBaoCaoDoanhThu chiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMCT_BCDT");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTBC", chiTiet.MaCTBC);
            cmd.Parameters.AddWithValue("@MABC", chiTiet.MaBC);
            cmd.Parameters.AddWithValue("@HIEUXE", chiTiet.HieuXe);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MACTBC from CT_BCDT order by MACTBC desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static void CapNhatSoLuotSua(ChiTietBaoCaoDoanhThu chiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAPNHATCT_BCDT");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTBC", chiTiet.MaCTBC);
            cmd.Parameters.AddWithValue("@MABC", chiTiet.MaBC);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatBaoCao(ChiTietBaoCaoDoanhThu chiTiet, decimal soTien)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAPNHATDOANHTHU");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTBC", chiTiet.MaCTBC);
            cmd.Parameters.AddWithValue("@MABC", chiTiet.MaBC);
            cmd.Parameters.AddWithValue("@SOTIEN", soTien);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatTiLe(ChiTietBaoCaoDoanhThu chiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAPNHATTILE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MACTBC", chiTiet.MaCTBC);
            cmd.Parameters.AddWithValue("@MABC", chiTiet.MaBC);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
