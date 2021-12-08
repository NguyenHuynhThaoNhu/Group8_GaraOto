namespace QLGR.Presentation
{
    partial class frmMuaPhuTung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuaPhuTung));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtSL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnMua = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(31, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(253, 38);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Nhập số lượng phụ tùng mua thêm";
            // 
            // txtSL
            // 
            // 
            // 
            // 
            this.txtSL.Border.Class = "TextBoxBorder";
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(98, 55);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(114, 24);
            this.txtSL.TabIndex = 8;
            // 
            // btnMua
            // 
            this.btnMua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMua.Image = ((System.Drawing.Image)(resources.GetObject("btnMua.Image")));
            this.btnMua.Location = new System.Drawing.Point(66, 98);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(75, 32);
            this.btnMua.TabIndex = 9;
            this.btnMua.Text = "Mua";
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(168, 98);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 32);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmMuaPhuTung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(316, 142);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnMua);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMuaPhuTung";
            this.Text = "frmMuaPhuTung";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSL;
        private DevComponents.DotNetBar.ButtonX btnMua;
        private DevComponents.DotNetBar.ButtonX btnHuy;
    }
}