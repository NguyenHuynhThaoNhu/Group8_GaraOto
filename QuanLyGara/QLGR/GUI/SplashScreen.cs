using System;
using System.Windows.Forms;


namespace QLGR.Presentation
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void ProgressBar_Tick(object sender, EventArgs e)
        {
            progressBarX1.Increment(1);
            if (progressBarX1.Value == 100)
            {
                ProgressTimer.Stop();
                this.Hide();
                new frmDangNhap().ShowDialog();
                this.Close();
            }
        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }
    }
}
