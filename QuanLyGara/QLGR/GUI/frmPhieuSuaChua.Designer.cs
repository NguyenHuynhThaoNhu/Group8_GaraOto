namespace QLGR.Presentation
{
    partial class frmPhieuSuaChua
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuSuaChua));
            this.dgvCTPSC = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnXong = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cboPhuTung = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtSL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtThanhTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDonGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTienCong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboNoiDung = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtMaPhieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBienSo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTongTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.btnInPhieu = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPSC)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCTPSC
            // 
            this.dgvCTPSC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvCTPSC.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTPSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTPSC.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTPSC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCTPSC.Location = new System.Drawing.Point(38, 280);
            this.dgvCTPSC.Name = "dgvCTPSC";
            this.dgvCTPSC.Size = new System.Drawing.Size(615, 287);
            this.dgvCTPSC.TabIndex = 20;
            this.dgvCTPSC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPSC_CellClick);
            // 
            // btnXong
            // 
            this.btnXong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXong.Image = ((System.Drawing.Image)(resources.GetObject("btnXong.Image")));
            this.btnXong.Location = new System.Drawing.Point(578, 575);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(75, 27);
            this.btnXong.TabIndex = 21;
            this.btnXong.Text = "Xong";
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cboPhuTung);
            this.groupPanel1.Controls.Add(this.txtSL);
            this.groupPanel1.Controls.Add(this.txtThanhTien);
            this.groupPanel1.Controls.Add(this.txtDonGia);
            this.groupPanel1.Controls.Add(this.txtTienCong);
            this.groupPanel1.Controls.Add(this.cboNoiDung);
            this.groupPanel1.Controls.Add(this.btnXoa);
            this.groupPanel1.Controls.Add(this.btnThem);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Location = new System.Drawing.Point(38, 110);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(615, 164);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 22;
            this.groupPanel1.Text = "Chi tiết";
            // 
            // cboPhuTung
            // 
            this.cboPhuTung.DisplayMember = "Text";
            this.cboPhuTung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPhuTung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhuTung.FormattingEnabled = true;
            this.cboPhuTung.ItemHeight = 18;
            this.cboPhuTung.Location = new System.Drawing.Point(102, 42);
            this.cboPhuTung.Name = "cboPhuTung";
            this.cboPhuTung.Size = new System.Drawing.Size(490, 24);
            this.cboPhuTung.TabIndex = 36;
            this.cboPhuTung.SelectedIndexChanged += new System.EventHandler(this.cboPhuTung_SelectedIndexChanged);
            // 
            // txtSL
            // 
            this.txtSL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSL.Border.Class = "TextBoxBorder";
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(102, 74);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(70, 24);
            this.txtSL.TabIndex = 36;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtThanhTien.Border.Class = "TextBoxBorder";
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(102, 107);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(312, 24);
            this.txtThanhTien.TabIndex = 36;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtDonGia.Border.Class = "TextBoxBorder";
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(247, 74);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(350, 24);
            this.txtDonGia.TabIndex = 36;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // txtTienCong
            // 
            this.txtTienCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtTienCong.Border.Class = "TextBoxBorder";
            this.txtTienCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCong.Location = new System.Drawing.Point(495, 11);
            this.txtTienCong.Name = "txtTienCong";
            this.txtTienCong.ReadOnly = true;
            this.txtTienCong.Size = new System.Drawing.Size(97, 24);
            this.txtTienCong.TabIndex = 36;
            // 
            // cboNoiDung
            // 
            this.cboNoiDung.DisplayMember = "Text";
            this.cboNoiDung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNoiDung.FormattingEnabled = true;
            this.cboNoiDung.ItemHeight = 18;
            this.cboNoiDung.Location = new System.Drawing.Point(102, 8);
            this.cboNoiDung.Name = "cboNoiDung";
            this.cboNoiDung.Size = new System.Drawing.Size(288, 24);
            this.cboNoiDung.TabIndex = 36;
            this.cboNoiDung.SelectedIndexChanged += new System.EventHandler(this.cboNoiDung_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(512, 107);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 26);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(420, 107);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 26);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelX4
            // 
            this.labelX4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(406, 10);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(83, 23);
            this.labelX4.TabIndex = 35;
            this.labelX4.Text = "- Tiền công:";
            // 
            // labelX7
            // 
            this.labelX7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(178, 74);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 35;
            this.labelX7.Text = "- Đơn giá:";
            // 
            // labelX8
            // 
            this.labelX8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(21, 104);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 35;
            this.labelX8.Text = "Thành tiền:";
            // 
            // labelX6
            // 
            this.labelX6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(21, 72);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 35;
            this.labelX6.Text = "Số lượng:";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(21, 40);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 35;
            this.labelX5.Text = "Phụ tùng:";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(21, 8);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 35;
            this.labelX3.Text = "Nội dung:";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(47, 67);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 35;
            this.labelX1.Text = "Mã phiếu:";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(366, 68);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 35;
            this.labelX2.Text = "Biển số:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtMaPhieu.Border.Class = "TextBoxBorder";
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(128, 68);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(210, 24);
            this.txtMaPhieu.TabIndex = 36;
            // 
            // txtBienSo
            // 
            this.txtBienSo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtBienSo.Border.Class = "TextBoxBorder";
            this.txtBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienSo.Location = new System.Drawing.Point(447, 67);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.ReadOnly = true;
            this.txtBienSo.Size = new System.Drawing.Size(191, 24);
            this.txtBienSo.TabIndex = 36;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.txtTongTien.Border.Class = "TextBoxBorder";
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(282, 576);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(206, 24);
            this.txtTongTien.TabIndex = 37;
            // 
            // labelX9
            // 
            this.labelX9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(150, 9);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(434, 47);
            this.labelX9.TabIndex = 38;
            this.labelX9.Text = "CHI TIẾT PHIẾU SỬA CHỮA";
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInPhieu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInPhieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieu.Image")));
            this.btnInPhieu.Location = new System.Drawing.Point(497, 575);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(75, 27);
            this.btnInPhieu.TabIndex = 21;
            this.btnInPhieu.Text = "In phiếu";
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // frmPhieuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 614);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.dgvCTPSC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhieuSuaChua";
            this.Text = "frmPhieuSuaChua";
            this.Load += new System.EventHandler(this.frmPhieuSuaChua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPSC)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCTPSC;
        private DevComponents.DotNetBar.ButtonX btnXong;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboPhuTung;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNoiDung;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPhieu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBienSo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTongTien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSL;
        private DevComponents.DotNetBar.Controls.TextBoxX txtThanhTien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDonGia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTienCong;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX btnInPhieu;
        private DevComponents.DotNetBar.ButtonX btnXoa;
    }
}