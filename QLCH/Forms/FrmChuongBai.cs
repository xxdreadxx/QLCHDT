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
    public partial class FrmChuongBai : Form
    {
        ChuongBaiBLL cb = new ChuongBaiBLL();
        public string idChuongBai;
        public FrmChuongBai()
        {
            InitializeComponent();
        }

        private void FrmChuongBai_Load(object sender, EventArgs e)
        {
            grdData.DataSource = cb.GetAllListChuongBai();
        }

        private void FrmChuongBai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                idChuongBai = grvData.GetRowCellValue(grvData.FocusedRowHandle, grdcolID.FieldName).ToString();
                this.Close();
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmChuongBai_Add frmCBA = new FrmChuongBai_Add();
            frmCBA.ShowDialog();
        }
    }
}
