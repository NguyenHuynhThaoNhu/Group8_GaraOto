using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLGR.Entities;
using DevComponents.DotNetBar;
using QLGR.BusinessLayer;

namespace QLGR.Presentation
{
    public partial class frmLapPhieuSuaChua : Form
    {
        string bienSo;

        DevComponents.DotNetBar.TabControl tabControl;
        LapPhieuSuaChua thongTinXe;

        public frmLapPhieuSuaChua(DevComponents.DotNetBar.TabControl _tabControl)
        {
            InitializeComponent();
            thongTinXe = new LapPhieuSuaChua();
            tabControl = _tabControl;
        }

        private void LoadThongTinXe()
        {
            txtTenChuXe.Text = thongTinXe.ChuXe;
            txtBienSo.Text = thongTinXe.BienSo;
        }

        private void frmLapPhieuSuaChua_Load(object sender, EventArgs e)
        {
            btnLapPhieu.Enabled = false;
            if (!string.IsNullOrEmpty(frmTimKiem.bienSo))
            {
                this.bienSo = frmTimKiem.bienSo;
                txtTenChuXe.Text = XeBLL.GetChuXe(bienSo);
                txtBienSo.Text = bienSo;
                btnLapPhieu.Enabled = true;
            }  
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckOpenedTabs("Phiếu sửa chữa"))
                {
                    string ngaySuaChua = String.Format("{0:MM/dd/yyyy}", DateTime.Now);
                    string maPSC = PhieuSuaChuaBLL.AutoMAPSC();
                    PhieuSuaChua psc = new PhieuSuaChua(maPSC, txtBienSo.Text, DateTime.Now, 0);
                    PhieuSuaChuaBLL.ThemPhieuSuaChua(psc);

                    TabItem tab = tabControl.CreateTab("Phiếu sửa chữa");
                    tab.PredefinedColor = eTabItemColor.Yellow;
                    frmPhieuSuaChua _frmPhieuSuaChua = new frmPhieuSuaChua(tabControl, tab);
                    _frmPhieuSuaChua.maPSC = maPSC;
                    _frmPhieuSuaChua.bienSo = txtBienSo.Text;
                    _frmPhieuSuaChua.TopLevel = false;
                    _frmPhieuSuaChua.Dock = DockStyle.Fill;
                    _frmPhieuSuaChua.StartPosition = FormStartPosition.CenterParent;
                    _frmPhieuSuaChua.Show();
                    tab.AttachedControl.Controls.Add(_frmPhieuSuaChua);
                    tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
                }
                else
                {
                    MessageBox.Show("Chức năng sửa chữa đang được tiến hành", "Thông báo");
                    tabControl.TabIndex = tabControl.Tabs.Count - 1;
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
