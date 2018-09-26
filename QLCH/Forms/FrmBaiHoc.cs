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

namespace QLCH.Forms
{
    public partial class FrmBaiHoc : Form
    {
        public string idBaiHoc;
        public FrmBaiHoc()
        {
            InitializeComponent();
        }

        private void FrmBaiHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                idBaiHoc = grvData.GetRowCellValue(grvData.FocusedRowHandle, grdcolID.FieldName).ToString();
                this.Close();
            }
        }
    }
}
