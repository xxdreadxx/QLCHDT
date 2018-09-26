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
    public partial class FrmChuongBai_Add : Form
    {
        ChuongBaiBLL cb = new ChuongBaiBLL();
        public FrmChuongBai_Add()
        {
            InitializeComponent();
        }

        private void btnLuuThayDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cb.CreateChuongBai(txtmaMon.Text, int.Parse(txtSoChuong.Text), txtTenChuongBai.Text, txtMaChuong.Text, int.Parse(txtSobai.Text));
        }
    }
}
