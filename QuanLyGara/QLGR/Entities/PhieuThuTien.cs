using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLGR.Entities
{
    class PhieuThuTien
    {
        private string _maPhieu;

        public string MaPhieu
        {
            get { return _maPhieu; }
            set { _maPhieu = value; }
        }

        private string _bienSo;

        public string BienSo
        {
            get { return _bienSo; }
            set { _bienSo = value; }
        }

        private DateTime _ngayThu;

        public DateTime NgayThu
        {
            get { return _ngayThu; }
            set { _ngayThu = value; }
        }

        private decimal _soTienThu;

        public decimal SoTienThu
        {
            get { return _soTienThu; }
            set { _soTienThu = value; }
        }

        public PhieuThuTien(string maPhieu, string bienSo, DateTime ngayThu, decimal soTienThu)
        {
            this._maPhieu = maPhieu;
            this._bienSo = bienSo;
            this._ngayThu = ngayThu;
            this._soTienThu = soTienThu;
        }
    }
}
