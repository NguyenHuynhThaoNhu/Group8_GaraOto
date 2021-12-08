using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace QLGR.Presentation
{
    public partial class frmInPhieuThuTien : Form
    {
        string tenChuXe, bienSo;
        decimal tienNo;
        decimal tienTra;
        decimal tienNoConLai;
        public frmInPhieuThuTien()
        {
            InitializeComponent();
        }

        public void GetThongTin(string _tenChuXe,string _bienSo, decimal _tienNo, decimal _tienTra, decimal _tienNoConLai)
        {
            bienSo = _bienSo;
            tenChuXe = _tenChuXe;
            tienNo = _tienNo;
            tienTra = _tienTra;
            tienNoConLai=_tienNoConLai;
        }

        void FillValueToReport()
        {
            ReportParameter[] allPar = new ReportParameter[5];
            ReportParameter _tenChuXe = new ReportParameter("TenChuXe",tenChuXe);
            ReportParameter _tienNo = new ReportParameter("TienNo", tienNo.ToString());
            ReportParameter _bienSo = new ReportParameter("BienSo", bienSo);
            ReportParameter _tienTra = new ReportParameter("TienTra", tienTra.ToString());
            ReportParameter _noConLai = new ReportParameter("TienNoConLai", tienNoConLai.ToString());

            allPar[0] = _tenChuXe;
            allPar[1] = _bienSo;
            allPar[2] = _tienNo;
            allPar[3] = _tienTra;
            allPar[4] = _noConLai;

            reportViewer1.LocalReport.SetParameters(allPar); // set parameter array
        }

        private void frmInPhieuThuTien_Load(object sender, EventArgs e)
        {
            FillValueToReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
