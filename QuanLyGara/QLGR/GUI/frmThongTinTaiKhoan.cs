using System;
using QLGR.BusinessLayer;
using System.Data;
using System.Windows.Forms;
using QLGR.Entities;

namespace QLGR.Presentation
{
    public partial class frmThongTinTaiKhoan : Form
    {
        public static string tenDangNhap, matKhau;
        string quyen;

        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            //txtChucVu.Text = DangNhapBLL.XemDL("QUYEN", tenDangNhap, matKhau).Rows[0][0].ToString();
            GetThongTinTaiKhoan();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.DiaChi = txtDiaChi.Text;
                taiKhoan.Email = txtEmail.Text;
                taiKhoan.HoTen = txtHoTen.Text;
                taiKhoan.SDT = txtSDT.Text;
                taiKhoan.TenDangNhap = tenDangNhap;
                taiKhoan.Quyen = quyen;
                taiKhoan.MatKhau = matKhau;

                TaiKhoanBLL.ThayDoiThongTinTaiKhoan(taiKhoan);
                MessageBox.Show("Thay đổi thông tin tài khoản thành công!", "Thông báo");
                this.Close();
            }
            catch {; }
        }

        void GetThongTinTaiKhoan()
        {
            DataTable dt = DangNhapBLL.GetThongTinNguoiDung(tenDangNhap);
            txtHoTen.Text = dt.Rows[0]["HOTEN"].ToString();
            txtSDT.Text = dt.Rows[0]["SDT"].ToString();
            txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
            string chucVu = dt.Rows[0]["QUYEN"].ToString();
            quyen = chucVu.Trim();
            if (chucVu == "GIAMDOC   ")
                txtChucVu.Text = "Giám đốc";
            else if (chucVu == "QUANLI    ")
                txtChucVu.Text = "Quản lí";
            else if (chucVu == "NHANVIEN  ")
                txtChucVu.Text = "Nhân viên";
        }
    }
}
