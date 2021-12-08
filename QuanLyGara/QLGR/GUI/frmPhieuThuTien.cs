using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLGR.Entities;
using QLGR.BusinessLayer;

namespace QLGR.Presentation
{
    public partial class frmPhieuThuTien : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        decimal tienNo;
        decimal tienTra, tienNoConLai;

        public frmPhieuThuTien(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
            btnInPhieu.Enabled = false;
        }

        private void frmPhieuThuTien_Load(object sender, EventArgs e)
        {
            tienNo = 0;
            txtTienNoConLai.Text = txtTienNo.Text;
        }

        public void GetThongTinXe(string bienSo)
        {
            txtSoPhieu.Text = PhieuThuTienBLL.AutoMACTSC();
            txtBienSo.Text = bienSo;
            DataTable dt = XeBLL.GetThongTinXe(bienSo);
            txtChuXe.Text = dt.Rows[0]["TENCHUXE"].ToString();
            txtTienNo.Text = String.Format("{0:0,0}", decimal.Parse(dt.Rows[0]["TIENNO"].ToString()));

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void txtTienTra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tienNoConLai = decimal.Parse(txtTienNo.Text) - decimal.Parse(txtTienTra.Text);
                if (!string.IsNullOrEmpty(txtTienTra.Text))
                    txtTienNoConLai.Text = string.Format("{0:0,0}", decimal.Parse(tienNoConLai.ToString()));
                if (tienNoConLai <0)
                {
                    MessageBox.Show("Tiền thu không được lớn hơn tiền nợ", "Thông báo", MessageBoxButtons.OK);
                    txtTienTra.Clear();
                    tienNoConLai = decimal.Parse(txtTienNo.Text);
                    txtTienNoConLai.Text = string.Format("{0:0,0}", decimal.Parse(tienNoConLai.ToString()));
                }
            }
            catch(Exception ex)
            {
                if (!string.IsNullOrEmpty(txtTienTra.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng số lượng!", "Thông báo", MessageBoxButtons.OK);
                    txtTienTra.Clear();
                    tienNoConLai = decimal.Parse(txtTienNo.Text);
                    txtTienNoConLai.Text = string.Format("{0:0,0}", decimal.Parse(tienNoConLai.ToString()));
                }
            }
        }

        private void btnTraNo_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(txtTienTra.Text) <= 0)
            {
                MessageBox.Show("Nhập số tiền lớn hơn 0VND", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tienTra = decimal.Parse(txtTienTra.Text);
                tienNo = decimal.Parse(txtTienNo.Text);

                if (tienTra > tienNo)
                {
                    MessageBox.Show("Tiền khách trả không được lớn hơn tiền nợ", "Thông báo", MessageBoxButtons.OK);
                    txtTienTra.Clear();
                    txtTienNoConLai.Clear();
                }
                else
                {
                    PhieuThuTien phieuThuTien = new PhieuThuTien(txtSoPhieu.Text, txtBienSo.Text, DateTime.Now, tienTra);
                    try
                    {
                        PhieuThuTienBLL.NhapPhieuThuTien(phieuThuTien);
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }

                    ThayDoiTienNo _tienNo = new ThayDoiTienNo();
                    _tienNo.BienSo = txtBienSo.Text;
                    _tienNo.TienNo = decimal.Parse(txtTienNoConLai.Text);
                    ThayDoiTienNoBLL.ThayDoiTienNo(_tienNo);
                    MessageBox.Show("Thay đổi tiền nợ thành công!", "Thông báo", MessageBoxButtons.OK);
                    txtTienNo.Text = txtTienNoConLai.Text;
                    txtTienTra.Clear();
                    txtTienNoConLai.Clear();
                    btnInPhieu.Enabled = true;
                }
            }
        }

     

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            frmInPhieuThuTien _frmInPhieuThuTien = new frmInPhieuThuTien();
            _frmInPhieuThuTien.GetThongTin(txtChuXe.Text, txtBienSo.Text, this.tienNo, this.tienTra, this.tienNoConLai);
            _frmInPhieuThuTien.ShowDialog();
        }
    }
}
