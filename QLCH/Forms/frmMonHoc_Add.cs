using System;
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
    public partial class frmMonHoc_Add : Form
    {
        MonHocBLL monHoc = new MonHocBLL();
        public frmMonHoc_Add()
        {
            InitializeComponent();
        }
        public int khoi;
        public string mamon;
        public string tenmon;

        private void btnLuuThayDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Luu();
        }

        private void Luu()
        {
            if (txtmaMon.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã môn học", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaMon.Focus();
            }
            else
            {
                if (txtTenMonHoc.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập tên môn học", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenMonHoc.Focus();
                }
            }
            if (txtmaMon.Text.Trim() != "" && txtTenMonHoc.Text.Trim() != "")
            {
                MonHoc m = monHoc.GetMonHocByMaMon(txtmaMon.Text);
                if (m != null)
                {
                    MessageBox.Show("Đã tồn tại mã môn học này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmaMon.SelectionLength = txtKhoiLop.Text.Length;
                }
                else
                {
                    monHoc.MonHoc_Add(txtmaMon.Text, int.Parse(txtKhoiLop.Text), txtTenMonHoc.Text);
                    MessageBox.Show("Hoàn thành");
                }
            }
        }

        private void frmMonHoc_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnLuuThayDoi_ItemClick(null,null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmMonHoc_Add_Load(object sender, EventArgs e)
        {
            if(mamon!=null || tenmon != null)
            {
                txtKhoiLop.Text = khoi.ToString();
                txtmaMon.Text = mamon;
                txtTenMonHoc.Text = tenmon;
                txtKhoiLop.Focus();
                txtKhoiLop.SelectionLength = txtKhoiLop.Text.Length;
            }
        }

        private void txtKhoiLop_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmaMon.SelectionLength = txtKhoiLop.Text.Length;
            }
        }

        private void txtmaMon_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTenMonHoc.SelectionLength = txtKhoiLop.Text.Length;
            }
        }

        private void txtTenMonHoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Luu();
            }
        }
    }
}
