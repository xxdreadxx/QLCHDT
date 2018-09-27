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
    public partial class FrmBaiHoc_Add : Form
    {
        BaiHocBLL bh = new BaiHocBLL();
        MonHocBLL mh = new MonHocBLL();
        ChuongBaiBLL cb = new ChuongBaiBLL();
        public FrmBaiHoc_Add()
        {
            InitializeComponent();
        }


        private void btnLuuThayDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bh.CreateBaiHoc(txtMaBaiHoc.Text,txttenBaiHoc.Text,txtMaChuongBai.Tag.ToString(),txtNoiDung.Text,int.Parse(txtKhoiLop.Text),txtmaMon.Tag.ToString());
            MessageBox.Show("Hoàn thành");
        }

        private void txtmaMon_Leave(object sender, EventArgs e)
        {
            frmMonHoc frmMH = new frmMonHoc();
            frmMH.khoiLop = int.Parse(txtKhoiLop.Text);
            frmMH.ShowDialog();
            if (frmMH.idMonHoc != null)
            {
                txtmaMon.Text = mh.getMaMonHocByID(frmMH.idMonHoc);
                txtTenMon.Text = mh.getTenMonHocByID(frmMH.idMonHoc);
                txtmaMon.Tag = frmMH.idMonHoc;
            }
        }

        private void txtMaChuongBai_Leave(object sender, EventArgs e)
        {
            FrmChuongBai frmCB = new FrmChuongBai();
            frmCB.idMonHoc = txtmaMon.Tag.ToString();
            frmCB.ShowDialog();
            if (frmCB.idChuongBai != null)
            {
                txtMaChuongBai.Text = cb.getMaChuongBaiByID(frmCB.idChuongBai);
                txtTenChuongBai.Text = cb.getTenChuongBaiByID(frmCB.idChuongBai);
                txtMaChuongBai.Tag = frmCB.idChuongBai;
            }
        }

        private void FrmBaiHoc_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnLuuThayDoi_ItemClick(null, null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
