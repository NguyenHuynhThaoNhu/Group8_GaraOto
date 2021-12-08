using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLGR.DataLayer;
using QLGR.Entities;
using System.Data;

namespace QLGR.BusinessLayer
{
    class PhieuThuTienBLL
    {
        public static void NhapPhieuThuTien(PhieuThuTien phieuThuTien)
        {
            PhieuThuTienDAL.NhapPhieuThuTien(phieuThuTien);
            string hieuXe = XeDAL.GetHieuXe(phieuThuTien.BienSo);
            string maBCDT = BaoCaoDoanhThuBLL.GetMaBC(phieuThuTien.NgayThu.Month, phieuThuTien.NgayThu.Year);

            if (maBCDT == "")
            {
                maBCDT = BaoCaoDoanhThuBLL.AutoMABC();

                BaoCaoDoanhThu baoCao = new BaoCaoDoanhThu();
                baoCao.MaBaoCaoDoanhThu = maBCDT;
                baoCao.Thang = phieuThuTien.NgayThu.Month;
                baoCao.Nam = phieuThuTien.NgayThu.Year;

                BaoCaoDoanhThuBLL.ThemBC(baoCao);
            }

            ChiTietBaoCaoDoanhThu chiTiet = new ChiTietBaoCaoDoanhThu();
            chiTiet.MaBC = maBCDT;
            chiTiet.MaCTBC = ChiTietBaoCaoDoanhThuBLL.GetMaCTBC(maBCDT, hieuXe);
            chiTiet.HieuXe = hieuXe;

            if (chiTiet.MaCTBC == "")
            {
                chiTiet.MaCTBC = ChiTietBaoCaoDoanhThuBLL.AutoMACTBC();
                ChiTietBaoCaoDoanhThuBLL.ThemCTBC(chiTiet);
            }

            ChiTietBaoCaoDoanhThuBLL.CapNhatBaoCao(chiTiet, phieuThuTien.SoTienThu);
        }

        public static string AutoMACTSC()
        {
            string id = PhieuThuTienDAL.GetLastID().Trim();
            if (id == "")
            {
                return "G20_PTT_000001";
            }
            int nextID = int.Parse(id.Remove(0, "G20_PTT_".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "G20_PTT_" + id;
        }

        public static DataTable GetListPTT(string bienSo)
        {
            return PhieuThuTienDAL.GetListPhieu(bienSo);
        }

        public static void XoaPhieuThuTien(string maPhieu)
        {
            PhieuThuTienDAL.XoaPhieu(maPhieu);
        }
    }
}
