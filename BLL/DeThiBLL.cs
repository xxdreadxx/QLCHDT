using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   public class DeThiBLL
    {
      static  DeThiDAL dA = new DeThiDAL();
        public List<DeThi> GetAllTest(int tuNgay,int tuThang, int tuNam,int denNgay, int denThang, int denNam)
        {
            List<DeThi> lstDeThi = new List<DeThi>();
            lstDeThi = dA.getAllListTestByCreateDate(tuNgay,tuThang, tuNam,denNgay,denThang,denNam);
            return lstDeThi;
        }
        public bool CreateTest(string idLoaiBaiThi, string idMonHoc, string idAccount, string maDe, int tuBai, int denBai, int tongSoCau, int slCauDe, int slCauTB, int slCauKho, string tieuDeBaiThi, string nguoiTao, string nguoiKyDuyet, string gV1, string gV2, string ghiChu,int ngay, int thang, int nam)
        {
           int state  = dA.CreateAutoTest(idLoaiBaiThi, idMonHoc, idAccount, maDe, tuBai, denBai, tongSoCau, slCauDe, slCauTB, slCauKho, false, tieuDeBaiThi, nguoiTao, nguoiKyDuyet, gV1, gV2, ghiChu,ngay, thang, nam);
            if (state == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CreateAutoTest(string idLoaiBaiThi, string idMonHoc, string idAcc, string maDe, int tuBai, int denBai,int ngay,int thang,int nam)
        {
           int state =  dA.CreateAutoTest(idLoaiBaiThi, idMonHoc, idAcc, maDe, tuBai, denBai, 0, 0, 0, 0, true, "", "", "", "", "", "",ngay, thang, nam);
            if (state == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<LoaiDeThi> GetListLoaiDeThi()
        {
            List<LoaiDeThi> lstLoaiDeThi = new List<LoaiDeThi>();
            lstLoaiDeThi = dA.GetAllLoaiDeThi();
            return lstLoaiDeThi;
        }
        public string getTenLoaiDeThiByID(string idLoaiDeThi)
        {
            string tenLoai = dA.getLoaiDeThiByID(idLoaiDeThi).TenLoai;
            return tenLoai;
        }
        public string getMaLoaiDeThiByID(string idLoaiDeThi)
        {
            string maLoai = dA.getLoaiDeThiByID(idLoaiDeThi).MaLoai;
            return maLoai;
        }
    }
}
