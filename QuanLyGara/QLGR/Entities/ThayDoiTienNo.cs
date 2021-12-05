using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLGR.Entities
{
    class ThayDoiTienNo
    {
        private string _bienSo;

        public string BienSo
        {
            get { return _bienSo; }
            set { _bienSo = value; }
        }

        private decimal _tienNo;

        public decimal TienNo
        {
            get { return _tienNo; }
            set { _tienNo = value; }
        }
    }
}
