using System;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace QLGR.Presentation
{
    public partial class frmBaoCaoVTPT : Form
    {
        public frmBaoCaoVTPT()
        {
            InitializeComponent();
        }

        private void frmBaoCaoVTPT_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
                cboThang.Items.Add(i);

            cboThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();

            LoadReport();
        }

        void FillValueToReport()
        {
            ReportParameter[] Date = new ReportParameter[2];
            ReportParameter Thang = new ReportParameter("Thang", cboThang.Text);
            ReportParameter Nam = new ReportParameter("Nam", txtNam.Text);

            Date[0] = Thang;
            Date[1] = Nam;

            reportViewer1.LocalReport.SetParameters(Date);
        }

        void LoadReport()
        {
            FillValueToReport();
            this.vW_BCVTTableAdapter.FillBy(this.dsBaoCaoVT.VW_BCVT, Convert.ToInt32(cboThang.Text), Convert.ToInt32(txtNam.Text));

            this.reportViewer1.RefreshReport();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

    }
}
