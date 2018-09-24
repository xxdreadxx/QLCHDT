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
        AccountInfor acc = new AccountInfor();
        private void btnLuuBaiThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ckdTuyChonNangCao.Checked  == true)
            {
                bL.CreateAutoTest(txtLoaiBaiThi.Text, txtMonHoc.Text, acc.IdAccount, txtMaDe.Text, int.Parse(txtTuBai.Text), int.Parse(txtDenBai.Text),ngay, thang, nam);
            }else
            {
                bL.CreateTest(txtLoaiBaiThi.Text, 
                    txtMonHoc.Text,
                    acc.IdAccount, txtMaDe.Text, 
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

        }
    }
}
