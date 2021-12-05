using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLGR.DataLayer;
using QLGR.Entities;
using System.Data;

namespace QLGR.BusinessLayer
{
    class ChiTietBaoCaoDoanhThuBLL
    {
        public static void ThemCTBC(ChiTietBaoCaoDoanhThu chiTiet)
        {
            ChiTietBaoCaoDoanhThuDAL.ThemCTBC(chiTiet);
        }

        public static string GetMaCTBC(string maBC, string hieuXe)
        {
            return ChiTietBaoCaoDoanhThuDAL.GetMaBCDT(maBC, hieuXe);
        }

        public static void CapNhatSoLuotSua(ChiTietBaoCaoDoanhThu chiTiet)
        {
            ChiTietBaoCaoDoanhThuDAL.CapNhatSoLuotSua(chiTiet);
        }

        public static string AutoMACTBC()
        {
            string id = ChiTietBaoCaoDoanhThuDAL.GetLastID().Trim();
            if (id == "")
            {
                return "G20_CTBC_00001";
            }
            int nextID = int.Parse(id.Remove(0, "G20_CTBC_".Length)) + 1;
            id = "0000" + nextID.ToString();
            id = id.Substring(id.Length - 5, 5);
            return "G20_CTBC_" + id;
        }

        public static void CapNhatBaoCao(ChiTietBaoCaoDoanhThu chiTiet, decimal soTien)
        {
            ChiTietBaoCaoDoanhThuDAL.CapNhatBaoCao(chiTiet, soTien);
            DataTable dt = HieuXeBLL.GetHieuXe();
            foreach (DataRow row in dt.Rows)
            {
                ChiTietBaoCaoDoanhThu _chiTiet = new ChiTietBaoCaoDoanhThu();
                _chiTiet.MaBC = chiTiet.MaBC;
                _chiTiet.HieuXe = row.ItemArray[0].ToString();
                _chiTiet.MaCTBC = ChiTietBaoCaoDoanhThuDAL.GetMaBCDT(_chiTiet.MaBC, _chiTiet.HieuXe);
                ChiTietBaoCaoDoanhThuDAL.CapNhatTiLe(_chiTiet);
            }
        }
    }
}
