using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLGR.DataLayer;
using QLGR.Entities;
using System.Data;

namespace QLGR.BusinessLayer
{
    class ChiTietBaoCaoTonBLL
    {
        public static string getMaCTBCT(string maBCT, string tenPhuTung)
        {
            return ChiTietBaoCaoTonDAL.getMaChiTietBCT(maBCT, tenPhuTung);
        }
        public static void themChiTietBaoCao(ChiTietBaoCaoTon chitiet)
        {
            ChiTietBaoCaoTonDAL.themChiTietBCT(chitiet);
        }
        public static void capNhatTonCuoi(ChiTietBaoCaoTon chitiet)
        {
            ChiTietBaoCaoTonDAL.CapNhatTonCuoi(chitiet);
        }
        public static void capNhatPhatSinh(ChiTietBaoCaoTon chitiet)
        {
            ChiTietBaoCaoTonDAL.CapNhatPhatSinh(chitiet);
        }
        public static string AutoMaCTBCT()
        {
            string id = ChiTietBaoCaoTonDAL.GetLastID().Trim();
            if (id == "")
            {
                return "G20_CTBCT_00001";
            }
            int nextID = int.Parse(id.Remove(0, "G20_CTBCT_".Length)) + 1;
            id = "0000" + nextID.ToString();
            id = id.Substring(id.Length - 5, 5);
            return "G20_CTBCT_" + id;
        }
    }
}
