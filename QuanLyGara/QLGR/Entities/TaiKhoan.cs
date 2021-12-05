using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLGR.Entities
{
    class TaiKhoan
    {
        private string _tenDangNhap;

        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }

        private string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }

        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        private string _sdt;

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        private string _quyen;

        public string Quyen
        {
            get { return _quyen; }
            set { _quyen = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _hoTen;

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

    }
}
