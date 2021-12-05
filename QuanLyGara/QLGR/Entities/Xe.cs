using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLGR.Entities
{
    class Xe
    {
        #region Properties
        private String _bienSo;

        public String BienSo
        {
            get { return _bienSo; }
            set { _bienSo = value; }
        }

        private String _hieuXe;

        public String HieuXe
        {
            get { return _hieuXe; }
            set { _hieuXe = value; }
        }

        private String _hoTenChuXe;

        public String HoTenChuXe
        {
            get { return _hoTenChuXe; }
            set { _hoTenChuXe = value; }
        }

        private String _dienThoai;

        public String DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }

        private String _diaChi;

        public String DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        private String _email;

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private DateTime _ngayNhap;

        public DateTime NgayNhap
        {
            get { return _ngayNhap; }
            set { _ngayNhap = value; }
        }

        private decimal _tienNo;

        public decimal TienNo
        {
            get { return _tienNo; }
            set { _tienNo = value; }
        }
        #endregion

        #region constructor
        public Xe() { }

        public Xe(String bienSo, String hieuXe, String hoTen, String diaChi, String soDienThoai, String email, DateTime ngayNhap)
        {
            this._bienSo = bienSo;
            this._hieuXe = hieuXe;
            this._hoTenChuXe = hoTen;
            this._diaChi = diaChi;
            this._dienThoai = soDienThoai;
            this._email = email;
            this._ngayNhap = ngayNhap;
        }

        public Xe(DataRow row)
        {
            this._bienSo = row["bienso"].ToString();
            this._diaChi = row["DIACHI"].ToString();
            this._dienThoai = row["DIENTHOAI"].ToString();
            this._email = row["EMAIL"].ToString();
            this._hieuXe = row["HIEUXE"].ToString();
            this._hoTenChuXe = row["TENCHUXE"].ToString();
            this._ngayNhap = (DateTime)row["NGAYTIEPNHAN"];
            this._tienNo = decimal.Parse(row["TIENNO"].ToString());
        }
        #endregion
    }
}
