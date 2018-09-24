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
            if (typeChon == 1)
            {
                ckdChonTheoNgay.Enabled = true;// theo ngày
                txtTuNgay.Enabled = true;
                txtDenNgay.Enabled = true;
                txtTuThang1.Enabled = true;
                txtTuNam1.Enabled = true;
                txtDenNam1.Enabled = true;
                txtDenThang1.Enabled = true;
                ckdChonTheoThang.Enabled = false;//theo tháng
                txtTuThang2.Enabled = false;
                txtTuNam2.Enabled = false;
                txtDenNam2.Enabled = false;
                txtDenThang2.Enabled = false;
                ckdChonTheoNam.Enabled = false;//theo năm
                txtTuNam3.Enabled = false;
                txtDenNam3.Enabled = false;
            }
            if (typeChon == 2)
            {
                ckdChonTheoNgay.Enabled = false;// theo ngày
                txtTuNgay.Enabled = false;
                txtDenNgay.Enabled = false;
                txtTuThang1.Enabled = false;
                txtTuNam1.Enabled = false;
                txtDenNam1.Enabled = false;
                txtDenThang1.Enabled = false;
                ckdChonTheoThang.Enabled = true;//theo tháng
                txtTuThang2.Enabled = true;
                txtTuNam2.Enabled = true;
                txtDenNam2.Enabled = true;
                txtDenThang2.Enabled = true;
                ckdChonTheoNam.Enabled = false;//theo năm
                txtTuNam3.Enabled = false;
                txtDenNam3.Enabled = false;
            }
            if (typeChon == 3)
            {
                ckdChonTheoNgay.Enabled = false;// theo ngày
                txtTuNgay.Enabled = false;
                txtDenNgay.Enabled = false;
                txtTuThang1.Enabled = false;
                txtTuNam1.Enabled = false;
                txtDenNam1.Enabled = false;
                txtDenThang1.Enabled = false;
                ckdChonTheoThang.Enabled = false;//theo tháng
                txtTuThang2.Enabled = false;
                txtTuNam2.Enabled = false;
                txtDenNam2.Enabled = false;
                txtDenThang2.Enabled = false;
                ckdChonTheoNam.Enabled = true;//theo năm
                txtTuNam3.Enabled = true;
                txtDenNam3.Enabled = true;
            }
        }

        private void ckdChonTheoNgay_Click(object sender, EventArgs e)
        {
            typeChon = 1;
            ckdChonTheoNgay.CheckState = CheckState.Checked;
        }

        private void ckdChonTheoThang_Click(object sender, EventArgs e)
        {
            typeChon = 2;
            ckdChonTheoThang.CheckState = CheckState.Checked;
        }

        private void ckdChonTheoNam_Click(object sender, EventArgs e)
        {
            typeChon = 3;
            ckdChonTheoNam.CheckState = CheckState.Checked;
        }
    }
}
