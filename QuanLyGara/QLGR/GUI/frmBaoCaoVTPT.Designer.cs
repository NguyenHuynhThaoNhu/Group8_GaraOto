namespace QLGR.Presentation
{
    partial class frmBaoCaoVTPT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoVTPT));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vWBCVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBaoCaoVT = new QLGR.dsBaoCaoVT();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.txtNam = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnLoc = new DevComponents.DotNetBar.ButtonX();
            this.cboThang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vW_BCVTTableAdapter = new QLGR.dsBaoCaoVTTableAdapters.VW_BCVTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vWBCVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBaoCaoVT)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vWBCVTBindingSource
            // 
            this.vWBCVTBindingSource.DataMember = "VW_BCVT";
            this.vWBCVTBindingSource.DataSource = this.dsBaoCaoVT;
            // 
            // dsBaoCaoVT
            // 
            this.dsBaoCaoVT.DataSetName = "dsBaoCaoVT";
            this.dsBaoCaoVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.txtNam);
            this.panelEx1.Controls.Add(this.btnLoc);
            this.panelEx1.Controls.Add(this.cboThang);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(645, 93);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // txtNam
            // 
            // 
            // 
            // 
            this.txtNam.Border.Class = "TextBoxBorder";
            this.txtNam.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(332, 61);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(74, 24);
            this.txtNam.TabIndex = 1;
            // 
            // btnLoc
            // 
            this.btnLoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.Location = new System.Drawing.Point(428, 60);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 25);
            this.btnLoc.TabIndex = 2;
            this.btnLoc.Text = "   Lọc";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cboThang
            // 
            this.cboThang.DisplayMember = "Text";
            this.cboThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.FormattingEnabled = true;
            this.cboThang.ItemHeight = 18;
            this.cboThang.Location = new System.Drawing.Point(212, 60);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(59, 24);
            this.cboThang.TabIndex = 0;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.Control;
            this.labelX3.Location = new System.Drawing.Point(288, 62);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(54, 22);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Năm:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelX2.Location = new System.Drawing.Point(162, 62);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(54, 22);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tháng:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelX1.Location = new System.Drawing.Point(162, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(341, 40);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "BÁO CÁO PHỤ TÙNG";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsBCVT";
            reportDataSource1.Value = this.vWBCVTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGR.Bill_Report.rpVTPT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(645, 469);
            this.reportViewer1.TabIndex = 5;
            // 
            // vW_BCVTTableAdapter
            // 
            this.vW_BCVTTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoVTPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 562);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmBaoCaoVTPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo phụ tùng";
            this.Load += new System.EventHandler(this.frmBaoCaoVTPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWBCVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBaoCaoVT)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNam;
        private DevComponents.DotNetBar.ButtonX btnLoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboThang;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsBaoCaoVT dsBaoCaoVT;
        private System.Windows.Forms.BindingSource vWBCVTBindingSource;
        private dsBaoCaoVTTableAdapters.VW_BCVTTableAdapter vW_BCVTTableAdapter;
    }
}