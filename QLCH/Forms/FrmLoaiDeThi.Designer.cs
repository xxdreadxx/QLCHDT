namespace QLCH.Forms
{
    partial class FrmLoaiDeThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoaiDeThi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem4 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.grdData = new DevExpress.XtraGrid.GridControl();
            this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdcolMaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolTenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolIDLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolTLCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolTLCTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolTLCD = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barLargeButtonItem3,
            this.barLargeButtonItem4});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLargeButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLargeButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLargeButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLargeButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Thêm mới";
            this.barLargeButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.Glyph")));
            this.barLargeButtonItem1.Id = 0;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(572, 56);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 328);
            this.barDockControlBottom.Size = new System.Drawing.Size(572, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 56);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 272);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(572, 56);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 272);
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Sửa đổi";
            this.barLargeButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem2.Glyph")));
            this.barLargeButtonItem2.Id = 1;
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // barLargeButtonItem3
            // 
            this.barLargeButtonItem3.Caption = "Xóa";
            this.barLargeButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem3.Glyph")));
            this.barLargeButtonItem3.Id = 2;
            this.barLargeButtonItem3.Name = "barLargeButtonItem3";
            // 
            // barLargeButtonItem4
            // 
            this.barLargeButtonItem4.Caption = "Đóng";
            this.barLargeButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem4.Glyph")));
            this.barLargeButtonItem4.Id = 3;
            this.barLargeButtonItem4.Name = "barLargeButtonItem4";
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
            this.grdData.Size = new System.Drawing.Size(572, 272);
            this.grdData.TabIndex = 4;
            this.grdData.UseEmbeddedNavigator = true;
            this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
            // 
            // grvData
            // 
            this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdcolMaLoai,
            this.grdcolTenLoai,
            this.grdcolIDLoai,
            this.grdcolThoiGian,
            this.grdcolTLCK,
            this.grdcolTLCTB,
            this.grdcolTLCD});
            this.grvData.GridControl = this.grdData;
            this.grvData.Name = "grvData";
            this.grvData.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grvData.OptionsView.ShowGroupPanel = false;
            // 
            // grdcolMaLoai
            // 
            this.grdcolMaLoai.Caption = "Mã loại";
            this.grdcolMaLoai.FieldName = "Maloai";
            this.grdcolMaLoai.Name = "grdcolMaLoai";
            this.grdcolMaLoai.Visible = true;
            this.grdcolMaLoai.VisibleIndex = 0;
            // 
            // grdcolTenLoai
            // 
            this.grdcolTenLoai.Caption = "Tên loại";
            this.grdcolTenLoai.FieldName = "TenLoai";
            this.grdcolTenLoai.Name = "grdcolTenLoai";
            this.grdcolTenLoai.Visible = true;
            this.grdcolTenLoai.VisibleIndex = 1;
            // 
            // grdcolIDLoai
            // 
            this.grdcolIDLoai.Caption = "IDLoai";
            this.grdcolIDLoai.FieldName = "ID";
            this.grdcolIDLoai.Name = "grdcolIDLoai";
            // 
            // grdcolThoiGian
            // 
            this.grdcolThoiGian.Caption = "Thời gian";
            this.grdcolThoiGian.FieldName = "ThoiGian";
            this.grdcolThoiGian.Name = "grdcolThoiGian";
            this.grdcolThoiGian.Visible = true;
            this.grdcolThoiGian.VisibleIndex = 2;
            // 
            // grdcolTLCK
            // 
            this.grdcolTLCK.Caption = "Tỉ lệ câu khó";
            this.grdcolTLCK.FieldName = "TiLeCauKho";
            this.grdcolTLCK.Name = "grdcolTLCK";
            this.grdcolTLCK.Visible = true;
            this.grdcolTLCK.VisibleIndex = 3;
            // 
            // grdcolTLCTB
            // 
            this.grdcolTLCTB.Caption = "Tỉ lệ câu TB";
            this.grdcolTLCTB.FieldName = "TiLeCauTB";
            this.grdcolTLCTB.Name = "grdcolTLCTB";
            this.grdcolTLCTB.Visible = true;
            this.grdcolTLCTB.VisibleIndex = 4;
            // 
            // grdcolTLCD
            // 
            this.grdcolTLCD.Caption = "Tỉ lệ câu dễ";
            this.grdcolTLCD.FieldName = "TiLeCauDe";
            this.grdcolTLCD.Name = "grdcolTLCD";
            this.grdcolTLCD.Visible = true;
            this.grdcolTLCD.VisibleIndex = 5;
            // 
            // FrmLoaiDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 328);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "FrmLoaiDeThi";
            this.Text = "Loại đề thi";
            this.Load += new System.EventHandler(this.FrmLoaiDeThi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLoaiDeThi_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem3;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem4;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView grvData;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolMaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolTenLoai;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolIDLoai;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolTLCK;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolTLCTB;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolTLCD;
    }
}