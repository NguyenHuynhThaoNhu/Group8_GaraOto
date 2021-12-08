using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLGR.Entities
{
    class ChiTietBaoCaoDoanhThu
    {
        private string _maCTBC;

        public string MaCTBC
        {
            get { return _maCTBC; }
            set { _maCTBC = value; }
        }

        private string _maBC;

        public string MaBC
        {
            get { return _maBC; }
            set { _maBC = value; }
        }

        private string _hieuXe;

        public string HieuXe
        {
            get { return _hieuXe; }
            set { _hieuXe = value; }
        }

        public ChiTietBaoCaoDoanhThu() { }
    }
}
