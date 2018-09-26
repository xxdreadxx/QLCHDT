﻿using System;
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
        public FrmBaiHoc_Add()
        {
            InitializeComponent();
        }


        private void btnLuuThayDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bh.CreateBaiHoc(txtMaBaiHoc.Text,txttenBaiHoc.Text,txtMaChuongBai.Text,txtNoiDung.Text,int.Parse(txtKhoiLop.Text),txtmaMon.Text);
        }
    }
}
