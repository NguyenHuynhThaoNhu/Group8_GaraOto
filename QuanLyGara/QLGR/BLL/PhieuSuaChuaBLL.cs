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
    class PhieuSuaChuaBLL
    {
        public static void ThemPhieuSuaChua(PhieuSuaChua psc)
        {
            PhieuSuaChuaDAL.ThemPhieuSuaChua(psc);

            string hieuXe = XeDAL.GetHieuXe(psc.BienSo);
            string maBCDT = BaoCaoDoanhThuBLL.GetMaBC(psc.NgaySuaChua.Month, psc.NgaySuaChua.Year);

            if(maBCDT == "")
            {
                maBCDT = BaoCaoDoanhThuBLL.AutoMABC();

                BaoCaoDoanhThu baoCao = new BaoCaoDoanhThu();
                baoCao.MaBaoCaoDoanhThu = maBCDT;
                baoCao.Thang = psc.NgaySuaChua.Month;
                baoCao.Nam = psc.NgaySuaChua.Year;

                BaoCaoDoanhThuBLL.ThemBC(baoCao);
            }

            ChiTietBaoCaoDoanhThu chiTiet = new ChiTietBaoCaoDoanhThu();
            chiTiet.MaBC = maBCDT;
            chiTiet.MaCTBC = ChiTietBaoCaoDoanhThuBLL.GetMaCTBC(maBCDT, hieuXe);

            if(chiTiet.MaCTBC == "")
            {
                chiTiet.MaCTBC = ChiTietBaoCaoDoanhThuBLL.AutoMACTBC();
                chiTiet.HieuXe = hieuXe;
                ChiTietBaoCaoDoanhThuBLL.ThemCTBC(chiTiet);
            }

            ChiTietBaoCaoDoanhThuBLL.CapNhatSoLuotSua(chiTiet);

            string maBCT = BaoCaoTonBLL.GetMaBCT(psc.NgaySuaChua.Month, psc.NgaySuaChua.Year);
            if (maBCT == "")
            {
                maBCT = BaoCaoTonBLL.AutoMABCT();

                BaoCaoTon BCT = new BaoCaoTon();
                BCT.MaBCT = maBCT;
                BCT.Thang = psc.NgaySuaChua.Month;
                BCT.Nam = psc.NgaySuaChua.Year;

                BaoCaoTonBLL.ThemBC(BCT);
            }
        }

        public static string AutoMAPSC()
        {
            string id = PhieuSuaChuaDAL.GetLastID().Trim();
            if (id == "")
            {
                return "G20_PSC_00001";
            }
            int nextID = int.Parse(id.Remove(0, "G20_PSC_".Length)) + 1;
            id = "0000" + nextID.ToString();
            id = id.Substring(id.Length - 5, 5);
            return "G20_PSC_" + id;
        }

        public static DataTable GetListPSC(string bienSo)
        {
            return PhieuSuaChuaDAL.GetListPhieu(bienSo);
        }

        public static List<ChiTietPhieuSuaChua> GetCTPSC(string bienSo)
        {
            DataTable dt = PhieuSuaChuaDAL.GetListPhieu(bienSo);
            List<ChiTietPhieuSuaChua> listChiTiet = new List<ChiTietPhieuSuaChua>();
            foreach(DataRow row in dt.Rows)
            {
                foreach (ChiTietPhieuSuaChua chiTiet in ChiTietPhieuSuaChuaBLL.GetList(row.ItemArray[0].ToString()))
                {
                    listChiTiet.Add(chiTiet);
                }
            }
            return listChiTiet;
        }

        public static void XoaPhieuSuaChua(string maPhieu)
        {
            PhieuSuaChuaDAL.XoaPhieu(maPhieu);
        }
    }
}
