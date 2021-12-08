using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLGR.Entities
{
    class QuyDinh
    {
        public QuyDinh(int soXe)
        {
            this._soXeSuaChuaToiDa = soXe;
        }

        public QuyDinh(System.Data.DataRow row)
        {
            this._soXeSuaChuaToiDa = (int)row["SOXESUACHUATOIDA"];
        }

        #region Properties
        private int _soXeSuaChuaToiDa;

        public int SoXeSuaChuaToiDa
        {
            get { return _soXeSuaChuaToiDa; }
            set { _soXeSuaChuaToiDa = value; }
        }
        #endregion


    }
}
