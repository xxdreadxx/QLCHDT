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
    public partial class frmMonHoc_Add : Form
    {
        MonHocBLL monHoc = new MonHocBLL();
        public frmMonHoc_Add()
        {
            InitializeComponent();
        }
        public int khoi;
        public string mamon;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuThayDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            monHoc.MonHoc_Add(txtmaMon.Text, int.Parse(txtKhoiLop.Text), txtTenMonHoc.Text);
            MessageBox.Show("Hoàn thành");
        }

        private void frmMonHoc_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnLuuThayDoi_ItemClick(null,null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
