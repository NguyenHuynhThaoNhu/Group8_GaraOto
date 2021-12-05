using QLGR.DataLayer;
using System.Data;
using QLGR.Entities;

namespace QLGR.BusinessLayer
{
    class TaiKhoanBLL
    {
        public static void ThayDoiMatKhau(string taiKhoan, string matKhauMoi)
        {
            TaiKhoanDAL.ThayDoiMatKhau(taiKhoan, matKhauMoi);
        }

        public static string MatKhauCu(string taiKhoan)
        {
            return TaiKhoanDAL.MatKhauCu(taiKhoan);
        }

        public static DataTable GetTaiKhoan()
        {
            return TaiKhoanDAL.GetTaiKhoan();
        }

        public static void ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            TaiKhoanDAL.ThemTaiKhoan(taiKhoan);
        }

        public static void ThayDoiThongTinTaiKhoan(TaiKhoan taiKhoan)
        {
            TaiKhoanDAL.ThayDoiThongTinTaiKhoan(taiKhoan);
        }

        public static void XoaTaiKhoan(string tenDangNhap)
        {
            TaiKhoanDAL.XoaTaiKhoan(tenDangNhap);
        }

        public static void CapNhatTaiKhoanNhanVien(TaiKhoan taiKhoan)
        {
            TaiKhoanDAL.CapNhatTaiKhoanNhanVien(taiKhoan);
        }
    }
}
