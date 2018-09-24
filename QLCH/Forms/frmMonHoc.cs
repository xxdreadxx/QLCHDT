using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QLCH.Forms
{
    public partial class frmMonHoc : Form
    {
        BindingSource bindSource = new BindingSource();
        MonHocBLL monHoc = new MonHocBLL();
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMonHoc_Add frm = new frmMonHoc_Add();
            frm.ShowDialog();
            frmMonHoc_Load(sender, e);
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            List<clsMonHoc> listAllMonHoc = new List<clsMonHoc>();
            List<MonHoc> lstMonHoc = monHoc.GetAllMonHoc();
            if (lstMonHoc.Count != 0)
            {
                foreach(var item in lstMonHoc)
                {
                    clsMonHoc mh = new clsMonHoc();
                    mh.ID = item.ID;
                    mh.Khoi = (int)item.Khoi;
                    mh.MaMon = item.MaMonHoc;
                    mh.TenMon = item.TenMonHoc;
                    mh.SoCauHoi = (int)item.SoCauHoi;
                    mh.NgayTao = (DateTime)item.CreateDate;
                    if (item.InUsed == true)
                    {
                        mh.TrangThai = "Đã sử dụng";
                    }
                    else
                    {
                        mh.TrangThai = "Chưa sử dụng";
                    }
                    listAllMonHoc.Add(mh);
                }
            }
            bindSource.DataSource = listAllMonHoc;
            grdMonHoc.DataSource = bindSource.DataSource;
            grdMonHoc.RefreshDataSource();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int focus = grvMonHoc.FocusedRowHandle;
            string ID = grvMonHoc.GetRowCellValue(focus, grdcolID).ToString();
            monHoc.MonHoc_Del(ID);
            frmMonHoc_Load(sender, e);
        }

        private void btnDuyet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int focus = grvMonHoc.FocusedRowHandle;
            string ID = grvMonHoc.GetRowCellValue(focus, grdcolID).ToString();
            monHoc.MonHoc_Change(ID);
            frmMonHoc_Load(sender, e);
        }

        private void btnCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int focus = grvMonHoc.FocusedRowHandle;
            string ID = grvMonHoc.GetRowCellValue(focus, grdcolID).ToString();
            MonHoc mh = monHoc.GetMonHocByID(ID);
            frmMonHoc_Add frm = new frmMonHoc_Add();
            frm.khoi = (int)mh.Khoi;
            frm.mamon = mh.MaMonHoc;
            frm.ShowDialog();
            frmMonHoc_Load(sender, e);
        }
    }
}
