namespace QLCH.Forms
{
    partial class frmMonHoc
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnCopy = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDuyet = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grdMonHoc = new DevExpress.XtraGrid.GridControl();
            this.grvMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdcolKhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolMaMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolTenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolSLCauHoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonHoc)).BeginInit();
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
            this.btnDel,
            this.btnClose,
            this.btnDuyet});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCopy, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDuyet, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm mới";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageUri.Uri = "Add";
            this.btnAdd.MinSize = new System.Drawing.Size(65, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnCopy
            // 
            this.btnCopy.Caption = "Sao chép";
            this.btnCopy.Id = 2;
            this.btnCopy.ImageUri.Uri = "Copy";
            this.btnCopy.MinSize = new System.Drawing.Size(65, 0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCopy_ItemClick);
            // 
            // btnDuyet
            // 
            this.btnDuyet.Caption = "Duyệt";
            this.btnDuyet.Id = 5;
            this.btnDuyet.ImageUri.Uri = "Apply";
            this.btnDuyet.MinSize = new System.Drawing.Size(65, 0);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDuyet_ItemClick);
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Xóa";
            this.btnDel.Id = 3;
            this.btnDel.ImageUri.Uri = "Delete";
            this.btnDel.MinSize = new System.Drawing.Size(65, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 4;
            this.btnClose.ImageUri.Uri = "Close";
            this.btnClose.MinSize = new System.Drawing.Size(65, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
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
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.grdMonHoc);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 65);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(752, 328);
            this.groupControl1.TabIndex = 9;
            // 
            // grdMonHoc
            // 
            this.grdMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMonHoc.Location = new System.Drawing.Point(2, 20);
            this.grdMonHoc.MainView = this.grvMonHoc;
            this.grdMonHoc.MenuManager = this.barManager1;
            this.grdMonHoc.Name = "grdMonHoc";
            this.grdMonHoc.Size = new System.Drawing.Size(748, 306);
            this.grdMonHoc.TabIndex = 0;
            this.grdMonHoc.UseEmbeddedNavigator = true;
            this.grdMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMonHoc});
            // 
            // grvMonHoc
            // 
            this.grvMonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdcolKhoi,
            this.grdcolMaMon,
            this.grdcolTenMon,
            this.grdcolSLCauHoi,
            this.grdcolNgayTao,
            this.grdcolTrangThai,
            this.grdcolID});
            this.grvMonHoc.GridControl = this.grdMonHoc;
            this.grvMonHoc.Name = "grvMonHoc";
            this.grvMonHoc.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // grdcolKhoi
            // 
            this.grdcolKhoi.AppearanceCell.Options.UseTextOptions = true;
            this.grdcolKhoi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdcolKhoi.Caption = "Khối";
            this.grdcolKhoi.FieldName = "Khoi";
            this.grdcolKhoi.Name = "grdcolKhoi";
            this.grdcolKhoi.OptionsColumn.AllowEdit = false;
            this.grdcolKhoi.Visible = true;
            this.grdcolKhoi.VisibleIndex = 0;
            this.grdcolKhoi.Width = 35;
            // 
            // grdcolMaMon
            // 
            this.grdcolMaMon.Caption = "Mã môn học";
            this.grdcolMaMon.FieldName = "MaMon";
            this.grdcolMaMon.Name = "grdcolMaMon";
            this.grdcolMaMon.OptionsColumn.AllowEdit = false;
            this.grdcolMaMon.Visible = true;
            this.grdcolMaMon.VisibleIndex = 1;
            this.grdcolMaMon.Width = 137;
            // 
            // grdcolTenMon
            // 
            this.grdcolTenMon.Caption = "Tên môn học";
            this.grdcolTenMon.FieldName = "TenMon";
            this.grdcolTenMon.Name = "grdcolTenMon";
            this.grdcolTenMon.OptionsColumn.AllowEdit = false;
            this.grdcolTenMon.Visible = true;
            this.grdcolTenMon.VisibleIndex = 2;
            this.grdcolTenMon.Width = 137;
            // 
            // grdcolSLCauHoi
            // 
            this.grdcolSLCauHoi.Caption = "Số câu hỏi";
            this.grdcolSLCauHoi.FieldName = "SoCauHoi";
            this.grdcolSLCauHoi.Name = "grdcolSLCauHoi";
            this.grdcolSLCauHoi.OptionsColumn.AllowEdit = false;
            this.grdcolSLCauHoi.Visible = true;
            this.grdcolSLCauHoi.VisibleIndex = 3;
            this.grdcolSLCauHoi.Width = 137;
            // 
            // grdcolNgayTao
            // 
            this.grdcolNgayTao.Caption = "Ngày tạo";
            this.grdcolNgayTao.FieldName = "NgayTao";
            this.grdcolNgayTao.Name = "grdcolNgayTao";
            this.grdcolNgayTao.OptionsColumn.AllowEdit = false;
            this.grdcolNgayTao.Visible = true;
            this.grdcolNgayTao.VisibleIndex = 4;
            this.grdcolNgayTao.Width = 137;
            // 
            // grdcolTrangThai
            // 
            this.grdcolTrangThai.Caption = "Trạng thái";
            this.grdcolTrangThai.FieldName = "TrangThai";
            this.grdcolTrangThai.Name = "grdcolTrangThai";
            this.grdcolTrangThai.OptionsColumn.AllowEdit = false;
            this.grdcolTrangThai.Visible = true;
            this.grdcolTrangThai.VisibleIndex = 5;
            this.grdcolTrangThai.Width = 147;
            // 
            // grdcolID
            // 
            this.grdcolID.Caption = "ID";
            this.grdcolID.FieldName = "ID";
            this.grdcolID.Name = "grdcolID";
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frmMonHoc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khối- Môn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMonHoc_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonHoc)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem btnDel;
        private DevExpress.XtraBars.BarLargeButtonItem btnClose;
        private DevExpress.XtraBars.BarLargeButtonItem btnDuyet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grdMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolKhoi;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolMaMon;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolTenMon;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolSLCauHoi;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolID;
    }
}