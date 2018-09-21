﻿namespace QLCH.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnQLDeThi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnQLCauHoi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnQLMonHoc = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnQLNguoiDung = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnHeThong = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnQLDeThi,
            this.btnQLCauHoi,
            this.btnQLMonHoc,
            this.btnQLNguoiDung,
            this.btnHeThong});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQLDeThi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQLCauHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQLMonHoc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQLNguoiDung, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHeThong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnQLDeThi
            // 
            this.btnQLDeThi.Caption = "Quản lý đề thi";
            this.btnQLDeThi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQLDeThi.Glyph")));
            this.btnQLDeThi.Id = 0;
            this.btnQLDeThi.Name = "btnQLDeThi";
            // 
            // btnQLCauHoi
            // 
            this.btnQLCauHoi.Caption = "Quản lý câu hỏi";
            this.btnQLCauHoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQLCauHoi.Glyph")));
            this.btnQLCauHoi.Id = 1;
            this.btnQLCauHoi.Name = "btnQLCauHoi";
            this.btnQLCauHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLCauHoi_ItemClick);
            // 
            // btnQLMonHoc
            // 
            this.btnQLMonHoc.Caption = "Quản lý môn học";
            this.btnQLMonHoc.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQLMonHoc.Glyph")));
            this.btnQLMonHoc.Id = 2;
            this.btnQLMonHoc.Name = "btnQLMonHoc";
            // 
            // btnQLNguoiDung
            // 
            this.btnQLNguoiDung.Caption = "Quản lý người dùng";
            this.btnQLNguoiDung.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQLNguoiDung.Glyph")));
            this.btnQLNguoiDung.Id = 3;
            this.btnQLNguoiDung.Name = "btnQLNguoiDung";
            // 
            // btnHeThong
            // 
            this.btnHeThong.Caption = "Hệ thống";
            this.btnHeThong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHeThong.Glyph")));
            this.btnHeThong.Id = 4;
            this.btnHeThong.Name = "btnHeThong";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(738, 65);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 420);
            this.barDockControlBottom.Size = new System.Drawing.Size(738, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 65);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 355);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(738, 65);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 355);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 420);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM TẠO ĐỀ THI TRẮC NGHIỆM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnQLDeThi;
        private DevExpress.XtraBars.BarLargeButtonItem btnQLCauHoi;
        private DevExpress.XtraBars.BarLargeButtonItem btnQLMonHoc;
        private DevExpress.XtraBars.BarLargeButtonItem btnQLNguoiDung;
        private DevExpress.XtraBars.BarLargeButtonItem btnHeThong;
    }
}