using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGR.Entities
{
    class PhieuSuaChua
    {
        private string _maPhieuSuaChua;

        public string MaPhieuSuaChua
        {
            get { return _maPhieuSuaChua; }
            set { _maPhieuSuaChua = value; }
        }

        private string _bienSo;

        public string BienSo
        {
            get { return _bienSo; }
            set { _bienSo = value; }
        }

        private DateTime _ngaySuaChua;

        public DateTime NgaySuaChua
        {
            get { return _ngaySuaChua; }
            set { _ngaySuaChua = value; }
        }

        private decimal _tongTien;

        public decimal TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }

        public PhieuSuaChua(string maPhieuSuaChua, string bienSo, DateTime ngaySuaChua, decimal tongTien)
        {
            this._maPhieuSuaChua = maPhieuSuaChua;
            this._bienSo = bienSo;
            this._ngaySuaChua = ngaySuaChua;
            this._tongTien = tongTien;
        }

    }
}
