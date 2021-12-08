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
    public partial class frmTienCong : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmTienCong(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmTienCong_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            dgvTienCong.DataSource = TienCongBLL.ListNoiDung();
            string[] columns = { "NOIDUNG", "TIENCONG" };
            Utility.ControlFormat.DataGridViewFormat(dgvTienCong, columns);

            dgvTienCong.Columns[0].HeaderText = "Nội dung";
            dgvTienCong.Columns[0].Width = 300;
            dgvTienCong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTienCong.Columns[1].HeaderText = "Tiền công";
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtNoiDung.ReadOnly = false;

            txtNoiDung.Clear();
            txtTienCong.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNoiDung.Text == "" || txtTienCong.Text == "")
                    MessageBox.Show("Không được để trống tiền công và nội dung", "Thông báo");
                else
                {
                    TienCong tienCong = new TienCong();
                    tienCong.NoiDung = txtNoiDung.Text;
                    tienCong.TienCongXe = int.Parse(txtTienCong.Text);
                    TienCongBLL.ThemTienCong(tienCong);
                    MessageBox.Show("Thêm tiền công thành công", "Thông báo");
                    GetDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTienCong.Text == "")
            {
                MessageBox.Show("Tiền công không được để trống", "Thông báo");
                return;
            }

            try
            {
                TienCong tienCong = new TienCong();
                tienCong.NoiDung = txtNoiDung.Text;
                tienCong.TienCongXe = int.Parse(txtTienCong.Text);
                TienCongBLL.ThayDoiTienCong(tienCong);
                MessageBox.Show("Thay đổi thành công", "Thông báo");
                GetDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void dgvTienCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    txtNoiDung.Text = dgvTienCong.Rows[e.RowIndex].Cells["NOIDUNG"].Value.ToString();
                    txtTienCong.Text = dgvTienCong.Rows[e.RowIndex].Cells["TIENCONG"].Value.ToString();

                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    txtNoiDung.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa tiền công này không?", "Thông báo", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    if (TienCongBLL.XoaTienCong(txtNoiDung.Text))
                    {
                        MessageBox.Show("Xóa tiền công thành công!", "Thông báo");
                        GetDataGridView();
                        txtNoiDung.Clear();
                        txtTienCong.Clear();

                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                    }
                    else
                        MessageBox.Show("Không thể xóa tiền công này vì đang được sử dụng", "Thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }
    }
}
