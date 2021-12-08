using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLGR.DataLayer;
using QLGR.Entities;
using System.Data;

namespace QLGR.BusinessLayer
{
    class XeBLL
    {
        public XeBLL() { }

        public static bool ThemXe(Xe xe)
        {
            DataTable dt = XeDAL.NhapXe(xe);
            foreach(DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString().Trim() == "0")
                    return true;
            }
            return false;
        }

        public static List<Xe> GetList()
        {
            return XeDAL.GetList();
        }


        public static string GetChuXe(string bienSo)
        {
            return XeDAL.GetChuXe(bienSo);
        }

        public static DataTable GetThongTinXe(string bienSo)
        {
            return XeDAL.GetThongTinXe(bienSo);
        }

        public static int GetSoXeTiepNhan(DateTime ngayTiepNhan)
        {
            return XeDAL.GetSoXeTiepNhan(ngayTiepNhan);
        }

        public static DataTable TimKiemXe(string tuKhoa)
        {
            return XeDAL.TimKiemXe(tuKhoa);
        }

        public static void CapNhatThongTinXe(Xe xe)
        {
            XeDAL.CapNhatThongTinXe(xe);
        }

        public static void XoaXe(string bienSo)
        {
            DataTable dtPTT = PhieuThuTienBLL.GetListPTT(bienSo);
            foreach(DataRow row in dtPTT.Rows)
            {
                PhieuThuTienBLL.XoaPhieuThuTien(row.ItemArray[0].ToString());
            }

            DataTable dtPSC = PhieuSuaChuaBLL.GetListPSC(bienSo);
            foreach(DataRow row in dtPSC.Rows)
            {
                PhieuSuaChuaBLL.XoaPhieuSuaChua(row.ItemArray[0].ToString());
            }

            XeDAL.XoaXe(bienSo);
        }

        public static bool KiemTraHieuXe(string hieuXe)
        {
            List<Xe> listXe = XeDAL.GetList();
            foreach (Xe xe in listXe)
            {
                if (hieuXe == xe.HieuXe)
                    return true;
            }

            return false;
        }

    }
}
