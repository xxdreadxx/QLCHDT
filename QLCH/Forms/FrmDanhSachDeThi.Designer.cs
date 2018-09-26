namespace QLCH.Forms
{
    partial class FrmDanhSachDeThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhSachDeThi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.btnTaoDeThi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSuaDoi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnXoaBaiThi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnTieuChi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.popTieuChi = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnInBaiThi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.grdData = new DevExpress.XtraGrid.GridControl();
            this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdcolMaDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolTieuDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolLoaiDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolSoCau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolMonHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolInUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpPhimTat = new DevExpress.XtraEditors.GroupControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popTieuChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPhimTat)).BeginInit();
            this.grpPhimTat.SuspendLayout();
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
            this.btnTaoDeThi,
            this.btnSuaDoi,
            this.btnXoaBaiThi,
            this.btnTieuChi,
            this.btnInBaiThi,
            this.btnDong,
            this.barButtonItem1,
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 10;
            // 
            // btnTaoDeThi
            // 
            this.btnTaoDeThi.Caption = "Tạo đề thi";
            this.btnTaoDeThi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTaoDeThi.Glyph")));
            this.btnTaoDeThi.Id = 0;
            this.btnTaoDeThi.Name = "btnTaoDeThi";
            this.btnTaoDeThi.Size = new System.Drawing.Size(70, 20);
            this.btnTaoDeThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoDeThi_ItemClick);
            // 
            // btnSuaDoi
            // 
            this.btnSuaDoi.Caption = "Sửa đổi";
            this.btnSuaDoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSuaDoi.Glyph")));
            this.btnSuaDoi.Id = 1;
            this.btnSuaDoi.Name = "btnSuaDoi";
            this.btnSuaDoi.Size = new System.Drawing.Size(70, 20);
            // 
            // btnXoaBaiThi
            // 
            this.btnXoaBaiThi.Caption = "Xóa bài thi";
            this.btnXoaBaiThi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoaBaiThi.Glyph")));
            this.btnXoaBaiThi.Id = 2;
            this.btnXoaBaiThi.Name = "btnXoaBaiThi";
            this.btnXoaBaiThi.Size = new System.Drawing.Size(80, 20);
            // 
            // btnTieuChi
            // 
            this.btnTieuChi.ActAsDropDown = true;
            this.btnTieuChi.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnTieuChi.Caption = "Tiêu chí";
            this.btnTieuChi.DropDownControl = this.popTieuChi;
            this.btnTieuChi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTieuChi.Glyph")));
            this.btnTieuChi.Id = 3;
            this.btnTieuChi.Name = "btnTieuChi";
            this.btnTieuChi.Size = new System.Drawing.Size(70, 20);
            // 
            // popTieuChi
            // 
            this.popTieuChi.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.popTieuChi.Manager = this.barManager1;
            this.popTieuChi.Name = "popTieuChi";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đề thi lớp 10";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Đề thi lớp 11";
            this.barLargeButtonItem1.Id = 7;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đề thi lớp 12";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnInBaiThi
            // 
            this.btnInBaiThi.Caption = "In bài thi";
            this.btnInBaiThi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnInBaiThi.Glyph")));
            this.btnInBaiThi.Id = 4;
            this.btnInBaiThi.Name = "btnInBaiThi";
            this.btnInBaiThi.Size = new System.Drawing.Size(70, 20);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDong.Glyph")));
            this.btnDong.Id = 5;
            this.btnDong.Name = "btnDong";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(842, 65);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 533);
            this.barDockControlBottom.Size = new System.Drawing.Size(842, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 65);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 468);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(842, 65);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 468);
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Id = 8;
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // grdData
            // 
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdData.EmbeddedNavigator.TextStringFormat = "Bản ghi thứ {0} của {1}";
            this.grdData.Location = new System.Drawing.Point(2, 20);
            this.grdData.MainView = this.grvData;
            this.grdData.MenuManager = this.barManager1;
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(838, 446);
            this.grdData.TabIndex = 4;
            this.grdData.UseEmbeddedNavigator = true;
            this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
            // 
            // grvData
            // 
            this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdcolMaDe,
            this.grdcolTieuDe,
            this.grdcolLoaiDe,
            this.grdcolSoCau,
            this.grdcolMonHoc,
            this.grdcolInUsed});
            this.grvData.GridControl = this.grdData;
            this.grvData.Name = "grvData";
            this.grvData.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grvData.OptionsView.ShowGroupPanel = false;
            // 
            // grdcolMaDe
            // 
            this.grdcolMaDe.Caption = "Mã đề";
            this.grdcolMaDe.FieldName = "MaDe";
            this.grdcolMaDe.Name = "grdcolMaDe";
            this.grdcolMaDe.Visible = true;
            this.grdcolMaDe.VisibleIndex = 0;
            // 
            // grdcolTieuDe
            // 
            this.grdcolTieuDe.Caption = "Tiêu đề";
            this.grdcolTieuDe.Name = "grdcolTieuDe";
            this.grdcolTieuDe.Visible = true;
            this.grdcolTieuDe.VisibleIndex = 1;
            // 
            // grdcolLoaiDe
            // 
            this.grdcolLoaiDe.Caption = "Loại đề thi";
            this.grdcolLoaiDe.FieldName = "LoaiDe";
            this.grdcolLoaiDe.Name = "grdcolLoaiDe";
            this.grdcolLoaiDe.Visible = true;
            this.grdcolLoaiDe.VisibleIndex = 2;
            // 
            // grdcolSoCau
            // 
            this.grdcolSoCau.Caption = "Số câu";
            this.grdcolSoCau.FieldName = "SoCau";
            this.grdcolSoCau.Name = "grdcolSoCau";
            this.grdcolSoCau.Visible = true;
            this.grdcolSoCau.VisibleIndex = 3;
            // 
            // grdcolMonHoc
            // 
            this.grdcolMonHoc.Caption = "Môn học";
            this.grdcolMonHoc.FieldName = "MonHoc";
            this.grdcolMonHoc.Name = "grdcolMonHoc";
            this.grdcolMonHoc.Visible = true;
            this.grdcolMonHoc.VisibleIndex = 4;
            // 
            // grdcolInUsed
            // 
            this.grdcolInUsed.Caption = "Đã sử dụng";
            this.grdcolInUsed.FieldName = "InUsed";
            this.grdcolInUsed.Name = "grdcolInUsed";
            this.grdcolInUsed.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.grdcolInUsed.Visible = true;
            this.grdcolInUsed.VisibleIndex = 5;
            // 
            // grpPhimTat
            // 
            this.grpPhimTat.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhimTat.AppearanceCaption.Options.UseFont = true;
            this.grpPhimTat.Controls.Add(this.grdData);
            this.grpPhimTat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPhimTat.Location = new System.Drawing.Point(0, 65);
            this.grpPhimTat.Name = "grpPhimTat";
            this.grpPhimTat.Size = new System.Drawing.Size(842, 468);
            this.grpPhimTat.TabIndex = 5;
            this.grpPhimTat.Text = "Phím tắt";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaoDeThi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaDoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaBaiThi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTieuChi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInBaiThi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 3";
            // 
            // FrmDanhSachDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 533);
            this.Controls.Add(this.grpPhimTat);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmDanhSachDeThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách đề thi";
            this.Load += new System.EventHandler(this.FrmDanhSachDeThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popTieuChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPhimTat)).EndInit();
            this.grpPhimTat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnTaoDeThi;
        private DevExpress.XtraBars.BarLargeButtonItem btnSuaDoi;
        private DevExpress.XtraBars.BarLargeButtonItem btnXoaBaiThi;
        private DevExpress.XtraBars.BarLargeButtonItem btnTieuChi;
        private DevExpress.XtraBars.PopupMenu popTieuChi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarLargeButtonItem btnInBaiThi;
        private DevExpress.XtraBars.BarLargeButtonItem btnDong;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraEditors.GroupControl grpPhimTat;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView grvData;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolMaDe;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolTieuDe;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolLoaiDe;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolSoCau;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolInUsed;
        private DevExpress.XtraBars.Bar bar1;
    }
}