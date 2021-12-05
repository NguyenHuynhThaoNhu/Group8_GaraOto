using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLGR.BusinessLayer;
using DevComponents.DotNetBar;

namespace QLGR.Presentation
{
    public partial class frmTiepNhanXe : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmTiepNhanXe(DevComponents.DotNetBar.TabControl _tabControl,TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmTiepNhanXe_Load(object sender, EventArgs e)
        {
            btnInPhieu.Enabled = false;

            GetDataGridView();
            labNgayNhap.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
            GetSoXeTiepNhan();
            GetListHieuXe();
        }

        public void GetDataGridView()
        {
            dgvXe.DataSource = XeBLL.GetList();
            string[] columns = { "BienSo", "HieuXe", "HoTenChuXe", "TienNo", "NgayNhap" };
            Utility.ControlFormat.DataGridViewFormat(dgvXe, columns);
            dgvXe.Columns[0].HeaderText = "Biển số";
            dgvXe.Columns[1].HeaderText = "Hiệu xe";
            dgvXe.Columns[2].HeaderText = "Chủ xe";
            dgvXe.Columns[7].HeaderText = "Tiền nợ";
            dgvXe.Columns[6].HeaderText = "Ngày nhập";
        }

        //lỗi
        private void GetSoXeTiepNhan()
        {
            int soXe = XeBLL.GetSoXeTiepNhan(DateTime.ParseExact(labNgayNhap.Text, "dd/MM/yyyy", null));
            labSoXeTiepNhan.Text = soXe.ToString();
        }

        private void GetListHieuXe()
        {
            cboHieuXe.DataSource = HieuXeBLL.GetHieuXe();
            cboHieuXe.DisplayMember = "HIEUXE";
            cboHieuXe.ValueMember = "HIEUXE";
            cboHieuXe.Text = "";
        }

        private void btnNhapXuong_Click(object sender, EventArgs e)
        {
            if ((int)QuyDinhBLL.GetQuyDinh().SoXeSuaChuaToiDa > int.Parse(labSoXeTiepNhan.Text))
            {
                Entities.Xe xe = new Entities.Xe(txtBienSo.Text, cboHieuXe.Text, txtHoTenCX.Text, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, DateTime.ParseExact(labNgayNhap.Text, "dd/MM/yyyy", null));
                try
                {
                    if (XeBLL.ThemXe(xe))
                    {
                        btnInPhieu.Enabled = true;
                        MessageBox.Show("Xe đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK);
                        GetDataGridView();
                        GetSoXeTiepNhan();
                    }
                    else
                        MessageBox.Show("Biển số xe đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                { MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
            }
            else
            {
                btnNhapXuong.Enabled = false;
                MessageBox.Show("Số xe sửa chửa trong ngày vượt quá quy định cho phép", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            frmInPhieuTiepNhanXe _frmInPhieuTiepNhanXe = new frmInPhieuTiepNhanXe();
            _frmInPhieuTiepNhanXe.GetThongTinXe(txtHoTenCX.Text, txtDiaChi.Text, txtSDT.Text, txtBienSo.Text, cboHieuXe.Text, labNgayNhap.Text);
            _frmInPhieuTiepNhanXe.ShowDialog();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtBienSo.Clear();
            cboHieuXe.Text = "";
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtHoTenCX.Clear();
            txtSDT.Clear();
        }
    }
}
