using System;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace QLGR.Presentation
{
    public partial class frmInPhieuSuaChua : Form
    {
        public static string bienSo;

        public static string maPSC;

        public frmInPhieuSuaChua()
        {
            InitializeComponent();
        }

        private void frmInPhieuSuaChua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSPhieuSuaChua.VW_PHIEUSUAXE' table. You can move, or remove it, as needed.
            //this.vW_PHIEUSUAXETableAdapter.Fill(this.dSPhieuSuaChua.VW_PHIEUSUAXE);
            FillValueToReport();
            this.vW_PHIEUSUAXETableAdapter.FillBy(this.dSPhieuSuaChua.VW_PHIEUSUAXE, maPSC);

            this.reportViewer1.RefreshReport();
        }

        void FillValueToReport()
        {
            ReportParameter[] ThongTin = new ReportParameter[2];

            ReportParameter _bienSo = new ReportParameter("BienSo", bienSo);
            ReportParameter _ngayNhap = new ReportParameter("NgaySuaChua", DateTime.Now.ToShortDateString());

            ThongTin[0] = _bienSo;
            ThongTin[1] = _ngayNhap;

            reportViewer1.LocalReport.SetParameters(ThongTin);

        }
    }
}
