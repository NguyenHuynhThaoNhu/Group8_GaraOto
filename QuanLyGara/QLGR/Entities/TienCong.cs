using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLGR.Entities
{
    public class TienCong
    {
        private string _noiDung;

        public string NoiDung
        {
            get { return _noiDung; }
            set { _noiDung = value; }
        }

        private int _tienCongXe;

        public int TienCongXe
        {
            get { return _tienCongXe; }
            set { _tienCongXe = value; }
        }

        public TienCong() { }

        public TienCong(DataRow row)
        {
            this._noiDung = row["NOIDUNG"].ToString();
            this._tienCongXe = (int)row["TIENCONG"];
        }
    }
}
