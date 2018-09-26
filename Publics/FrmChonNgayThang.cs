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
    public partial class FrmChonNgayThang : Form
    {
        public int ngay;
        public int thang;
        public int nam;
        public FrmChonNgayThang()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtNgay.Text.Trim() == "")
            {
                MessageBox.Show("Ngày không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtThang.Text.Trim() == "")
            {
                MessageBox.Show("Tháng không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtNam.Text.Trim() == "")
            {
                MessageBox.Show("Năm không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ngay = int.Parse(txtNgay.Text);
            thang = int.Parse(txtThang.Text);
            nam = int.Parse(txtNam.Text);
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmChonNgayThang_Load(object sender, EventArgs e)
        {
            txtNgay.Properties.MaxLength = 2;
            txtThang.Properties.MaxLength = 2;
            txtNgay.Properties.MaxLength = 4;
        }
    }
}
