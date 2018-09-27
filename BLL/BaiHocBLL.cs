using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   public class BaiHocBLL
    {
        BaiHocDAL bh = new BaiHocDAL();
        public List<BaiHoc> getListAllBaiHoc()
        {
            List<BaiHoc> lstBaiHoc = bh.GetListAllBaiHoc();
            return lstBaiHoc;
        }
        public List<BaiHoc> getListAllBaiHocByidChuong(string idChuong)
        {
            List<BaiHoc> lstBaiHoc = bh.GetListAllBaiHocByIDChuong(idChuong);
            return lstBaiHoc;
        }
        public int createAutoSubjectCode(string idChuong, string idMonHoc)
        {
            int maBaiHoc = bh.CreateAutoSubjectCode(idChuong, idMonHoc);
            return maBaiHoc;
        }
        public void CreateBaiHoc(string maBaiHoc, string tenBaiHoc, string idChuong, string noiDung, int khoi, string idMonHoc)
        {
            bh.CreateBaiHoc(maBaiHoc, tenBaiHoc, idChuong, noiDung, khoi, idMonHoc);
        }
        public string getTenBaiHocByID(string idBaiHoc)
        {
            string tenBai = bh.getbaiHocByID(idBaiHoc).TenBaiHoc;
            return tenBai;
        }
        public string getMaBaiHocByID(string idBaiHoc)
        {
            string maBai = bh.getbaiHocByID(idBaiHoc).MaBaiHoc;
            return maBai;
        }
    }
}
