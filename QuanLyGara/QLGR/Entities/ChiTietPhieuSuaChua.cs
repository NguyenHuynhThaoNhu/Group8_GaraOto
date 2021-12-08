using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGR.Entities
{
    class ChiTietPhieuSuaChua
    {
        private string _maChiTietPhieuSuaChua;

        public string MaChiTietPhieuSuaChua
        {
            get { return _maChiTietPhieuSuaChua; }
            set { _maChiTietPhieuSuaChua = value; }
        }

        private string _maPhieuSuaChua;

        public string MaPhieuSuaChua
        {
            get { return _maPhieuSuaChua; }
            set { _maPhieuSuaChua = value; }
        }

        private string _maPhuTung;

        public string MaPhuTung
        {
            get { return _maPhuTung; }
            set { _maPhuTung = value; }
        }

        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        private string _noiDung;

        public string NoiDung
        {
            get { return _noiDung; }
            set { _noiDung = value; }
        }

        private decimal _thanhTien;

        public decimal ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }


        public ChiTietPhieuSuaChua(string maCTPSC, string maPSC, string maPT, int soLuong, string noiDung, decimal thanhTien)
        {
            this._maChiTietPhieuSuaChua = maCTPSC;
            this._maPhieuSuaChua = maPSC;
            this._maPhuTung = maPT;
            this._soLuong = soLuong;
            this._noiDung = noiDung;
            this._thanhTien = thanhTien;
        }

        public ChiTietPhieuSuaChua(System.Data.DataRow row)
        {
            this._maChiTietPhieuSuaChua = row["MACTSC"].ToString();
            this._maPhieuSuaChua = row["MAPSC"].ToString();
            this._maPhuTung = row["MAPT"].ToString();
            this._noiDung = row["NOIDUNG"].ToString();
            this._soLuong = (int)row["SL"];
            this._thanhTien = (decimal)row["THANHTIEN"];
        }
    }
}
