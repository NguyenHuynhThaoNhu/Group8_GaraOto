using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGR.DataLayer;
using QLGR.Entities;
using System.Data;
using System.Data.SqlClient;

namespace QLGR.BusinessLayer
{
    class TienCongBLL
    {

        public static DataTable ListNoiDung()
        {
            return TienCongDAL.GetNoiDung();
        }

        public static decimal GetTienCong(string noiDung)
        {
            return TienCongDAL.GetTienCong(noiDung);
        }

        public static void ThayDoiTienCong(TienCong tienCong)
        {
            TienCongDAL.ThayDoiTienCong(tienCong);
        }

        public static void ThemTienCong(TienCong tienCong)
        {
            TienCongDAL.ThemTienCong(tienCong);
        }

        public static bool XoaTienCong(string noiDung)
        {
            if (!ChiTietPhieuSuaChuaBLL.KiemTraTienCong(noiDung))
            {
                TienCongDAL.XoaTienCong(noiDung);
                return true;
            }

            return false;
        }
    }
}
