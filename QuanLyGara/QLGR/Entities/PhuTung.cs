using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGR.Entities
{
    class PhuTung
    {
        private string _maPhuTung;

        public string MaPhuTung
        {
            get { return _maPhuTung; }
            set { _maPhuTung = value; }
        }

        private string _tenPhuTung;

        public string TenPhuTung
        {
            get { return _tenPhuTung; }
            set { _tenPhuTung = value; }
        }

        private decimal _donGia;

        public decimal DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }
     

        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        public PhuTung() { }
        public PhuTung(System.Data.DataRow row)
        {
            this._maPhuTung = row["MAPT"].ToString();
            this._tenPhuTung = row["TENPT"].ToString();
            this._soLuong = (int)row["SL"];
            this._donGia = (decimal)row["DONGIA"];
        }
    }
}
