using QLGR.BusinessLayer;
using System.Windows.Forms;
using System;
using QLGR.Entities;
using DevComponents.DotNetBar;

namespace QLGR.Presentation
{
    public partial class frmQuanLyNhanVien : Form
    {

        string tenDangNhap;
        string chucVu;
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmQuanLyNhanVien(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, System.EventArgs e)
        {
            LoadDataGridView();
            PhanQuyen();

            txtSDT.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
        }

        void PhanQuyen()
        {
            rdoNhanVien_Them.Checked = true;
            if (frmMain.quyen.Trim()=="QUANLI")
            {
                rdoGiamDoc.Enabled = false;
                rdoGiamDoc_them.Enabled = false;
                rdoQuanLy.Enabled = false;
                rdoQuanLy_Them.Enabled = false;
                rdoNhanVien.Enabled = false;
            }
        }

        void HienThiPhanQuyen(string quyen)
        {
            if(frmMain.quyen.Trim()=="QUANLI"&& (quyen.Trim()=="GIAMDOC"||quyen.Trim()=="QUANLI"))
            {
                txtDiaChi.Enabled = false;
                txtEmail.Enabled = false;
                txtHoTen.Enabled = false;
                txtSDT.Enabled = false;
            }
            else
            {
                txtDiaChi.Enabled = true;
                txtEmail.Enabled = true;
                txtHoTen.Enabled = true;
                txtSDT.Enabled = true;
            }
        }

        void LoadDataGridView()
        {
            dgvDanhSachTaiKhoan.DataSource = TaiKhoanBLL.GetTaiKhoan();
            string[] columns = { "TENDANGNHAP", "HOTEN", "SDT"};
            Utility.ControlFormat.DataGridViewFormat(dgvDanhSachTaiKhoan, columns);

            dgvDanhSachTaiKhoan.Columns[0].HeaderText = "Tài khoản";
            dgvDanhSachTaiKhoan.Columns[1].HeaderText = "Họ tên";
            dgvDanhSachTaiKhoan.Columns[2].HeaderText = "SĐT";
        }

        private void dgvDanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    tenDangNhap = dgvDanhSachTaiKhoan.Rows[e.RowIndex].Cells["TENDANGNHAP"].Value.ToString();

                    txtHoTen.Text = dgvDanhSachTaiKhoan.Rows[e.RowIndex].Cells["HOTEN"].Value.ToString().Trim();
                    txtSDT.Text = dgvDanhSachTaiKhoan.Rows[e.RowIndex].Cells["SDT"].Value.ToString().Trim();
                    txtDiaChi.Text = dgvDanhSachTaiKhoan.Rows[e.RowIndex].Cells["DIACHI"].Value.ToString().Trim();
                    txtEmail.Text = dgvDanhSachTaiKhoan.Rows[e.RowIndex].Cells["EMAIL"].Value.ToString().Trim();
                    
                    chucVu = dgvDanhSachTaiKhoan.Rows[e.RowIndex].Cells["QUYEN"].Value.ToString().Trim();
                    if (chucVu.Trim() == "NHANVIEN")
                        rdoNhanVien.Checked = true;
                    else if (chucVu.Trim() == "QUANLI")
                        rdoQuanLy.Checked = true;
                    else
                        rdoGiamDoc.Checked = true;

                    HienThiPhanQuyen(chucVu);
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoanBLL.XoaTaiKhoan(tenDangNhap);
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadDataGridView();
            }
            catch {; }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.Equals(txtMatKhau.Text, txtMatKhauNhapLai.Text)&&!string.IsNullOrEmpty(txtTenTaiKhoan.Text)&&!string.IsNullOrEmpty(txtMatKhau.Text))
            {
                if (txtMatKhau.Text.Length >= 4 && txtMatKhau.Text.Length <= 20)
                    if (txtTenTaiKhoan.Text.Length == 0 || txtTenTaiKhoan.Text.Length < 20)
                        try
                        {
                            string quyen = "";
                            if (rdoGiamDoc_them.Checked)
                                quyen = "GIAMDOC";
                            else if (rdoNhanVien_Them.Checked)
                                quyen = "NHANVIEN";
                            else if (rdoQuanLy_Them.Checked)
                                quyen = "QUANLI";
                            TaiKhoan taiKhoan = new TaiKhoan();
                            taiKhoan.DiaChi = txtDiaChi_them.Text;
                            taiKhoan.Email = txtEmail_them.Text;
                            taiKhoan.HoTen = txtHoTen_them.Text;
                            taiKhoan.MatKhau = txtMatKhau.Text;
                            taiKhoan.Quyen = quyen;
                            taiKhoan.SDT = txtSDT_them.Text;
                            taiKhoan.TenDangNhap = txtTenTaiKhoan.Text;

                            TaiKhoanBLL.ThemTaiKhoan(taiKhoan);
                            MessageBox.Show("Thêm tài khoản thành công");
                            txtDiaChi_them.Clear();
                            txtEmail_them.Clear();
                            txtHoTen_them.Clear();
                            txtMatKhau.Clear();
                            txtMatKhauNhapLai.Clear();
                            txtSDT_them.Clear();
                            txtTenTaiKhoan.Clear();
                            LoadDataGridView();
                        }
                        catch
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ tên đăng nhập và mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    else
                        MessageBox.Show("Tên tài khoản phải nhỏ hơn 20 kí tự", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Mật khẩu phải từ 4-20 kí tự", "Thông báo", MessageBoxButtons.OK); ;
            }
            else
            {
                if (string.IsNullOrEmpty(txtTenTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
                    MessageBox.Show("Vui lòng điền đầy đủ tên đăng nhập và mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else //if (string.Equals(txtMatKhau.Text, txtMatKhauNhapLai.Text))
                    MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                txtMatKhau.Clear();
                txtMatKhauNhapLai.Clear();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < txtSDT.Text.Length; i++)
                {
                    if(((int)txtSDT.Text[i]<48 && (int)txtSDT.Text[i] != 32) || (int)txtSDT.Text[i] > 57)
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại số điện thoại", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }

                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.DiaChi = txtDiaChi.Text;
                taiKhoan.Email = txtEmail.Text;
                taiKhoan.HoTen = txtHoTen.Text;
                taiKhoan.SDT = txtSDT.Text;
                taiKhoan.TenDangNhap = tenDangNhap;

                TaiKhoanBLL.CapNhatTaiKhoanNhanVien(taiKhoan);
                MessageBox.Show("Thay đổi thông tin tài khoản nhân viên thành công!", "Thông báo");
                LoadDataGridView();
            }
            catch {; }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }
    }
}
