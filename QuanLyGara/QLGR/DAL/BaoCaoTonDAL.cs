using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLGR.Entities;

namespace QLGR.DataLayer
{
    class BaoCaoTonDAL
    {
        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MABCT from BAOCAOTON order by MABCT desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }
        public static string GetMaBaoCaoTon(int thang, int nam)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETMABAOCAOTON");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@THANG", thang);
            cmd.Parameters.AddWithValue("@NAM", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        
        public static void ThemBaoCao(BaoCaoTon baoCao)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMBAOCAOTON");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MABCT", baoCao.MaBCT);
            cmd.Parameters.AddWithValue("@THANG", baoCao.Thang);
            cmd.Parameters.AddWithValue("@NAM", baoCao.Nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
