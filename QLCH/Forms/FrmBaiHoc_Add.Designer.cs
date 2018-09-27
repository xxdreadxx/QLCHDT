namespace QLCH.Forms
{
    partial class FrmBaiHoc_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaiHoc_Add));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnLuuThayDoi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaChuongBai = new DevExpress.XtraEditors.TextEdit();
            this.txtmaMon = new DevExpress.XtraEditors.TextEdit();
            this.txtMaBaiHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtKhoiLop = new DevExpress.XtraEditors.TextEdit();
            this.txtTenChuongBai = new DevExpress.XtraEditors.TextEdit();
            this.txtTenMon = new DevExpress.XtraEditors.TextEdit();
            this.txtNoiDung = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txttenBaiHoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChuongBai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBaiHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoiLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChuongBai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenBaiHoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLuuThayDoi,
            this.btnDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuThayDoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnLuuThayDoi
            // 
            this.btnLuuThayDoi.Caption = "Lưu thay đổi";
            this.btnLuuThayDoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLuuThayDoi.Glyph")));
            this.btnLuuThayDoi.Id = 0;
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuThayDoi_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDong.Glyph")));
            this.btnDong.Id = 1;
            this.btnDong.Name = "btnDong";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(421, 56);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 279);
            this.barDockControlBottom.Size = new System.Drawing.Size(421, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 56);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 223);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(421, 56);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 223);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txtMaChuongBai);
            this.groupControl1.Controls.Add(this.txtmaMon);
            this.groupControl1.Controls.Add(this.txtMaBaiHoc);
            this.groupControl1.Controls.Add(this.txtKhoiLop);
            this.groupControl1.Controls.Add(this.txtTenChuongBai);
            this.groupControl1.Controls.Add(this.txtTenMon);
            this.groupControl1.Controls.Add(this.txtNoiDung);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txttenBaiHoc);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 56);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(421, 223);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Phím tắt";
            // 
            // txtMaChuongBai
            // 
            this.txtMaChuongBai.Location = new System.Drawing.Point(94, 124);
            this.txtMaChuongBai.Name = "txtMaChuongBai";
            this.txtMaChuongBai.Size = new System.Drawing.Size(62, 20);
            this.txtMaChuongBai.TabIndex = 4;
            this.txtMaChuongBai.Leave += new System.EventHandler(this.txtMaChuongBai_Leave);
            // 
            // txtmaMon
            // 
            this.txtmaMon.Location = new System.Drawing.Point(94, 95);
            this.txtmaMon.Name = "txtmaMon";
            this.txtmaMon.Size = new System.Drawing.Size(62, 20);
            this.txtmaMon.TabIndex = 2;
            this.txtmaMon.Leave += new System.EventHandler(this.txtmaMon_Leave);
            // 
            // txtMaBaiHoc
            // 
            this.txtMaBaiHoc.Location = new System.Drawing.Point(94, 32);
            this.txtMaBaiHoc.Name = "txtMaBaiHoc";
            this.txtMaBaiHoc.Size = new System.Drawing.Size(174, 20);
            this.txtMaBaiHoc.TabIndex = 0;
            // 
            // txtKhoiLop
            // 
            this.txtKhoiLop.Location = new System.Drawing.Point(94, 61);
            this.txtKhoiLop.Name = "txtKhoiLop";
            this.txtKhoiLop.Size = new System.Drawing.Size(174, 20);
            this.txtKhoiLop.TabIndex = 1;
            // 
            // txtTenChuongBai
            // 
            this.txtTenChuongBai.Location = new System.Drawing.Point(164, 124);
            this.txtTenChuongBai.Name = "txtTenChuongBai";
            this.txtTenChuongBai.Size = new System.Drawing.Size(227, 20);
            this.txtTenChuongBai.TabIndex = 5;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(164, 95);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(227, 20);
            this.txtTenMon.TabIndex = 3;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(94, 181);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(297, 20);
            this.txtNoiDung.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(21, 35);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Mã bài học";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 127);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Chương";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Khối lớp";
            // 
            // txttenBaiHoc
            // 
            this.txttenBaiHoc.Location = new System.Drawing.Point(94, 155);
            this.txttenBaiHoc.MenuManager = this.barManager1;
            this.txttenBaiHoc.Name = "txttenBaiHoc";
            this.txttenBaiHoc.Size = new System.Drawing.Size(297, 20);
            this.txttenBaiHoc.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Môn học";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 186);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nội dung";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 158);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên bài học";
            // 
            // FrmBaiHoc_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 279);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "FrmBaiHoc_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm bài học";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBaiHoc_Add_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaChuongBai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBaiHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoiLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChuongBai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenBaiHoc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnLuuThayDoi;
        private DevExpress.XtraBars.BarLargeButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNoiDung;
        private DevExpress.XtraEditors.TextEdit txttenBaiHoc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaChuongBai;
        private DevExpress.XtraEditors.TextEdit txtmaMon;
        private DevExpress.XtraEditors.TextEdit txtKhoiLop;
        private DevExpress.XtraEditors.TextEdit txtTenChuongBai;
        private DevExpress.XtraEditors.TextEdit txtTenMon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMaBaiHoc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}