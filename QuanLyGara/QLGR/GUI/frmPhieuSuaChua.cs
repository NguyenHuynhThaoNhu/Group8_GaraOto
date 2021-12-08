using System;
using System.Data;
using System.Windows.Forms;
using QLGR.BusinessLayer;
using QLGR.Entities;
using DevComponents.DotNetBar;

namespace QLGR.Presentation
{
    public partial class frmPhieuSuaChua : Form
    {
        public string bienSo;
        public string maPSC;

        private string maCTPSC;
        private decimal thanhTien = 0;
        private decimal tongTien = 0;
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmPhieuSuaChua(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmPhieuSuaChua_Load(object sender, EventArgs e)
        {
            txtBienSo.Text = bienSo;
            cboNoiDung.Text = "";
            txtTongTien.Text = "0";
            txtMaPhieu.Text = maPSC;
            GetListTienCong();
            GetListPhuTung();
        }

        #region Load data vao combobox
        //Load cboNoiDung
        private void GetListTienCong()
        {
            DataTable dt = TienCongBLL.ListNoiDung();
            cboNoiDung.DataSource = dt;
            cboNoiDung.DisplayMember = "NOIDUNG";
            cboNoiDung.ValueMember = "NOIDUNG";
            cboNoiDung.Text = "";
        }

        //Get list để đổ vào combo box
        private void GetListPhuTung()
        {
            DataTable dt = PhuTungBLL.ListPhuTung();
            cboPhuTung.DataSource = dt;
            cboPhuTung.DisplayMember = "TENPT";
            cboPhuTung.ValueMember = "MAPT";
            cboPhuTung.Text = "";
        }

        #endregion

        private void cboNoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTienCong.Text = String.Format("{0:0,0}", TienCongBLL.GetTienCong(cboNoiDung.SelectedValue.ToString()));
        }

        private void cboPhuTung_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = String.Format("{0:0,0}", PhuTungBLL.GetTienPhuTung(cboPhuTung.SelectedValue.ToString()));
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal donGia;
                decimal soLuong;
                decimal tienCong;
                decimal thanhTien = 0;
                if (!String.IsNullOrEmpty(txtDonGia.Text) && !String.IsNullOrEmpty(txtSL.Text))
                {
                    tienCong = Convert.ToDecimal(txtTienCong.Text);
                    donGia = Convert.ToDecimal(txtDonGia.Text);
                    soLuong = Convert.ToDecimal(txtSL.Text);
                    thanhTien = donGia * soLuong + tienCong;
                    txtThanhTien.Text = string.Format("{0:0,0}", decimal.Parse(thanhTien.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng số lượng!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal donGia;
                decimal soLuong;
                decimal tienCong;
                decimal thanhTien = 0;
                if (!String.IsNullOrEmpty(txtDonGia.Text) && !String.IsNullOrEmpty(txtSL.Text))
                {
                    tienCong = Convert.ToDecimal(txtTienCong.Text);
                    donGia = Convert.ToDecimal(txtDonGia.Text);
                    soLuong = Convert.ToDecimal(txtSL.Text);
                    thanhTien = donGia * soLuong + tienCong;
                    txtThanhTien.Text = string.Format("{0:0,0}", decimal.Parse(thanhTien.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            string maBCT = BaoCaoTonBLL.GetMaBCT(today.Month, today.Year);
            string maCTBCT = ChiTietBaoCaoTonBLL.getMaCTBCT(maBCT, cboPhuTung.Text);
            ChiTietBaoCaoTon chitiet = new ChiTietBaoCaoTon();

            chitiet.MaBCT = maBCT;
            chitiet.MaCTBCT = maCTBCT;
            chitiet.TenPT = cboPhuTung.Text;
            chitiet.TonCuoi = int.Parse(txtSL.Text);
            chitiet.PhatSinh = 0;
            chitiet.TonDau = 0;
            ChiTietBaoCaoTonBLL.capNhatTonCuoi(chitiet);

            decimal thanhTien = decimal.Parse(txtThanhTien.Text);
            txtTongTien.Text = string.Format("{0:0,0}", decimal.Parse(tongTien.ToString()));

            string maCTPSC = ChiTietPhieuSuaChuaBLL.AutoMACTSC();
            ChiTietPhieuSuaChua ctpsc = new ChiTietPhieuSuaChua(maCTPSC, txtMaPhieu.Text, cboPhuTung.SelectedValue.ToString(), int.Parse(txtSL.Text), cboNoiDung.Text, decimal.Parse(txtThanhTien.Text));

            int soLuongPTTon = int.Parse(PhuTungBLL.LaySoLuongPhuTung(cboPhuTung.Text));
            try
            {
                if (soLuongPTTon < int.Parse(txtSL.Text))
                    MessageBox.Show("Số lượng phụ tùng trong kho không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    ChiTietPhieuSuaChuaBLL.ThemCTPSC(ctpsc);
                    GetDataGridView();
                    tongTien += thanhTien;
                    txtTongTien.Text = string.Format("{0:0,0}", decimal.Parse(tongTien.ToString()));
                    MessageBox.Show("Thêm chi tiết thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtDonGia.Clear();
            txtSL.Clear();
            txtThanhTien.Clear();
            txtTienCong.Clear();
            cboNoiDung.Text = "";
            cboPhuTung.Text = "";
        }

        private void GetDataGridView()
        {
            dgvCTPSC.DataSource = ChiTietPhieuSuaChuaBLL.GetList(txtMaPhieu.Text);
            string[] columns = { "MaPhuTung", "SoLuong", "NoiDung", "ThanhTien" };
            Utility.ControlFormat.DataGridViewFormat(dgvCTPSC, columns);
            dgvCTPSC.Columns[2].HeaderText = "Mã phụ tùng";
            dgvCTPSC.Columns[3].HeaderText = "Số lượng";
            dgvCTPSC.Columns[4].HeaderText = "Thành tiền";
            dgvCTPSC.Columns[5].HeaderText = "Đơn giá";
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            if(dgvCTPSC.RowCount == 0)
            {
                PhieuSuaChuaBLL.XoaPhieuSuaChua(txtMaPhieu.Text);
            }
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            frmInPhieuSuaChua _frmInPhieuSuaChua = new frmInPhieuSuaChua();
            frmInPhieuSuaChua.maPSC = txtMaPhieu.Text;
            frmInPhieuSuaChua.bienSo = txtBienSo.Text;
            _frmInPhieuSuaChua.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maCTPSC))
                MessageBox.Show("Không có chi tiết phiếu sửa chữa để xóa", "Thông báo", MessageBoxButtons.OK);
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa chi tiết này không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        ChiTietPhieuSuaChuaBLL.XoaCTPSC(maCTPSC);
                        MessageBox.Show("Xóa chi tiết thành công!", "Thông báo");
                        tongTien -= thanhTien;
                        txtTongTien.Text = tongTien.ToString();
                        thanhTien = 0;
                        maCTPSC = null;
                        GetDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dgvCTPSC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    maCTPSC = dgvCTPSC.Rows[e.RowIndex].Cells[0].Value.ToString();
                    thanhTien = decimal.Parse(dgvCTPSC.Rows[e.RowIndex].Cells[5].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
