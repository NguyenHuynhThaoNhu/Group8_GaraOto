using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLGR.DataLayer;

namespace QLGR.BusinessLayer
{
    class HieuXeBLL
    {
        public static DataTable GetHieuXe()
        {
            return HieuXeDAL.GetHieuXe();
        }

        public static bool ThemHieuXe(string hieuXe)
        {
            DataTable dt = HieuXeDAL.ThemHieuXe(hieuXe);
            foreach(DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString().Trim() == "0")
                    return true;
            }
            return false;
        }

        public static bool XoaHieuXe(string hieuXe)
        {
            if (XeBLL.KiemTraHieuXe(hieuXe))
                return false;
            HieuXeDAL.XoaHieuXe(hieuXe);
            return true;
        }
    }
}
