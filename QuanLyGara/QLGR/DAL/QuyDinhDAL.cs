using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLGR.Entities;

namespace QLGR.DataLayer
{
    class QuyDinhDAL
    {
        public static void ThayDoiQuyDinh(QuyDinh quyDinh)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("TDSLXE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOXESUACHUATOIDA", quyDinh.SoXeSuaChuaToiDa);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static QuyDinh GetQuyDinh()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETSOXESUACHUATOIDA");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return new QuyDinh(db.dt.Rows[0]);
        }
    }
}
