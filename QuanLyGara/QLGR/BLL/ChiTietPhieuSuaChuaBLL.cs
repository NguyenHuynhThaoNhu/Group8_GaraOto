using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGR.DataLayer;
using QLGR.Entities;
using System.Data;

namespace QLGR.BusinessLayer
{
    class ChiTietPhieuSuaChuaBLL
    {
        ChiTietPhieuSuaChuaBLL() { }
        
        public static void ThemCTPSC(ChiTietPhieuSuaChua ctpsc)
        {
            ChiTietPhieuSuaChuaDAL.NhapChiTietPhieuSuaChua(ctpsc);
        }

        public static List<Entities.ChiTietPhieuSuaChua> GetList(string maPSC)
        {
            return ChiTietPhieuSuaChuaDAL.ListTheoPSC(maPSC);
        }

        public static string AutoMACTSC()
        {
            string id = ChiTietPhieuSuaChuaDAL.GetLastID().Trim();
            if (id == "")
            {
                return "G20_CTPSC_000001";
            }
            int nextID = int.Parse(id.Remove(0, "G20_CTPSC_".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "G20_CTPSC_" + id;
        }

        public static bool KiemTraTienCong(string noiDung)
        {
            DataTable dt = ChiTietPhieuSuaChuaDAL.GetList();
            foreach(DataRow row in dt.Rows)
            {
                if (noiDung == ChiTietPhieuSuaChuaDAL.GetNoiDung(row.ItemArray[0].ToString()))
                    return true;
            }

            return false;
        }

        public static bool KiemTraPhuTung(string maPT)
        {
            DataTable dt = ChiTietPhieuSuaChuaDAL.GetList();
            foreach (DataRow row in dt.Rows)
            {
                if (maPT == ChiTietPhieuSuaChuaDAL.GetMaPT(row.ItemArray[0].ToString()))
                    return true;
            }

            return false;
        }

        public static void XoaCTPSC(string maCTPSC)
        {
            ChiTietPhieuSuaChuaDAL.XoaCTPSC(maCTPSC);
        }
    }
}
