using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Publics
{
    public partial class FrmChonNgayThangNam : Form
    {
        public int tuNgay;
        public int tuThang;
        public int tuNam;
        public int denNgay;
        public int denThang;
        public int denNam;
        public int typeChon = 1;// 1: chọn theo ngày, 2: chọn theo tháng, 3: chọn theo năm
        public FrmChonNgayThangNam()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (ckdChonTheoNgay.Checked == true)
            {
                tuNgay = int.Parse(txtTuNgay.Text);
                tuThang = int.Parse(txtTuThang1.Text);
                tuNam = int.Parse(txtTuNam1.Text);
                denNgay = int.Parse(txtDenNgay.Text);
                denThang = int.Parse(txtDenThang1.Text);
                denNam = int.Parse(txtDenNam1.Text);
            }
            if (ckdChonTheoThang.Checked == true)
            {
                tuNgay = 1;
                tuThang = int.Parse(txtTuThang2.Text);
                tuNam = int.Parse(txtTuNam2.Text);
                denNgay = 31;
                denThang = int.Parse(txtDenThang2.Text);
                denNam = int.Parse(txtDenNam2.Text);
            }
            if (ckdChonTheoNam.Checked == true)
            {
                tuNgay = 1;
                tuThang = 1;
                tuNam = int.Parse(txtTuNam3.Text);
                denNgay = 31;
                denThang = 12;
                denNam = int.Parse(txtDenNam3.Text);
            }
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChonNgayThangNam_Load(object sender, EventArgs e)
        {
            ckdChonTheoNgay.Enabled = true;// theo ngày
            ckdChonTheoNgay.Checked = true;
            txtTuNgay.Enabled = true;
            txtDenNgay.Enabled = true;
            txtTuThang1.Enabled = true;
            txtTuNam1.Enabled = true;
            txtDenNam1.Enabled = true;
            txtDenThang1.Enabled = true;
            //ckdChonTheoThang.Enabled = true;//theo tháng
            ckdChonTheoThang.Checked = false;
            txtTuThang2.Enabled = false;
            txtTuNam2.Enabled = false;
            txtDenNam2.Enabled = false;
            txtDenThang2.Enabled = false;
            //ckdChonTheoNam.Enabled = false;//theo năm
            ckdChonTheoNam.Checked = false;
            txtTuNam3.Enabled = false;
            txtDenNam3.Enabled = false;

            txtTuNgay.Properties.MaxLength = 2;
            txtDenNgay.Properties.MaxLength = 2;
            txtTuThang1.Properties.MaxLength = 2;
            txtTuNam1.Properties.MaxLength = 4;
            txtDenNam1.Properties.MaxLength = 4;
            txtDenThang1.Properties.MaxLength = 2;
            txtTuThang2.Properties.MaxLength = 2;
            txtTuNam2.Properties.MaxLength = 4;
            txtDenNam2.Properties.MaxLength = 4;
            txtDenThang2.Properties.MaxLength = 2;
            txtTuNam3.Properties.MaxLength = 4;
            txtDenNam3.Properties.MaxLength = 4;
            txtTuNgay.Focus();
        }

        private void ckdChonTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (ckdChonTheoNgay.Checked == true)
            {
                ckdChonTheoNgay.Checked = true;
                txtTuNgay.Enabled = true;
                txtDenNgay.Enabled = true;
                txtTuThang1.Enabled = true;
                txtTuNam1.Enabled = true;
                txtDenNam1.Enabled = true;
                txtDenThang1.Enabled = true;
                ckdChonTheoThang.Checked = false;
                txtTuThang2.Enabled = false;
                txtTuThang2.Text = "";
                txtTuNam2.Enabled = false;
                txtTuNam2.Text = "";
                txtDenNam2.Enabled = false;
                txtDenNam2.Text = "";
                txtDenThang2.Enabled = false;
                txtDenThang2.Text = "";
                ckdChonTheoNam.Checked = false;
                txtTuNam3.Enabled = false;
                txtTuNam3.Text = "";
                txtDenNam3.Enabled = false;
                txtDenNam3.Text = "";
            }
        }

        private void ckdChonTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (ckdChonTheoThang.Checked == true)
            {
                ckdChonTheoNgay.Checked = false;
                txtTuNgay.Enabled = false;
                txtTuNgay.Text = "";
                txtDenNgay.Enabled = false;
                txtDenNgay.Text = "";
                txtTuThang1.Enabled = false;
                txtTuThang1.Text = "";
                txtTuNam1.Enabled = false;
                txtTuNam1.Text = "";
                txtDenNam1.Enabled = false;
                txtDenNam1.Text = "";
                txtDenThang1.Enabled = false;
                txtDenThang1.Text = "";
                ckdChonTheoThang.Checked = true;
                txtTuThang2.Enabled = true;
                txtTuNam2.Enabled = true;
                txtDenNam2.Enabled = true;
                txtDenThang2.Enabled = true;
                ckdChonTheoNam.Checked = false;
                txtTuNam3.Enabled = false;
                txtTuNam3.Text = "";
                txtDenNam3.Enabled = false;
                txtDenNam3.Text = "";
                txtTuThang2.Focus();
            }
        }

        private void ckdChonTheoNam_CheckedChanged(object sender, EventArgs e)
        {
            if (ckdChonTheoNam.Checked == true)
            {
                ckdChonTheoNgay.Checked = false;
                txtTuNgay.Enabled = false;
                txtTuNgay.Text = "";
                txtDenNgay.Enabled = false;
                txtDenNgay.Text = "";
                txtTuThang1.Enabled = false;
                txtTuThang1.Text = "";
                txtTuNam1.Enabled = false;
                txtTuNam1.Text = "";
                txtDenNam1.Enabled = false;
                txtDenNam1.Text = "";
                txtDenThang1.Enabled = false;
                txtDenThang1.Text = "";
                ckdChonTheoThang.Checked = false;
                txtTuThang2.Enabled = false;
                txtTuThang2.Text = "";
                txtTuNam2.Enabled = false;
                txtTuNam2.Text = "";
                txtDenNam2.Enabled = false;
                txtDenNam2.Text = "";
                txtDenThang2.Enabled = false;
                txtDenThang2.Text = "";
                ckdChonTheoNam.Checked = true;
                txtTuNam3.Enabled = true;
                txtDenNam3.Enabled = true;
                txtTuNam3.Focus();
            }
        }

        private void txtTuNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTuThang1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTuNam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDenNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDenThang1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDenNam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTuThang2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTuNam2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDenThang2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDenNam2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTuNam3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDenNam3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTuNgay_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTuNgay.Text.Length == 2)
            {
                txtTuThang1.Focus();
            }
        }

        private void txtTuThang1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTuThang1.Text.Length == 2)
            {
                txtTuNam1.Focus();
            }
        }

        private void txtTuNam1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTuNam1.Text.Length == 4)
            {
                txtDenNgay.Focus();
            }
        }

        private void txtDenNgay_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDenNgay.Text.Length == 2)
            {
                txtDenThang1.Focus();
            }
        }

        private void txtDenThang1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDenThang1.Text.Length == 2)
            {
                txtDenNam1.Focus();
            }
        }

        private void txtDenNam1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDenNam1.Text.Length == 4)
            {
                btnDongY.Focus();
            }
        }

        private void txtTuThang2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTuThang2.Text.Length == 2)
            {
                txtTuNam2.Focus();
            }
        }

        private void txtTuNam2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTuNam2.Text.Length == 4)
            {
                txtDenThang2.Focus();
            }
        }

        private void txtDenThang2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDenThang2.Text.Length == 2)
            {
                txtDenNam2.Focus();
            }
        }

        private void txtDenNam2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDenNam2.Text.Length == 4)
            {
                btnDongY.Focus();
            }
        }

        private void txtTuNam3_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTuNam3.Text.Length == 4)
            {
                txtDenNam3.Focus();
            }
        }

        private void txtDenNam3_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDenNam3.Text.Length == 4)
            {
                btnDongY.Focus();
            }
        }
    }
}
