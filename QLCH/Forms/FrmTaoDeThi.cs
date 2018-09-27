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
using Publics;
namespace QLCH.Forms
{
    public partial class FrmTaoDeThi : Form
    {
        public int ngay;
        public int thang;
        public int nam;
        public FrmTaoDeThi()
        {
            InitializeComponent();
        }
        DeThiBLL bL = new DeThiBLL();
        MonHocBLL mh = new MonHocBLL();
        private void btnLuuBaiThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool state;
            if (ckdTuyChonNangCao.Checked  == false)
            {
                state =  bL.CreateAutoTest(txtLoaiBaiThi.Text, txtMonHoc.Text, AccountInfor.IdAccount, txtMaDe.Text, int.Parse(txtTuBai.Text), int.Parse(txtDenBai.Text),ngay, thang, nam);
            } else
            {
               state =  bL.CreateTest(txtLoaiBaiThi.Text, 
                    txtMonHoc.Text,
                    AccountInfor.IdAccount, txtMaDe.Text, 
                    int.Parse(txtTuBai.Text),
                    int.Parse(txtDenBai.Text), 
                    int.Parse(txtTongSoCau.Text),
                    int.Parse(txtSoLuongCauDe.Text), 
                    int.Parse(txtSoLuongCauTB.Text),
                    int.Parse(txtSoLuongCauKho.Text), 
                    txtTieuDeBaiThi.Text, 
                    txtNguoiTao.Text,
                    txtNguoiKiDuyet.Text, 
                    txtGiaoVienCoiThi1.Text, 
                    txtGiaoVienCoiThi2.Text,
                    txtGhiChu.Text,
                    ngay, thang, nam);
            }
            if (state == true)
            {
                MessageBox.Show("Tạo đề thi thành công");
            }
            Reports.rptDeThi rpt = new Reports.rptDeThi();

        }

        private void txtLoaiBaiThi_Enter(object sender, EventArgs e)
        {
            FrmLoaiDeThi frmLDT = new FrmLoaiDeThi();
            frmLDT.ShowDialog();
            if (frmLDT.idLoaiDeThi != null)
            {
                txtLoaiBaiThi.Text = bL.getMaLoaiDeThiByID(frmLDT.idLoaiDeThi);
                txtTenLoaiBaiThi.Text = bL.getTenLoaiDeThiByID(frmLDT.idLoaiDeThi);
                txtLoaiBaiThi.Tag = frmLDT.idLoaiDeThi;
            }
        }

        private void txtMonHoc_Enter(object sender, EventArgs e)
        {
            frmMonHoc frmMH = new frmMonHoc();
            frmMH.ShowDialog();
            if (frmMH.idMonHoc != null)
            {
                txtMonHoc.Text = mh.getMaMonHocByID(frmMH.idMonHoc);
                txtTenMonHoc.Text = mh.getTenMonHocByID(frmMH.idMonHoc);
                txtMonHoc.Tag = frmMH.idMonHoc;
            }
        }
    }
}
