namespace QLCH.Forms
{
    partial class FrmLoaiCauHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoaiCauHoi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnCopy = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDuyet = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarLargeButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grdLoaiMonHoc = new DevExpress.XtraGrid.GridControl();
            this.grvLoaiMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdcolMaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolLoaiCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoaiMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLoaiMonHoc)).BeginInit();
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
            this.btnAdd,
            this.btnCopy,
            this.btnEdit,
            this.btnDuyet,
            this.btnDel,
            this.btnClose});
            this.barManager1.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(752, 65);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 393);
            this.barDockControlBottom.Size = new System.Drawing.Size(752, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 65);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 328);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(752, 65);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 328);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCopy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDuyet, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm mới";
            this.btnAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAdd.Glyph")));
            this.btnAdd.Id = 0;
            this.btnAdd.MinSize = new System.Drawing.Size(65, 0);
            this.btnAdd.Name = "btnAdd";
            // 
            // btnCopy
            // 
            this.btnCopy.Caption = "Sao chép";
            this.btnCopy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCopy.Glyph")));
            this.btnCopy.Id = 1;
            this.btnCopy.MinSize = new System.Drawing.Size(65, 0);
            this.btnCopy.Name = "btnCopy";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Chỉnh sửa";
            this.btnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEdit.Glyph")));
            this.btnEdit.Id = 2;
            this.btnEdit.MinSize = new System.Drawing.Size(65, 0);
            this.btnEdit.Name = "btnEdit";
            // 
            // btnDuyet
            // 
            this.btnDuyet.Caption = "Duyệt";
            this.btnDuyet.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDuyet.Glyph")));
            this.btnDuyet.Id = 3;
            this.btnDuyet.MinSize = new System.Drawing.Size(65, 0);
            this.btnDuyet.Name = "btnDuyet";
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Xóa";
            this.btnDel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDel.Glyph")));
            this.btnDel.Id = 4;
            this.btnDel.MinSize = new System.Drawing.Size(65, 0);
            this.btnDel.Name = "btnDel";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClose.Glyph")));
            this.btnClose.Id = 5;
            this.btnClose.MinSize = new System.Drawing.Size(65, 0);
            this.btnClose.Name = "btnClose";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.grdLoaiMonHoc);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 65);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(752, 328);
            this.groupControl1.TabIndex = 10;
            // 
            // grdLoaiMonHoc
            // 
            this.grdLoaiMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLoaiMonHoc.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdLoaiMonHoc.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdLoaiMonHoc.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdLoaiMonHoc.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdLoaiMonHoc.EmbeddedNavigator.Buttons.First.Visible = false;
            this.grdLoaiMonHoc.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdLoaiMonHoc.Location = new System.Drawing.Point(2, 20);
            this.grdLoaiMonHoc.MainView = this.grvLoaiMonHoc;
            this.grdLoaiMonHoc.MenuManager = this.barManager1;
            this.grdLoaiMonHoc.Name = "grdLoaiMonHoc";
            this.grdLoaiMonHoc.Size = new System.Drawing.Size(748, 306);
            this.grdLoaiMonHoc.TabIndex = 0;
            this.grdLoaiMonHoc.UseEmbeddedNavigator = true;
            this.grdLoaiMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLoaiMonHoc});
            // 
            // grvLoaiMonHoc
            // 
            this.grvLoaiMonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdcolMaLoai,
            this.grdcolLoaiCH,
            this.grdcolSL,
            this.grdcolNgayTao,
            this.grdcolTrangThai,
            this.grdcolID});
            this.grvLoaiMonHoc.GridControl = this.grdLoaiMonHoc;
            this.grvLoaiMonHoc.Name = "grvLoaiMonHoc";
            this.grvLoaiMonHoc.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // grdcolMaLoai
            // 
            this.grdcolMaLoai.AppearanceCell.Options.UseTextOptions = true;
            this.grdcolMaLoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdcolMaLoai.Caption = "Mã loại câu hỏi";
            this.grdcolMaLoai.FieldName = "MaLoai";
            this.grdcolMaLoai.Name = "grdcolMaLoai";
            this.grdcolMaLoai.OptionsColumn.AllowEdit = false;
            this.grdcolMaLoai.Visible = true;
            this.grdcolMaLoai.VisibleIndex = 0;
            this.grdcolMaLoai.Width = 35;
            // 
            // grdcolLoaiCH
            // 
            this.grdcolLoaiCH.Caption = "Loại câu hỏi";
            this.grdcolLoaiCH.FieldName = "LoaiCauHoi";
            this.grdcolLoaiCH.Name = "grdcolLoaiCH";
            this.grdcolLoaiCH.OptionsColumn.AllowEdit = false;
            this.grdcolLoaiCH.Visible = true;
            this.grdcolLoaiCH.VisibleIndex = 1;
            this.grdcolLoaiCH.Width = 137;
            // 
            // grdcolSL
            // 
            this.grdcolSL.Caption = "Số lượng";
            this.grdcolSL.FieldName = "SoLuong";
            this.grdcolSL.Name = "grdcolSL";
            this.grdcolSL.OptionsColumn.AllowEdit = false;
            this.grdcolSL.Visible = true;
            this.grdcolSL.VisibleIndex = 2;
            this.grdcolSL.Width = 137;
            // 
            // grdcolNgayTao
            // 
            this.grdcolNgayTao.Caption = "Ngày tạo";
            this.grdcolNgayTao.FieldName = "NgayTao";
            this.grdcolNgayTao.Name = "grdcolNgayTao";
            this.grdcolNgayTao.OptionsColumn.AllowEdit = false;
            this.grdcolNgayTao.Visible = true;
            this.grdcolNgayTao.VisibleIndex = 3;
            this.grdcolNgayTao.Width = 137;
            // 
            // grdcolTrangThai
            // 
            this.grdcolTrangThai.Caption = "Trạng thái";
            this.grdcolTrangThai.FieldName = "TrangThai";
            this.grdcolTrangThai.Name = "grdcolTrangThai";
            this.grdcolTrangThai.OptionsColumn.AllowEdit = false;
            this.grdcolTrangThai.Visible = true;
            this.grdcolTrangThai.VisibleIndex = 4;
            this.grdcolTrangThai.Width = 147;
            // 
            // grdcolID
            // 
            this.grdcolID.Caption = "ID";
            this.grdcolID.FieldName = "ID";
            this.grdcolID.Name = "grdcolID";
            // 
            // FrmLoaiCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmLoaiCauHoi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại câu hỏi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLoaiMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLoaiMonHoc)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem btnAdd;
        private DevExpress.XtraBars.BarLargeButtonItem btnCopy;
        private DevExpress.XtraBars.BarLargeButtonItem btnEdit;
        private DevExpress.XtraBars.BarLargeButtonItem btnDuyet;
        private DevExpress.XtraBars.BarLargeButtonItem btnDel;
        private DevExpress.XtraBars.BarLargeButtonItem btnClose;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grdLoaiMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLoaiMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolMaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolLoaiCH;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolSL;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolID;
    }
}