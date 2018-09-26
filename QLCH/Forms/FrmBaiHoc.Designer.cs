namespace QLCH.Forms
{
    partial class FrmBaiHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaiHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThemMoi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSuaDoi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarLargeButtonItem();
            this.grdData = new DevExpress.XtraGrid.GridControl();
            this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdcolID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolMaBaiHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolTenBaiHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolIDChuong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
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
            this.btnThemMoi,
            this.btnSuaDoi,
            this.btnXoa,
            this.btnDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaDoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(715, 56);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 464);
            this.barDockControlBottom.Size = new System.Drawing.Size(715, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 56);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 408);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(715, 56);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 408);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Caption = "Thêm mới ";
            this.btnThemMoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Glyph")));
            this.btnThemMoi.Id = 0;
            this.btnThemMoi.Name = "btnThemMoi";
            // 
            // btnSuaDoi
            // 
            this.btnSuaDoi.Caption = "Sửa đổi";
            this.btnSuaDoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSuaDoi.Glyph")));
            this.btnSuaDoi.Id = 1;
            this.btnSuaDoi.Name = "btnSuaDoi";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 2;
            this.btnXoa.Name = "btnXoa";
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDong.Glyph")));
            this.btnDong.Id = 3;
            this.btnDong.Name = "btnDong";
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
            this.grdData.Location = new System.Drawing.Point(0, 56);
            this.grdData.MainView = this.grvData;
            this.grdData.MenuManager = this.barManager1;
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(715, 408);
            this.grdData.TabIndex = 9;
            this.grdData.UseEmbeddedNavigator = true;
            this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
            // 
            // grvData
            // 
            this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdcolID,
            this.grdcolMaBaiHoc,
            this.grdcolTenBaiHoc,
            this.grdcolIDChuong});
            this.grvData.GridControl = this.grdData;
            this.grvData.Name = "grvData";
            this.grvData.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // grdcolID
            // 
            this.grdcolID.Caption = "ID";
            this.grdcolID.FieldName = "ID";
            this.grdcolID.Name = "grdcolID";
            // 
            // grdcolMaBaiHoc
            // 
            this.grdcolMaBaiHoc.Caption = "Mã bài học";
            this.grdcolMaBaiHoc.FieldName = "MaBaiHoc";
            this.grdcolMaBaiHoc.Name = "grdcolMaBaiHoc";
            this.grdcolMaBaiHoc.Visible = true;
            this.grdcolMaBaiHoc.VisibleIndex = 0;
            // 
            // grdcolTenBaiHoc
            // 
            this.grdcolTenBaiHoc.Caption = "Tên bài học";
            this.grdcolTenBaiHoc.FieldName = "TenBaiHoc";
            this.grdcolTenBaiHoc.Name = "grdcolTenBaiHoc";
            this.grdcolTenBaiHoc.Visible = true;
            this.grdcolTenBaiHoc.VisibleIndex = 1;
            // 
            // grdcolIDChuong
            // 
            this.grdcolIDChuong.Caption = "IDChuong";
            this.grdcolIDChuong.FieldName = "ID_Chuong";
            this.grdcolIDChuong.Name = "grdcolIDChuong";
            // 
            // FrmBaiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 464);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "FrmBaiHoc";
            this.Text = "FrmBaiHoc";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBaiHoc_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnThemMoi;
        private DevExpress.XtraBars.BarLargeButtonItem btnSuaDoi;
        private DevExpress.XtraBars.BarLargeButtonItem btnXoa;
        private DevExpress.XtraBars.BarLargeButtonItem btnDong;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView grvData;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolID;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolMaBaiHoc;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolTenBaiHoc;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolIDChuong;
    }
}