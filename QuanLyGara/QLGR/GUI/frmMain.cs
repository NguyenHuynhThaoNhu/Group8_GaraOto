using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QLGR.Presentation
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        FormCollection allForm = Application.OpenForms;

        public static string quyen;

        frmLapPhieuSuaChua _frmLapPhieuSuaChua;
        string bienSo;

        public frmMain()
        {
            InitializeComponent();
            _frmLapPhieuSuaChua = new frmLapPhieuSuaChua(tabControl);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label.Text = label.Text + DateTime.Now.ToString();
            PhanQuyen();
        }

        void PhanQuyen()
        {
            if (quyen.Trim() == "QUANLI")
            {
                btnTiepNhan.Enabled = false;
                btnLapPhieuSuaChua.Enabled = false;
                btnLapPhieuThuTien.Enabled = false;
            }
            else if (quyen.Trim() == "NHANVIEN")
            {
                btnBaoCaoDoanhSo.Enabled = false;
                btnPhuTungTon.Enabled = false;
                btnTienCong.Enabled = false;
                btnPhuTung.Enabled = false;
                btnQuyDinh.Enabled = false;
                btnQuanLyNhanVien.Enabled = false;
                btnHieuXe.Enabled = false;
            }
        }
        #region Ribbon button
        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Tiếp nhận xe"))
            {
                TabItem tab = tabControl.CreateTab("Tiếp nhận xe");
                tab.PredefinedColor = eTabItemColor.Yellow;
                frmTiepNhanXe _frmTiepNhanXe = new frmTiepNhanXe(tabControl, tab);
                _frmTiepNhanXe.TopLevel = false;
                _frmTiepNhanXe.Dock = DockStyle.Fill;
                _frmTiepNhanXe.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmTiepNhanXe);
                _frmTiepNhanXe.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Tìm kiếm"))
            {
                TabItem tab = tabControl.CreateTab("Tìm kiếm");
                tab.PredefinedColor = eTabItemColor.Yellow;
                frmTimKiem _frmTimKiem = new frmTimKiem(tabControl, tab);
                _frmTimKiem.TopLevel = false;
                _frmTimKiem.Dock = DockStyle.Fill;
                _frmTimKiem.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmTimKiem);
                _frmTimKiem.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnLapPhieuSuaChua_Click(object sender, EventArgs e)
        {
            try
            {
                _frmLapPhieuSuaChua.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLapPhieuThuTien_Click(object sender, EventArgs e)
        {
            /*if (!CheckOpenedTabs("Phiếu thi tiền"))
            {
                TabItem tab = tabControl.CreateTab("Phiếu thi tiền");
                tab.PredefinedColor = eTabItemColor.Yellow;

                frmPhieuThuTien _frmPhieuThuTien = new frmPhieuThuTien(tabControl, tab);
                _frmPhieuThuTien.GetThongTinXe(bienSo);
                _frmPhieuThuTien.TopLevel = false;
                _frmPhieuThuTien.Dock = DockStyle.Fill;
                _frmPhieuThuTien.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmPhieuThuTien);
                _frmPhieuThuTien.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;*/
            frmLapPhieuThuTien _frmLapPhieuThuTien = new frmLapPhieuThuTien(tabControl);
            _frmLapPhieuThuTien.ShowDialog();

        }

        private void btnTienCong_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Tiền công"))
            {
                TabItem tab = tabControl.CreateTab("Tiền công");
                tab.PredefinedColor = eTabItemColor.Yellow;
                frmTienCong _frmTienCong = new frmTienCong(tabControl, tab);
                _frmTienCong.TopLevel = false;
                _frmTienCong.Dock = DockStyle.Fill;
                _frmTienCong.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmTienCong);
                _frmTienCong.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnPhuTung_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Phụ tùng"))
            {
                TabItem tab = tabControl.CreateTab("Phụ tùng");
                tab.PredefinedColor = eTabItemColor.Yellow;
                frmPhuTung _frmPhuTung = new frmPhuTung(tabControl, tab);
                _frmPhuTung.TopLevel = false;
                _frmPhuTung.Dock = DockStyle.Fill;
                _frmPhuTung.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmPhuTung);
                _frmPhuTung.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Quy định"))
            {
                TabItem tab = tabControl.CreateTab("Quy định");
                tab.PredefinedColor = eTabItemColor.Yellow;
                frmThayDoiQuyDinh _frmQuyDinh = new frmThayDoiQuyDinh(tabControl, tab);
                _frmQuyDinh.TopLevel = false;
                _frmQuyDinh.Dock = DockStyle.Fill;
                _frmQuyDinh.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmQuyDinh);
                _frmQuyDinh.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Quản lý tài khoản"))
            {
                TabItem tab = tabControl.CreateTab("Quản lý tài khoản");
                tab.PredefinedColor = eTabItemColor.Yellow;
                frmQuanLyNhanVien _frmQuanLyNhanVien = new frmQuanLyNhanVien(tabControl, tab);
                _frmQuanLyNhanVien.TopLevel = false;
                _frmQuanLyNhanVien.Dock = DockStyle.Fill;
                _frmQuanLyNhanVien.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmQuanLyNhanVien);
                _frmQuanLyNhanVien.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }


        private void btnHieuXe_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Hiệu xe"))
            {
                TabItem tab = tabControl.CreateTab("Hiệu xe");
                tab.PredefinedColor = eTabItemColor.Yellow;
                frmHieuXe _frmHieuXe = new frmHieuXe(tabControl, tab);
                _frmHieuXe.TopLevel = false;
                _frmHieuXe.Dock = DockStyle.Fill;
                _frmHieuXe.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmHieuXe);
                _frmHieuXe.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        public bool CheckOpenedTabs(string name)
        {
            for (int i = 0; i < tabControl.Tabs.Count; i++)
            {
                if (tabControl.Tabs[i].Text == name)
                {
                    tabControl.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        #endregion

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            label.Text = "Today : " + DateTime.Now.ToString();
        }

        private void btnBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhSo _frmBaoCaoDoanhSo = new frmBaoCaoDoanhSo();
            _frmBaoCaoDoanhSo.Show();
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan _frmThongTinTaiKhoan = new frmThongTinTaiKhoan();
            _frmThongTinTaiKhoan.ShowDialog();
        }

        private void btnThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmThayDoiMatKhau _frmThayDoiMatKhau = new frmThayDoiMatKhau();
            _frmThayDoiMatKhau.ShowDialog();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }

        public void DangXuat()
        {
            this.Hide();
            new frmDangNhap().ShowDialog();
            this.Close();
        }

        private void btnPhuTungTon_Click(object sender, EventArgs e)
        {
            frmBaoCaoVTPT _frmBaoCaoVTPT = new frmBaoCaoVTPT();
            _frmBaoCaoVTPT.ShowDialog();
        }

        private void btnThongTinPhanMem_Click(object sender, EventArgs e)
        {
            frmThongTinPhanMem _frmThongTinPhanMem = new frmThongTinPhanMem();
            _frmThongTinPhanMem.ShowDialog();
        }

        private void btnHuongDanSD_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + @"\HDSD.doc";
            System.Diagnostics.Process.Start(path);
        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
