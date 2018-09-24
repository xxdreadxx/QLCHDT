namespace Publics
{
    partial class FrmChonNgayThang
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
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNam = new DevExpress.XtraEditors.TextEdit();
            this.txtThang = new DevExpress.XtraEditors.TextEdit();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Appearance.Options.UseFont = true;
            this.btnHuyBo.Location = new System.Drawing.Point(118, 96);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(106, 26);
            this.btnHuyBo.TabIndex = 14;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Controls.Add(this.labelControl8);
            this.panelControl3.Controls.Add(this.txtNam);
            this.panelControl3.Controls.Add(this.txtThang);
            this.panelControl3.Location = new System.Drawing.Point(12, 12);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(212, 78);
            this.panelControl3.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(11, 45);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(21, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Năm";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(11, 19);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Tháng";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(53, 42);
            this.txtNam.Name = "txtNam";
            this.txtNam.Properties.Mask.EditMask = "d";
            this.txtNam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtNam.Size = new System.Drawing.Size(135, 20);
            this.txtNam.TabIndex = 2;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(53, 16);
            this.txtThang.Name = "txtThang";
            this.txtThang.Properties.Mask.EditMask = "d";
            this.txtThang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtThang.Size = new System.Drawing.Size(135, 20);
            this.txtThang.TabIndex = 2;
            // 
            // btnDongY
            // 
            this.btnDongY.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Appearance.Options.UseFont = true;
            this.btnDongY.Location = new System.Drawing.Point(12, 96);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(100, 26);
            this.btnDongY.TabIndex = 15;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // FrmChonNgayThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 134);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.btnDongY);
            this.Name = "FrmChonNgayThang";
            this.Text = "Chọn thời gian";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtNam;
        private DevExpress.XtraEditors.TextEdit txtThang;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
    }
}