using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLGR.DataLayer
{
    class PhieuThuTienDAL
    {
        public static void NhapPhieuThuTien(Entities.PhieuThuTien phieuThuTien)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMPHIEUTHUTIEN");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPHIEU", phieuThuTien.MaPhieu);
            cmd.Parameters.AddWithValue("@BIENSO", phieuThuTien.BienSo);
            cmd.Parameters.AddWithValue("@NGAYTHU", phieuThuTien.NgayThu);
            cmd.Parameters.AddWithValue("@SOTIENTHU", phieuThuTien.SoTienThu);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MAPTT from PHIEUTHUTIEN order by MAPTT desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static DataTable GetListPhieu(string bienSo)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETPTT");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BIENSO", bienSo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static void XoaPhieu(string maPhieu)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOAPHIEUTHUTIEN");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPTT", maPhieu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
