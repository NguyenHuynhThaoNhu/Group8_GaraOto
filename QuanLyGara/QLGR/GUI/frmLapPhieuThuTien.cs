using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using QLGR.BusinessLayer;

namespace QLGR.Presentation
{
    public partial class frmLapPhieuThuTien : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;

        public frmLapPhieuThuTien(DevComponents.DotNetBar.TabControl _tabControl)
        {
            InitializeComponent();
            tabControl = _tabControl;
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckOpenedTabs("Phiếu thu tiền"))
                {
                    TabItem tab = tabControl.CreateTab("Phiếu thu tiền");
                    tab.PredefinedColor = eTabItemColor.Yellow;

                    frmPhieuThuTien _frmPhieuThuTien = new frmPhieuThuTien(tabControl, tab);
                    _frmPhieuThuTien.GetThongTinXe(txtBienSo.Text);
                    _frmPhieuThuTien.TopLevel = false;
                    _frmPhieuThuTien.Dock = DockStyle.Fill;
                    _frmPhieuThuTien.StartPosition = FormStartPosition.CenterParent;
                    tab.AttachedControl.Controls.Add(_frmPhieuThuTien);
                    _frmPhieuThuTien.Show();
                    tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
                }
                else
                {
                    MessageBox.Show("Chức năng thu tiền đang được tiến hành", "Thông báo");
                    tabControl.TabIndex = tabControl.Tabs.Count - 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }

            this.Close();
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

        private void txtBienSo_TextChanged(object sender, EventArgs e)
        {
            string bienXe = txtBienSo.Text;
            txtTenChuXe.Text = XeBLL.GetChuXe(bienXe);
            if (txtTenChuXe.Text == "1")
                txtTenChuXe.Clear();
            if (txtTenChuXe.Text.Length == 0)
                btnLapPhieu.Enabled = false;
            else
                btnLapPhieu.Enabled = true;
        }

        private void frmLapPhieuThuTien_Load(object sender, EventArgs e)
        {
            btnLapPhieu.Enabled = false;
            if (!string.IsNullOrEmpty(frmTimKiem.bienSo))
            {
                txtTenChuXe.Text = XeBLL.GetChuXe(frmTimKiem.bienSo);
                txtBienSo.Text = frmTimKiem.bienSo;
                btnLapPhieu.Enabled = true;
            }
        }
    }
}
