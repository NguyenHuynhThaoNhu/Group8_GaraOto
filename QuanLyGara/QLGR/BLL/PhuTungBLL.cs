using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLGR.DataLayer;
using QLGR.Entities;

namespace QLGR.BusinessLayer
{
    class PhuTungBLL
    {
        public static DataTable ListPhuTung()
        {
            return PhuTungDAL.GetPhuTung();
        }

        public static decimal GetTienPhuTung(string maPhuTung)
        {
            return PhuTungDAL.GetTienPhuTung(maPhuTung);
        }

        public static string LaySoLuongPhuTung(string TenPT)
        {
            return PhuTungDAL.LaySoLuongPhuTung(TenPT);
        }

        public static void ThayDoiSoLuongPhuTung(PhuTung phuTung)
        {
            PhuTungDAL.ThayDoiSoLuongPhuTung(phuTung);
        }

        public static void ThayDoiPhuTung(PhuTung phuTung)
        {
            PhuTungDAL.ThayDoiPhuTung(phuTung);
        }


        public static string MakeID()
        {
            string id = PhuTungDAL.GetLastID().Trim();
            if (id == "")
            {
                return "G20_PT_001";
            }
            int nextID = int.Parse(id.Remove(0, "G20_PT_".Length)) + 1;
            id = "00" + nextID.ToString();
            id = id.Substring(id.Length - 3, 3);
            return "G20_PT_" + id;
        }

        public static void ThemPhuTung(PhuTung phuTung)
        {
            PhuTungDAL.ThemPhuTung(phuTung);
        }

        public static bool XoaPhuTung(string maPT)
        {
            if(!ChiTietPhieuSuaChuaBLL.KiemTraPhuTung(maPT))
            {
                PhuTungDAL.XoaPhuTung(maPT);
                return true;
            }

            return false;
        }
    }
}
