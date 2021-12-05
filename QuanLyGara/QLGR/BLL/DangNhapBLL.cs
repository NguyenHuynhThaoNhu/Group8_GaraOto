using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLGR.DataLayer;

namespace QLGR.BusinessLayer
{
    class DangNhapBLL
    {
        public static DataTable XemDL(string viewer, string user, string password)
        {
            if (viewer == "*")
                return DangNhapDAL.XemDL(user, password);
            else return DangNhapDAL.XemQuyen(user);
        }

        public static DataTable GetThongTinNguoiDung(string tenDangNhap)
        {
            return DangNhapDAL.GetThongTinNguoiDung(tenDangNhap);
        }
    }
}
