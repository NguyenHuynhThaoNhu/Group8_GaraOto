using System.Data.SqlClient;
using System.Data;
using QLGR.Entities;

namespace QLGR.DataLayer
{
    class TaiKhoanDAL
    {
        public static void ThayDoiMatKhau(string taiKhoan, string matKhauMoi)
        {

            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THAYDOIMATKHAU");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENDANGNHAP", taiKhoan);
            cmd.Parameters.AddWithValue("@MATKHAU", matKhauMoi);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static string MatKhauCu(string taiKhoan)
        {
            string matKhauCu = "";
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETMATKHAU");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENDANGNHAP", taiKhoan);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
                matKhauCu = row[0].ToString();
            return matKhauCu;
        }

        public static DataTable GetTaiKhoan()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETTAIKHOAN");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static void ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMTAIKHOAN");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENDANGNHAP", taiKhoan.TenDangNhap);
            cmd.Parameters.AddWithValue("@MATKHAU", taiKhoan.MatKhau);
            cmd.Parameters.AddWithValue("@QUYEN", taiKhoan.Quyen);
            cmd.Parameters.AddWithValue("@HOTEN", taiKhoan.HoTen);
            cmd.Parameters.AddWithValue("@SODT", taiKhoan.SDT);
            cmd.Parameters.AddWithValue("@DIACHI", taiKhoan.DiaChi);
            cmd.Parameters.AddWithValue("@EMAIL", taiKhoan.Email);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void ThayDoiThongTinTaiKhoan(TaiKhoan taiKhoan)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THAYDOITAIKHOAN");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENDANGNHAP", taiKhoan.TenDangNhap);
            cmd.Parameters.AddWithValue("@QUYEN", taiKhoan.Quyen);
            cmd.Parameters.AddWithValue("@HOTEN", taiKhoan.HoTen);
            cmd.Parameters.AddWithValue("@SODT", taiKhoan.SDT);
            cmd.Parameters.AddWithValue("@DIACHI", taiKhoan.DiaChi);
            cmd.Parameters.AddWithValue("@EMAIL", taiKhoan.Email);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaTaiKhoan(string tenDangNhap)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOATAIKHOAN");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENDANGNHAP", tenDangNhap);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatTaiKhoanNhanVien(TaiKhoan taiKhoan)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("UPDATE TAIKHOAN SET HOTEN = N'" + taiKhoan.HoTen + "', SDT = '" + taiKhoan.SDT + "', DIACHI ='" + taiKhoan.DiaChi + "', EMAIL ='" + taiKhoan.Email + "' WHERE TENDANGNHAP = '" + taiKhoan.TenDangNhap + "' ");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
