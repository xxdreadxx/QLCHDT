using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DTO;
using BLL;
using Publics;

namespace QLCH.Reports
{
    public partial class rptDeThi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDeThi()
        {
            InitializeComponent();
        }

        private void rptDeThi_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //xrRichText1.Rtf= ""
        }
    }
}
