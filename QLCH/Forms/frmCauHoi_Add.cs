using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Forms
{
    public partial class frmCauHoi_Add : Form
    {
        public frmCauHoi_Add()
        {
            InitializeComponent();
        }

        private void frmCauHoi_Add_Load(object sender, EventArgs e)
        {

        }

        private void rdDungSai_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txt3.Visible = false;
            txt4.Visible = false;
            chk1.Visible = true;
            chk2.Visible = true;
        }
    }
}
