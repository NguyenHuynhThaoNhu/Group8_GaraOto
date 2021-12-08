using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLGR.Presentation;
using QLGR.Entities;

namespace QLGR.DataLayer
{
    class XeDAL
    {
        public XeDAL() { }

        public static DataTable NhapXe(Xe xe)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMXE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BIENSO", xe.BienSo);
            cmd.Parameters.AddWithValue("@TENCX", xe.HoTenChuXe);
            cmd.Parameters.AddWithValue("@HIEUXE", xe.HieuXe);
            cmd.Parameters.AddWithValue("@DIACHI", xe.DiaChi);
            cmd.Parameters.AddWithValue("@DIENTHOAI", xe.DienThoai);
            cmd.Parameters.AddWithValue("@EMAIL", xe.Email);
            cmd.Parameters.AddWithValue("@NGAYTN", xe.NgayNhap);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static List<Xe> GetList()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETLISTXE");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            List<Xe> xe = new List<Xe>();
            foreach(DataRow row in db.dt.Rows)
            {
                xe.Add(new Xe(row));
            }

            return xe;
        }

        public static string GetChuXe(string bienXe)
        {
            string chuXe;
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETTENCHUXE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BIENSO", bienXe);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                chuXe = row.ItemArray[0].ToString();
                return chuXe;
            }
            return null;
        }

        public static string GetHieuXe(string bienSo)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETHIEUXE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BIENSO", bienSo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach (DataRow row in db.dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return null;
        }

        public static int GetSoXeTiepNhan(DateTime ngayTiepNhan)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAYSOXETIEPNHANTRONGNGAY");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NGAYTIEPNHAN", ngayTiepNhan);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            int soXe = 0;

            foreach (DataRow row in db.dt.Rows)
            {
                soXe = int.Parse(row.ItemArray[0].ToString());
            }
            return soXe;
        }

        public static DataTable GetThongTinXe(string bienSo)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETTHONGTINXE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BIENSO", bienSo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable TimKiemXe(string tuKhoa)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("TIMKIEMXE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TUKHOA", tuKhoa);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static void CapNhatThongTinXe(Xe xe)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("SUATTXE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BIENSO", xe.BienSo);
            cmd.Parameters.AddWithValue("@TENCX", xe.HoTenChuXe);
            cmd.Parameters.AddWithValue("@DIACHI", xe.DiaChi);
            cmd.Parameters.AddWithValue("@DIENTHOAI", xe.DienThoai);
            cmd.Parameters.AddWithValue("@EMAIL", xe.Email);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaXe(string bienSo)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOAXE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BIENSO", bienSo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        
    }
}
