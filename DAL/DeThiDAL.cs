using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
  public class DeThiDAL
    {
        static dbQLCHDataContext db = new dbQLCHDataContext();
        //Lấy tất cả đề thi theo ngày tháng
       public  List<DeThi> getAllListTestByCreateDate(int tuNgay,int Tuthang, int tuNam,int denNgay, int denThang,int denNam)
        {
            List<DeThi> lstDeThi = new List<DeThi>();
            lstDeThi = db.DeThis.Where(p => p.InUsed == true 
            && p.CreatedDate.Value.Day >= tuNgay
            && p.CreatedDate.Value.Day <= denNgay
            && p.CreatedDate.Value.Month >= Tuthang 
            && p.CreatedDate.Value.Month <= denThang
            && p.CreatedDate.Value.Year >= tuNam
            && p.CreatedDate.Value.Year <= denNam).ToList();
            return lstDeThi;
        }
        //Lấy tất cả đề thi theo ngày tháng và mã môn học
        public List<DeThi> getAllListTestByIDSubject(int Thang, int Nam, string idMonHoc)
        {
            List<DeThi> lstDeThi = new List<DeThi>();
            lstDeThi = db.DeThis.Where(p => p.InUsed == true && p.CreatedDate.Value.Month  == Thang && p.CreatedDate.Value.Year == Nam && p.ID_Mon == idMonHoc).ToList(); 
            return lstDeThi;
        }
        //Lấy tất cả đề thi theo ngày tháng và loại đề thi
        public List<DeThi> getAllListTestByTypeTest(int Thang, int Nam, string idLoaiDeThi)
        {
            List<DeThi> lstDeThi = new List<DeThi>();
            lstDeThi = db.DeThis.Where(p => p.InUsed == true && p.CreatedDate.Value.Month == Thang && p.CreatedDate.Value.Year == Nam && p.ID_LoaiDeThi == idLoaiDeThi).ToList();
            return lstDeThi;
        }
        public DeThi getATest(int Thang, int Nam, string idHoaDon)
        {
            DeThi objDeThi = new DeThi();
            objDeThi = db.DeThis.Where(p => p.InUsed == true && p.CreatedDate.Value.Month == Thang && p.CreatedDate.Value.Year == Nam && p.ID == idHoaDon).FirstOrDefault();
            return objDeThi;
        }
        public List<DeThi_ChiTiet> getAllTestDetail(string idDeThi)
        {
            List<DeThi_ChiTiet> lstDeThi = new List<DeThi_ChiTiet>();
            lstDeThi = db.DeThi_ChiTiets.Where(p => p.ID_DeThi == idDeThi && p.InUsed==true).ToList();
            return lstDeThi;
        }
        public void CreateAutoTest(string idLoaiBaiThi, string idMonHoc, string idAccount, string maDe, int tuBai, int denBai, int tongSoCau, int slCauDe, int slCauTB, int slCauKho, bool isCreateAuto, string tieuDeBaiThi, string nguoiTao, string nguoiKyDuyet, string gV1, string gV2, string ghiChu,int tuNgay, int tuThang, int tuNam)
        {
            db.TaoBaiThiNgauNhien(idLoaiBaiThi, idMonHoc, idAccount, maDe, tuBai, denBai, tongSoCau, slCauDe, slCauTB, slCauKho, isCreateAuto, tieuDeBaiThi, nguoiTao, nguoiKyDuyet, gV1, gV2, ghiChu,tuNgay,tuThang,tuNam);
        }


    }
}
