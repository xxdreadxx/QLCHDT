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

namespace QLCH.Forms
{
    public partial class FrmBaiHoc : Form
    {
        BaiHocBLL bh = new BaiHocBLL();
        public string idBaiHoc;
        public string idChuongBai;
        public FrmBaiHoc()
        {
            InitializeComponent();
        }

        private void FrmBaiHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                idBaiHoc = grvData.GetRowCellValue(grvData.FocusedRowHandle, grdcolID.FieldName).ToString();
                this.Close();
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBaiHoc_Add frmBHA = new FrmBaiHoc_Add();
            frmBHA.ShowDialog();
            FrmBaiHoc_Load(sender, e);
            
        }

        private void FrmBaiHoc_Load(object sender, EventArgs e)
        {
            if (idChuongBai != null)
            {
                grdData.DataSource = bh.getListAllBaiHocByidChuong(idChuongBai);
            }
            else
            {
                grdData.DataSource = bh.getListAllBaiHoc();
            }
            
        }
    }
}
