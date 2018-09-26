using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace QLCH.Forms
{
    public partial class FrmLoaiDeThi : Form
    {
        public string idLoaiDeThi;
        public FrmLoaiDeThi()
        {
            InitializeComponent();
        }
        DeThiBLL dt = new DeThiBLL();
        private void FrmLoaiDeThi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                idLoaiDeThi = grvData.GetRowCellValue(grvData.FocusedRowHandle, grdcolIDLoai.FieldName).ToString();
                this.Close();
            }
           

        }

        private void FrmLoaiDeThi_Load(object sender, EventArgs e)
        {
            grdData.DataSource = dt.GetListLoaiDeThi();
        }
    }
}
