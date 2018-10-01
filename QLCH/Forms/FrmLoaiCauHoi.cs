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
    public partial class FrmLoaiCauHoi : Form
    {
        BindingSource bindSource = new BindingSource();
        LoaiCauHoiBLL bll = new LoaiCauHoiBLL();

        public FrmLoaiCauHoi()
        {
            InitializeComponent();
        }

        private void FrmLoaiCauHoi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<clsLoaiCauHoi> listAllLoai = new List<clsLoaiCauHoi>();
            List<LoaiCauHoi> lstLoaiCH = new List<LoaiCauHoi>();
            lstLoaiCH = bll.getAll();

            if (lstLoaiCH.Count != 0)
            {
                foreach (var item in lstLoaiCH)
                {
                    clsLoaiCauHoi loai = new clsLoaiCauHoi();
                    loai.ID = item.ID;
                    loai.MaLoaiCauHoi = item.MaLoai;
                    loai.LoaiCH = item.LoaiCauHoi1;
                    loai.SoLuong = (int)item.SoLuong;
                    loai.NgayTao = (DateTime)item.CreatedDate;
                    if (item.InUsed == true)
                    {
                        loai.TrangThai = "Đã sử dụng";
                    }
                    else
                    {
                        loai.TrangThai = "Chưa sử dụng";
                    }
                    listAllLoai.Add(loai);
                }
            }
            bindSource.DataSource = listAllLoai;
            grdLoaiCauHoi.DataSource = bindSource.DataSource;
            grdLoaiCauHoi.RefreshDataSource();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLoaiCauHoi_Add frm = new FrmLoaiCauHoi_Add();
            frm.ShowDialog();
            LoadData();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int focus = grvLoaiCauHoi.FocusedRowHandle;
            string ID = grvLoaiCauHoi.GetRowCellValue(focus, grdcolID).ToString();
            bll.Del(ID);
            LoadData();
        }

        private void btnDuyet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int focus = grvLoaiCauHoi.FocusedRowHandle;
            string ID = grvLoaiCauHoi.GetRowCellValue(focus, grdcolID).ToString();
            bll.Change(ID);
        }
    }
}
