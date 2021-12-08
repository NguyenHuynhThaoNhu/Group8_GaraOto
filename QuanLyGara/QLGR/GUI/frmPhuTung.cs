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
    public partial class frmPhuTung : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmPhuTung(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        void GetDataGridView()
        {
            dgvVTPT.DataSource = PhuTungBLL.ListPhuTung();
            string[] columns = { "MAPT", "TENPT", "DONGIA", "SL" };
            Utility.ControlFormat.DataGridViewFormat(dgvVTPT, columns);

            dgvVTPT.Columns[0].HeaderText = "Mã phụ tùng";
            dgvVTPT.Columns[1].HeaderText = "Tên phụ tùng";
            dgvVTPT.Columns[2].HeaderText = "Số lượng";
            dgvVTPT.Columns[3].HeaderText = "Đơn giá";
        }

        private void frmPhuTung_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void dgvVTPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    txtMaVTPT.Text = dgvVTPT.Rows[e.RowIndex].Cells["MAPT"].Value.ToString();
                    txtTenPT.Text = dgvVTPT.Rows[e.RowIndex].Cells["TENPT"].Value.ToString();
                    txtSoLuong.Text = dgvVTPT.Rows[e.RowIndex].Cells["SL"].Value.ToString();
                    txtDonGia.Text = String.Format("{0:0,0}", decimal.Parse(dgvVTPT.Rows[e.RowIndex].Cells["DONGIA"].Value.ToString()));

                    txtTenPT.ReadOnly = false;
                    txtDonGia.ReadOnly = false;
                    btnThemSL.Enabled = true;
                    btnThayDoi.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtTenPT.Clear();
            txtDonGia.Clear();

            txtTenPT.ReadOnly = false;
            txtDonGia.ReadOnly = false;

            txtSoLuong.Text = "0";
            txtMaVTPT.Text = PhuTungBLL.MakeID();

            btnThayDoi.Enabled = false;
            btnXoa.Enabled = false;
            btnThemSL.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenPT.Text == "")
                {
                    MessageBox.Show("Tên phụ tùng không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (txtDonGia.Text == "")
                {
                    MessageBox.Show("Đơn giá không được để trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                PhuTung phuTung = new PhuTung();
                phuTung.MaPhuTung = txtMaVTPT.Text;
                phuTung.TenPhuTung = txtTenPT.Text;
                phuTung.DonGia = decimal.Parse(txtDonGia.Text);

                PhuTungBLL.ThayDoiPhuTung(phuTung);
                GetDataGridView();
                MessageBox.Show("Thay đổi phụ tùng thành công", "Thông báo");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenPT.Text == "")
            {
                MessageBox.Show("Tên phụ tùng không được để trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Đơn giá không được để trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                PhuTung phuTung = new PhuTung();
                phuTung.MaPhuTung = txtMaVTPT.Text;
                phuTung.TenPhuTung = txtTenPT.Text;
                phuTung.SoLuong = int.Parse(txtSoLuong.Text);
                phuTung.DonGia = decimal.Parse(txtDonGia.Text);

                PhuTungBLL.ThemPhuTung(phuTung);
                MessageBox.Show("Thêm phụ tùng thành công!", "Thông báo", MessageBoxButtons.OK);
                GetDataGridView();
                txtMaVTPT.Text = PhuTungBLL.MakeID();
                txtSoLuong.Text = "0";
                txtTenPT.Clear();
                txtDonGia.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnThemSL_Click(object sender, EventArgs e)
        {
            int soluong = int.Parse(txtSoLuong.Text);
            frmMuaPhuTung form = new frmMuaPhuTung(txtSoLuong);
            form.ShowDialog();
            if (btnThayDoi.Enabled)
            {
                PhuTung phuTung = new PhuTung();
                phuTung.MaPhuTung = txtMaVTPT.Text;
                phuTung.TenPhuTung = txtTenPT.Text;
                phuTung.SoLuong = int.Parse(txtSoLuong.Text);

                //cap nhat phat sinh
                DateTime today = DateTime.Now;
                string maBCT = BaoCaoTonBLL.GetMaBCT(today.Month, today.Year);

                if (maBCT == "")
                {
                    BaoCaoTon baocao = new BaoCaoTon();

                    baocao.MaBCT = BaoCaoTonBLL.AutoMABCT();
                    maBCT = baocao.MaBCT;
                    baocao.Thang = today.Month;
                    baocao.Nam = today.Year;
                    BaoCaoTonBLL.ThemBC(baocao);
                }

                string maCTBCT = ChiTietBaoCaoTonBLL.getMaCTBCT(maBCT, phuTung.TenPhuTung);
                ChiTietBaoCaoTon chitiet = new ChiTietBaoCaoTon();

                chitiet.MaBCT = maBCT;
                chitiet.MaCTBCT = maCTBCT;
                chitiet.TenPT = phuTung.TenPhuTung;
                chitiet.TonCuoi = 0;
                chitiet.PhatSinh = int.Parse(txtSoLuong.Text) - soluong;
                chitiet.TonDau = 0;
                ChiTietBaoCaoTonBLL.capNhatPhatSinh(chitiet);

                PhuTungBLL.ThayDoiSoLuongPhuTung(phuTung);
                GetDataGridView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa phụ tùng này không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (PhuTungBLL.XoaPhuTung(txtMaVTPT.Text))
                    {
                        MessageBox.Show("Xóa phụ tùng thành công!", "Thông báo");
                        GetDataGridView();
                        txtMaVTPT.Clear();
                        txtDonGia.Clear();
                        txtSoLuong.Clear();
                        txtTenPT.Clear();
                        btnXoa.Enabled = false;
                        btnThayDoi.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa phụ tùng vì nó đang được sử dụng", "Thông báo");
                    }
                }
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

        
    }
}
