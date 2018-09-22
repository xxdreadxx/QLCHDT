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
    public partial class FrmDanhSachDeThi : Form
    {
        DeThiBLL bL = new DeThiBLL();
        public int Thang;
        public int Nam;
        public FrmDanhSachDeThi()
        {
            InitializeComponent();
        }

        private void FrmDanhSachDeThi_Load(object sender, EventArgs e)
        {
            grdData.DataSource = bL.GetAllTest(Thang, Nam);
        }

        private void btnTaoDeThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTaoDeThi frm = new FrmTaoDeThi();
            frm.Thang = Thang;
            frm.Nam = Nam;
            frm.ShowDialog();
                
        }
    }
}
