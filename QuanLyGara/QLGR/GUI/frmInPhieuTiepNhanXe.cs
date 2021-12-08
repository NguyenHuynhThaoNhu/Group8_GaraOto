using System;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using QLGR.Entities;
namespace QLGR.Presentation
{
    public partial class frmInPhieuTiepNhanXe : Form
    {
        private Xe xe = new Xe();
        string ngayTiepNhan = DateTime.Now.ToShortDateString();

        public frmInPhieuTiepNhanXe()
        {
            InitializeComponent();
        }

        private void frmInPhieuTiepNhanXe_Load(object sender, EventArgs e)
        {
            FillValueToReport();
            this.reportViewer1.RefreshReport();
        }

        public void GetThongTinXe(string tenChuXe, string diaChi, string sdt, string bienSo, string hieuXe, string ngayNhap)
        {
            xe.HoTenChuXe = tenChuXe;
            xe.DiaChi = diaChi;
            xe.DienThoai = sdt;
            xe.BienSo = bienSo;
            xe.HieuXe = hieuXe;
            ngayTiepNhan = ngayNhap;
        }

        void FillValueToReport()
        {
            ReportParameter[] ThongTinXe = new ReportParameter[6];

            ReportParameter tenChuXe = new ReportParameter("TenChuXe", xe.HoTenChuXe);
            ReportParameter diaChi = new ReportParameter("DiaChi", xe.DiaChi);
            ReportParameter sdt = new ReportParameter("SDT", xe.DienThoai);
            ReportParameter bienSo = new ReportParameter("BienSo", xe.BienSo);
            ReportParameter hieuXe = new ReportParameter("HieuXe", xe.HieuXe);
            ReportParameter ngayNhap = new ReportParameter("NgayTiepNhan", ngayTiepNhan);

            ThongTinXe[0] = tenChuXe;
            ThongTinXe[1] = diaChi;
            ThongTinXe[2] = sdt;
            ThongTinXe[3] = bienSo;
            ThongTinXe[4] = hieuXe;
            ThongTinXe[5] = ngayNhap;

            reportViewer1.LocalReport.SetParameters(ThongTinXe);

        }
    }
}
