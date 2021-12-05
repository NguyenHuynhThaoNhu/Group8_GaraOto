using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLGR.Entities;

namespace QLGR.DataLayer
{
    class ThayDoiTienNoDAL
    {
        public static void ThayDoiTienNo(ThayDoiTienNo tienNo)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THAYDOITIENNO");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_BIENSO", tienNo.BienSo);
            cmd.Parameters.AddWithValue("@_TIENNO", tienNo.TienNo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

    }
}
