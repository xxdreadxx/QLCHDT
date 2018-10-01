using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace QLCH.Forms
{
    public partial class FrmLoaiCauHoi_Add : Form
    {
        LoaiCauHoiBLL bll = new LoaiCauHoiBLL();

        public FrmLoaiCauHoi_Add()
        {
            InitializeComponent();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FrmLoaiCauHoi_Add_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMaLoai.Text.Trim()!=""&& txtTenLoai.Text.Trim() != "")
            {
                bll.Add(txtMaLoai.Text.Trim(), txtTenLoai.Text.Trim());
            }
            this.Close();
        }
    }
}
