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
            rd1.Checked = true;
        }

        private void rdDungSai_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            txt1.Visible = true;
            txt1.Text = "Đúng";
            txt2.Visible = true;
            txt2.Text = "Sai";
            txt3.Visible = false;
            txt4.Visible = false;
            chk1.Visible = true;
            chk2.Visible = true;
            chk3.Visible = false;
            chk4.Visible = false;
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            label7.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txt1.Visible = true;
            txt1.Text = "";
            txt2.Visible = true;
            txt2.Text = "";
            txt3.Visible = true;
            txt4.Visible = true;
            chk1.Visible = true;
            chk2.Visible = true;
            chk3.Visible = true;
            chk4.Visible = true;
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
        }

        private void rdn_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            label7.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txt1.Visible = true;
            txt1.Text = "";
            txt2.Visible = true;
            txt2.Text = "";
            txt3.Visible = true;
            txt4.Visible = true;
            chk1.Visible = true;
            chk2.Visible = true;
            chk3.Visible = true;
            chk4.Visible = true;
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDungSai.Checked == true)
            {
                if (chk1.Checked == true)
                {
                    chk2.Checked = false;
                }
            }
            if (rd1.Checked == true)
            {
                if (chk1.Checked == true)
                {
                    chk2.Checked = false;
                    chk3.Checked = false;
                    chk4.Checked = false;
                }
            }
            if (rdn.Checked == true) { }
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDungSai.Checked == true)
            {
                if (chk2.Checked == true)
                {
                    chk1.Checked = false;
                }
            }
            if (rd1.Checked == true)
            {
                if (chk2.Checked == true)
                {
                    chk1.Checked = false;
                    chk3.Checked = false;
                    chk4.Checked = false;
                }
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (rd1.Checked == true)
            {
                if (chk3.Checked == true)
                {
                    chk1.Checked = false;
                    chk2.Checked = false;
                    chk4.Checked = false;
                }
            }
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (rd1.Checked == true)
            {
                if (chk4.Checked == true)
                {
                    chk1.Checked = false;
                    chk2.Checked = false;
                    chk3.Checked = false;
                }
            }
        }
    }
}
