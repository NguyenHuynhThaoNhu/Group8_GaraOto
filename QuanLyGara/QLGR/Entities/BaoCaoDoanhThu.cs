using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLGR.Entities
{
    class BaoCaoDoanhThu
    {
        private string _maBCDT;

        public string MaBaoCaoDoanhThu
        {
            get { return _maBCDT; }
            set { _maBCDT = value; }
        }


        private int _thang;

        public int Thang
        {
            get { return _thang; }
            set { _thang = value; }
        }

        private int _nam;

        public int Nam
        {
            get { return _nam; }
            set { _nam = value; }
        }

        private decimal _tongDoanhThu;

        public decimal TongDoanhThu
        {
            get { return _tongDoanhThu; }
            set { _tongDoanhThu = value; }
        }

        public BaoCaoDoanhThu() { }

        public BaoCaoDoanhThu(string maBC, int thang, int nam)
        {
            this.MaBaoCaoDoanhThu = maBC;
            this.Thang = thang;
            this.Nam = nam;
        }
    }
}
