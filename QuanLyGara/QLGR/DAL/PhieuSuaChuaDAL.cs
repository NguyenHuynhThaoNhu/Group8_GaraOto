using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLGR.Entities;


namespace QLGR.DataLayer
{
    class PhieuSuaChuaDAL
    {
        public static void ThemPhieuSuaChua(PhieuSuaChua psc)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMPSC");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPSC", psc.MaPhieuSuaChua);
            cmd.Parameters.AddWithValue("@BIENSO", psc.BienSo);
            cmd.Parameters.AddWithValue("@NGAYSC", psc.NgaySuaChua); //Ngày sửa chữa là ngày lập phiếu
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new System.Data.DataTable();
            da.Fill(db.dt);
        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MAPSC from PHIEUSUACHUA order by MAPSC desc");
            foreach(DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static DataTable GetListPhieu(string bienSo)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETPSC");

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
            SqlCommand cmd = db.Command("XOAPHIEUSUACHUA");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPSC", maPhieu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
