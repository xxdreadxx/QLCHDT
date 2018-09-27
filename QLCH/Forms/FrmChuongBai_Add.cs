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
    public partial class FrmChuongBai_Add : Form
    {
        ChuongBaiBLL cb = new ChuongBaiBLL();
        MonHocBLL mh = new MonHocBLL();
        public FrmChuongBai_Add()
        {
            InitializeComponent();
        }

        private void btnLuuThayDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cb.CreateChuongBai(txtmaMon.Tag.ToString(), int.Parse(txtSoChuong.Text), txtTenChuongBai.Text, txtMaChuong.Text, int.Parse(txtSobai.Text));
            MessageBox.Show("Hoàn thành.");
        }

        private void txtmaMon_Enter(object sender, EventArgs e)
        {
            frmMonHoc frmMH = new frmMonHoc();
            frmMH.ShowDialog();
            if (frmMH.idMonHoc != null)
            {
                txtmaMon.Text = mh.getMaMonHocByID(frmMH.idMonHoc);
                txtmaMon.Tag = frmMH.idMonHoc;
                txtTenMon.Text = mh.getTenMonHocByID(frmMH.idMonHoc);
            }
        }

        private void FrmChuongBai_Add_Load(object sender, EventArgs e)
        {
            txtMaChuong.Focus();
        }

        private void FrmChuongBai_Add_KeyDown(object sender, KeyEventArgs e)
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
