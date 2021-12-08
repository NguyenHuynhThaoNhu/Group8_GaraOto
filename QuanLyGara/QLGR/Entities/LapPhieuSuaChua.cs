using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGR.Entities
{
    public class LapPhieuSuaChua
    {
        private string _bienSo;

        public string BienSo
        {
            get { return _bienSo; }
            set { _bienSo = value; }
        }

        private string _chuXe;

        public string ChuXe
        {
            get { return _chuXe; }
            set { _chuXe = value; }
        }

        public LapPhieuSuaChua() { }
    }
}
