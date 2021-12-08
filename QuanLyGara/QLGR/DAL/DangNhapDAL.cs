using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLGR.DataLayer
{
    class DangNhapDAL
    {
        public static DataTable XemDL(string user, string password)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAYDULIEUTAIKHOAN");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENDANGNHAP", user);
            cmd.Parameters.AddWithValue("@MATKHAU", password);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable XemQuyen(string user)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAYQUYENTAIKHOAN");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENDANGNHAP", user);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable GetThongTinNguoiDung(string tenDangNhap)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETTHONGTINUSER");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENDANGNHAP", tenDangNhap);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        

    }
}
