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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenMon = "";
            khoi = int.Parse(cbKhoi.SelectedItem.ToString());
            mamon = cbMon.SelectedItem.ToString();
            if (mamon == "TOAN") { tenMon = "Toán"; }
            if (mamon == "VAN") { tenMon = "Ngữ văn"; }
            if (mamon == "VATLY") { tenMon = "Vật lý"; }
            if (mamon == "HOA") { tenMon = "Hóa học"; }
            if (mamon == "GDCD") { tenMon = "Giáo dục công dân"; }
            if (mamon == "SINH") { tenMon = "Sinh học"; }
            if (mamon == "DIA") { tenMon = "Địa"; }
            if (mamon == "SU") { tenMon = "Lịch sử"; }
            if (mamon == "TIENGANH") { tenMon = "Tiếng anh"; }
            monHoc.MonHoc_Add(mamon, khoi, tenMon);
            this.Close();
        }

        private void frmMonHoc_Add_Load(object sender, EventArgs e)
        {
            cbMon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKhoi.DropDownStyle = ComboBoxStyle.DropDownList;
            if(mamon!=null)
            {
                cbKhoi.Text = khoi.ToString();
                cbMon.Text = mamon;
            }
        }
    }
}
