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
        public void CreateTest(string idLoaiBaiThi, string idMonHoc, string idAccount, string maDe, int tuBai, int denBai, int tongSoCau, int slCauDe, int slCauTB, int slCauKho, string tieuDeBaiThi, string nguoiTao, string nguoiKyDuyet, string gV1, string gV2, string ghiChu,int ngay, int thang, int nam)
        {
            dA.CreateAutoTest(idLoaiBaiThi, idMonHoc, idAccount, maDe, tuBai, denBai, tongSoCau, slCauDe, slCauTB, slCauKho, false, tieuDeBaiThi, nguoiTao, nguoiKyDuyet, gV1, gV2, ghiChu,ngay, thang, nam);
        }
        public void CreateAutoTest(string idLoaiBaiThi, string idMonHoc, string idAcc, string maDe, int tuBai, int denBai,int ngay,int thang,int nam)
        {
            dA.CreateAutoTest(idLoaiBaiThi, idMonHoc, idAcc, maDe, tuBai, denBai, 0, 0, 0, 0, true, "", "", "", "", "", "",ngay, thang, nam);
        }

    }
}
