namespace QLGR.Presentation
{
    partial class frmLapPhieuThuTien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieuThuTien));
            this.btnLapPhieu = new DevComponents.DotNetBar.ButtonX();
            this.txtTenChuXe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBienSo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLapPhieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLapPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieu.Image")));
            this.btnLapPhieu.Location = new System.Drawing.Point(115, 102);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(75, 23);
            this.btnLapPhieu.TabIndex = 7;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // txtTenChuXe
            // 
            // 
            // 
            // 
            this.txtTenChuXe.Border.Class = "TextBoxBorder";
            this.txtTenChuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChuXe.Location = new System.Drawing.Point(77, 60);
            this.txtTenChuXe.Name = "txtTenChuXe";
            this.txtTenChuXe.ReadOnly = true;
            this.txtTenChuXe.Size = new System.Drawing.Size(210, 24);
            this.txtTenChuXe.TabIndex = 5;
            // 
            // txtBienSo
            // 
            // 
            // 
            // 
            this.txtBienSo.Border.Class = "TextBoxBorder";
            this.txtBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienSo.Location = new System.Drawing.Point(77, 21);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(210, 24);
            this.txtBienSo.TabIndex = 3;
            this.txtBienSo.TextChanged += new System.EventHandler(this.txtBienSo_TextChanged);
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(10, 61);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(61, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Chủ xe:";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(10, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(61, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Biển số";
            // 
            // frmLapPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 132);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.txtTenChuXe);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLapPhieuThuTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu thu tiền";
            this.Load += new System.EventHandler(this.frmLapPhieuThuTien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnLapPhieu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenChuXe;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBienSo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}