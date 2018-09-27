namespace QLCH.Forms
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
            this.btnHeThong = new DevExpress.XtraBars.BarLargeButtonItem();
            this.popHeThong = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnQLNguoiDung = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.popDanhMuc = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnLoaiDeThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiCauHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaiHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuongBai = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnQLDeThi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnQLCauHoi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnQLMonHoc = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popHeThong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
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
            this.btnHeThong,
            this.btnDangXuat,
            this.btnThoat,
            this.barLargeButtonItem1,
            this.btnLoaiDeThi,
            this.btnLoaiCauHoi,
            this.barLargeButtonItem2,
            this.btnBaiHoc,
            this.btnChuongBai});
            this.barManager1.MaxItemId = 14;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHeThong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLargeButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQLDeThi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQLCauHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQLMonHoc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnHeThong
            // 
            this.btnHeThong.ActAsDropDown = true;
            this.btnHeThong.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnHeThong.Caption = "Hệ thống";
            this.btnHeThong.DropDownControl = this.popHeThong;
            this.btnHeThong.Id = 4;
            this.btnHeThong.MinSize = new System.Drawing.Size(85, 0);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(60, 20);
            // 
            // popHeThong
            // 
            this.popHeThong.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQLNguoiDung, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDangXuat),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.popHeThong.Manager = this.barManager1;
            this.popHeThong.Name = "popHeThong";
            // 
            // btnQLNguoiDung
            // 
            this.btnQLNguoiDung.Caption = "QL người dùng";
            this.btnQLNguoiDung.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQLNguoiDung.Glyph")));
            this.btnQLNguoiDung.Id = 3;
            this.btnQLNguoiDung.MinSize = new System.Drawing.Size(85, 0);
            this.btnQLNguoiDung.Name = "btnQLNguoiDung";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 6;
            this.btnDangXuat.ImageUri.Uri = "Reset";
            this.btnDangXuat.MinSize = new System.Drawing.Size(85, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageUri.Uri = "Close";
            this.btnThoat.MinSize = new System.Drawing.Size(85, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.ActAsDropDown = true;
            this.barLargeButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barLargeButtonItem1.Caption = "Danh mục";
            this.barLargeButtonItem1.DropDownControl = this.popDanhMuc;
            this.barLargeButtonItem1.Id = 8;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // popDanhMuc
            // 
            this.popDanhMuc.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoaiDeThi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoaiCauHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBaiHoc),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChuongBai)});
            this.popDanhMuc.Manager = this.barManager1;
            this.popDanhMuc.Name = "popDanhMuc";
            // 
            // btnLoaiDeThi
            // 
            this.btnLoaiDeThi.Caption = "Danh mục loại đề thi";
            this.btnLoaiDeThi.Id = 9;
            this.btnLoaiDeThi.Name = "btnLoaiDeThi";
            // 
            // btnLoaiCauHoi
            // 
            this.btnLoaiCauHoi.Caption = "Danh mục loại câu hỏi";
            this.btnLoaiCauHoi.Id = 10;
            this.btnLoaiCauHoi.Name = "btnLoaiCauHoi";
            // 
            // btnBaiHoc
            // 
            this.btnBaiHoc.Caption = "Danh mục bài học";
            this.btnBaiHoc.Id = 12;
            this.btnBaiHoc.Name = "btnBaiHoc";
            this.btnBaiHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaiHoc_ItemClick);
            // 
            // btnChuongBai
            // 
            this.btnChuongBai.Caption = "Danh mục chương bài";
            this.btnChuongBai.Id = 13;
            this.btnChuongBai.Name = "btnChuongBai";
            this.btnChuongBai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuongBai_ItemClick);
            // 
            // btnQLDeThi
            // 
            this.btnQLDeThi.Caption = "Đề thi";
            this.btnQLDeThi.Id = 0;
            this.btnQLDeThi.MinSize = new System.Drawing.Size(85, 0);
            this.btnQLDeThi.Name = "btnQLDeThi";
            this.btnQLDeThi.Size = new System.Drawing.Size(60, 20);
            this.btnQLDeThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLDeThi_ItemClick);
            // 
            // btnQLCauHoi
            // 
            this.btnQLCauHoi.Caption = "Bộ câu hỏi";
            this.btnQLCauHoi.Id = 1;
            this.btnQLCauHoi.MinSize = new System.Drawing.Size(85, 0);
            this.btnQLCauHoi.Name = "btnQLCauHoi";
            this.btnQLCauHoi.Size = new System.Drawing.Size(60, 20);
            this.btnQLCauHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLCauHoi_ItemClick);
            // 
            // btnQLMonHoc
            // 
            this.btnQLMonHoc.Caption = "Môn học";
            this.btnQLMonHoc.Id = 2;
            this.btnQLMonHoc.MinSize = new System.Drawing.Size(85, 0);
            this.btnQLMonHoc.Name = "btnQLMonHoc";
            this.btnQLMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLMonHoc_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(869, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 568);
            this.barDockControlBottom.Size = new System.Drawing.Size(869, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 537);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(869, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 537);
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Id = 11;
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Red;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 568);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM TẠO ĐỀ THI TRẮC NGHIỆM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popHeThong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
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
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarLargeButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarLargeButtonItem btnThoat;
        private DevExpress.XtraBars.PopupMenu popHeThong;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.PopupMenu popDanhMuc;
        private DevExpress.XtraBars.BarButtonItem btnLoaiDeThi;
        private DevExpress.XtraBars.BarButtonItem btnLoaiCauHoi;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnBaiHoc;
        private DevExpress.XtraBars.BarLargeButtonItem btnChuongBai;
    }
}