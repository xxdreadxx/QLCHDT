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
        public int thang;
        public int nam;
        public FrmChonNgayThang()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            thang = int.Parse(txtThang.Text);
            nam = int.Parse(txtNam.Text);
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
