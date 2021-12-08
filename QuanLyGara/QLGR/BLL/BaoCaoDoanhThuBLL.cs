using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLGR.DataLayer;
using QLGR.Entities;

namespace QLGR.BusinessLayer
{
    class BaoCaoDoanhThuBLL
    {
        public static void ThemBC(BaoCaoDoanhThu baoCao)
        {
            BaoCaoDoanhThuDAL.ThemBaoCao(baoCao);
            DataTable dt = HieuXeBLL.GetHieuXe();
            foreach(DataRow row in dt.Rows)
            {
                ChiTietBaoCaoDoanhThu chiTiet = new ChiTietBaoCaoDoanhThu();
                chiTiet.MaCTBC = ChiTietBaoCaoDoanhThuBLL.AutoMACTBC();
                chiTiet.MaBC = baoCao.MaBaoCaoDoanhThu;
                chiTiet.HieuXe = row.ItemArray[0].ToString();

                ChiTietBaoCaoDoanhThuBLL.ThemCTBC(chiTiet);
            }
        }

        public static string GetMaBC(int thang, int nam)
        {
            return BaoCaoDoanhThuDAL.GetMaBaoCao(thang, nam);
        }

        public static string AutoMABC()
        {
            string id = BaoCaoDoanhThuDAL.GetLastID().Trim();
            if (id == "")
            {
                return "G20_BCDT_00001";
            }
            int nextID = int.Parse(id.Remove(0, "G20_BCDT_".Length)) + 1;
            id = "0000" + nextID.ToString();
            id = id.Substring(id.Length - 5, 5);
            return "G20_BCDT_" + id;
        }
    }
}
