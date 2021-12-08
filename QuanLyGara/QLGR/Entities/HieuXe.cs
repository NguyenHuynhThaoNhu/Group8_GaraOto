using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLGR.Entities
{
    class HieuXe
    {
        public HieuXe(string hieuXe)
        {
            this._hieuXe = hieuXe;
        }

        public HieuXe(System.Data.DataRow row)
        {
            this._hieuXe = row["HIEUXE"].ToString();
        }

        #region Properties
        private string _hieuXe;

        public string _HieuXe
        {
            get { return _hieuXe; }
            set { _hieuXe = value; }
        }

        #endregion
    }
}
