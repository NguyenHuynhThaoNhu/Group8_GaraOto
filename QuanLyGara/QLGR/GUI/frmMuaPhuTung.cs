using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLGR.Presentation
{
    public partial class frmMuaPhuTung : Form
    {
        TextBox txtSoLuong;

        public frmMuaPhuTung(TextBox _txtSL)
        {
            InitializeComponent();
            txtSoLuong = _txtSL;
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            if (txtSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng phụ tùng cần mua", "Thông báo");
            }

            int soLuong = int.Parse(txtSoLuong.Text);
            try
            {
                soLuong += int.Parse(txtSL.Text);
                txtSoLuong.Text = soLuong.ToString();
                MessageBox.Show("Mua thành công!", "Thông báo");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Số lượng phải là một số nguyên", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
