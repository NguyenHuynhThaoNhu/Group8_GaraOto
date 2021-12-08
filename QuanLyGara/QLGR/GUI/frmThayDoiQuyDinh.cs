using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLGR.BusinessLayer;
using QLGR.Entities;
using DevComponents.DotNetBar;

namespace QLGR.Presentation
{
    public partial class frmThayDoiQuyDinh : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmThayDoiQuyDinh(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            txtSoXeSuaChuaToiDa.Text = QuyDinhBLL.GetQuyDinh().SoXeSuaChuaToiDa.ToString();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            try
            {
                QuyDinh quyDinh = new QuyDinh(int.Parse(txtSoXe.Text));
                if (!string.IsNullOrEmpty(txtSoXe.Text))
                {
                    QuyDinhBLL.ThayDoiQuyDinh(quyDinh);
                    txtSoXeSuaChuaToiDa.Text = QuyDinhBLL.GetQuyDinh().SoXeSuaChuaToiDa.ToString();
                    txtSoXe.Clear();
                    MessageBox.Show("Số xe sửa chữa tối đa trong ngày đã được thay đổi thành " + txtSoXe.Text, "Thông báo", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Vui lòng nhập số lượng xe", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập số lượng", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }
    }
}
