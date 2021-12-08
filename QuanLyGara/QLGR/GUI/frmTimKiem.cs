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
using QLGR.Entities;

namespace QLGR.Presentation
{
    public partial class frmTimKiem : Form
    {
        public static string bienSo;

        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmTimKiem(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void GetDataGridView()
        {
            dgvTimKiem.DataSource = XeBLL.GetList();
            string[] columns = { "BienSo", "HieuXe", "HoTenChuXe", "TienNo" };
            Utility.ControlFormat.DataGridViewFormat(dgvTimKiem, columns);
            dgvTimKiem.Columns[0].HeaderText = "Biển số";
            dgvTimKiem.Columns[1].HeaderText = "Hiệu xe";
            dgvTimKiem.Columns[2].HeaderText = "Tên chủ xe";
            dgvTimKiem.Columns[7].HeaderText = "Tiền nợ";
        }

        private void dgvTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex != -1 && e.RowIndex != dgvTimKiem.RowCount)
                {
                    string _bienSo = dgvTimKiem.Rows[e.RowIndex].Cells["BienSo"].Value.ToString();
                    bienSo = _bienSo;
                    GetThongTinXe(_bienSo);
                    GetDataGrigViewCTPSC(_bienSo);
                    GetDataGridViewPTT(_bienSo);
                    btnCapNhat.Enabled = true;
                    btnXoa.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void GetDataGrigViewCTPSC(string bienSo)
        {
            List<ChiTietPhieuSuaChua> listChiTiet = PhieuSuaChuaBLL.GetCTPSC(bienSo);
            dgvCTPSC.DataSource = listChiTiet;
            string[] columns = {"MaChiTietPhieuSuaChua", "MaPhuTung", "SoLuong", "NoiDung", "ThanhTien"};
            Utility.ControlFormat.DataGridViewFormat(dgvCTPSC, columns);
            dgvCTPSC.Columns[0].HeaderText = "Mã chi tiết";
            dgvCTPSC.Columns[2].HeaderText = "Mã phụ tùng";
            dgvCTPSC.Columns[3].HeaderText = "Số lượng";
            dgvCTPSC.Columns[4].HeaderText = "Nội dung";
            dgvCTPSC.Columns[5].HeaderText = "Thành tiền";
        }

        private void GetDataGridViewPTT(string bienSo)
        {
            dgvPTT.DataSource = PhieuThuTienBLL.GetListPTT(bienSo);
            string[] columns = {"MAPTT", "NGAYTHU", "SOTIENTHU"};
            Utility.ControlFormat.DataGridViewFormat(dgvPTT, columns);
            dgvPTT.Columns[0].HeaderText = "Mã phiếu thu tiền";
            dgvPTT.Columns[2].HeaderText = "Ngày thu";
            dgvPTT.Columns[3].HeaderText = "Số tiền thu";
        }

        private void GetThongTinXe(string bienSo)
        {
            DataTable dt = XeBLL.GetThongTinXe(bienSo);
            txtBienSo.Text = dt.Rows[0]["BIENSO"].ToString();
            txtChuXe.Text = dt.Rows[0]["TENCHUXE"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
            txtDienThoai.Text = dt.Rows[0]["DIENTHOAI"].ToString();
            txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
            txtHieuXe.Text = dt.Rows[0]["HIEUXE"].ToString();
            txtNgayTiepNhan.Text = dt.Rows[0]["NGAYTIEPNHAN"].ToString();
            txtTienNo.Text = dt.Rows[0]["TIENNO"].ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtTimKiem.Text != "")
                {
                    dgvTimKiem.DataSource = XeBLL.TimKiemXe(txtTimKiem.Text);
                    labelSL.Text = dgvTimKiem.RowCount.ToString();
                }
                else
                {
                    MessageBox.Show("Nhập từ khóa tìm kiếm", "Thông báo");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Xe xe = new Xe();
                xe.HoTenChuXe = txtChuXe.Text;
                xe.BienSo = txtBienSo.Text;
                xe.DienThoai = txtDienThoai.Text;
                xe.DiaChi = txtDiaChi.Text;
                xe.Email = txtEmail.Text;

                XeBLL.CapNhatThongTinXe(xe);
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                GetDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "")
            {
                GetDataGridView();
                labelSL.Text = "0";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(decimal.Parse(txtTienNo.Text) > 0)
                {
                    MessageBox.Show("Xe phải trả hết tiền nợ mới được xóa ra khỏi xưởng");
                    return;
                }

                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa xe này ra khỏi xưởng không?", "Thông báo", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    XeBLL.XoaXe(txtBienSo.Text);
                    MessageBox.Show("Xe đã xóa thành công!", "Thông báo");

                    txtBienSo.Clear();
                    txtHieuXe.Clear();
                    txtNgayTiepNhan.Clear();
                    txtChuXe.Clear();
                    txtDiaChi.Clear();
                    txtDienThoai.Clear();
                    txtEmail.Clear();
                    txtTienNo.Clear();

                    GetDataGridView();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
