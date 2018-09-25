using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Publics;

namespace QLCH.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQLCauHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCauHoi frm = new frmCauHoi();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnQLDeThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmChonNgayThangNam frmNTN = new FrmChonNgayThangNam();
            frmNTN.ShowDialog();
            if (frmNTN.tuNgay.ToString() == null && frmNTN.tuThang.ToString() == null && frmNTN.tuNam.ToString() == null)
            {
                return;
            }
            else
            {
                FrmDanhSachDeThi frm = new FrmDanhSachDeThi();
                frm.tuNgay = frmNTN.tuNgay;
                frm.tuThang = frmNTN.tuThang;
                frm.tuNam = frmNTN.tuNam;
                frm.denNgay = frmNTN.denNgay;
                frm.denThang = frmNTN.denThang;
                frm.denNam = frmNTN.denNam;
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
           
        }

        private void btnQLMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FrmLogin frm = new FrmLogin();
            frm.Show();
            //this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
