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
using Publics;

namespace QLCH.Forms
{
    public partial class FrmDanhSachDeThi : Form
    {
        DeThiBLL bL = new DeThiBLL();
        public int tuNgay;
        public int tuThang;
        public int tuNam;
        public int denNgay;
        public int denThang;
        public int denNam;
        public FrmDanhSachDeThi()
        {
            InitializeComponent();
        }

        private void FrmDanhSachDeThi_Load(object sender, EventArgs e)
        {
            grdData.DataSource = bL.GetAllTest(tuNgay,tuThang, tuNam,denNgay,denThang,denNam);
        }

        private void btnTaoDeThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmChonNgayThangNam frmThangNam = new FrmChonNgayThangNam();
            frmThangNam.typeChon = 
            FrmTaoDeThi frm = new FrmTaoDeThi();
            frm.ngay = tuNgay;
            frm.thang = tuThang;
            frm.nam = tuNam;
            frm.ShowDialog();
                
        }
    }
}
