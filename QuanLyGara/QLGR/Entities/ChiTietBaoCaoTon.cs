using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLGR.Entities
{
    class ChiTietBaoCaoTon
    {
        private string _maCTBCT;
        public string MaCTBCT
        {
            get { return _maCTBCT; }
            set { _maCTBCT = value; }
        }

        private string _maBCT;
        public string MaBCT
        {
            get { return _maBCT; }
            set { _maBCT = value; }
        }

        private string _tenPT;
        public string TenPT
        {
            get { return _tenPT; }
            set { _tenPT = value; }
        }

        private int tonDau;
        public int TonDau
        {
            get { return tonDau; }
            set { tonDau = value; }
        }

        private int tonCuoi;
        public int TonCuoi
        {
            get { return tonCuoi; }
            set { tonCuoi = value; }
        }

        private int phatSinh;
        public int PhatSinh
        {
            get { return phatSinh; }
            set { phatSinh = value; }
        }
        public ChiTietBaoCaoTon() {}
    }
}
