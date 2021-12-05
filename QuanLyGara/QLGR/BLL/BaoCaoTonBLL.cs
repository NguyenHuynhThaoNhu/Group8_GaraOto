using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLGR.DataLayer;
using QLGR.Entities;

namespace QLGR.BusinessLayer
{
    class BaoCaoTonBLL
    {
        public static void ThemBC(BaoCaoTon baoCao)
        {
            
            BaoCaoTonDAL.ThemBaoCao(baoCao);
            DataTable dt = PhuTungBLL.ListPhuTung();
            foreach(DataRow row in dt.Rows)
            {
                ChiTietBaoCaoTon chiTiet = new ChiTietBaoCaoTon();
                chiTiet.MaCTBCT = ChiTietBaoCaoTonBLL.AutoMaCTBCT();
                chiTiet.MaBCT = baoCao.MaBCT;
                chiTiet.TenPT = row.ItemArray[1].ToString();
                chiTiet.TonDau = int.Parse(PhuTungBLL.LaySoLuongPhuTung(chiTiet.TenPT));
                chiTiet.TonCuoi = chiTiet.TonDau;
                chiTiet.PhatSinh = 0;

                ChiTietBaoCaoTonBLL.themChiTietBaoCao(chiTiet);
            }
        }
        public static string GetMaBCT(int thang, int nam)
        {
            return BaoCaoTonDAL.GetMaBaoCaoTon(thang, nam);
        }

        public static string AutoMABCT()
        {
            string id = BaoCaoTonDAL.GetLastID().Trim();
            if (id == "")
            {
                return "G20_BCT_00001";
            }
            int nextID = int.Parse(id.Remove(0, "G20_BCT_".Length)) + 1;
            id = "0000" + nextID.ToString();
            id = id.Substring(id.Length - 5, 5);
            return "G20_BCT_" + id;
        }
    }
}
