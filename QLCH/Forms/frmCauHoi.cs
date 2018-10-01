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
    public partial class frmCauHoi : Form
    {
        CauHoiBLL ch = new CauHoiBLL();
        public frmCauHoi()
        {
            InitializeComponent();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCauHoi_Add frm = new frmCauHoi_Add();
            frm.ShowDialog();
            grdData.DataSource = ch.GetAllListCauHoi();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmCauHoi_Load(object sender, EventArgs e)
        {
            grdData.DataSource = ch.GetAllListCauHoi();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int focus = grvData.FocusedRowHandle;
            string ID = grvData.GetRowCellValue(focus, grdID).ToString();
            CauHoi cauHoi = ch.GetByID(ID);
            string s = cauHoi.NoiDung;
            rteND.RtfText = s;
            //MessageBox.Show(text); 
            
        }
    }
}
