using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    class BaiHocBLL
    {
        BaiHocDAL bh = new BaiHocDAL();
        public List<BaiHoc> getListAllBaiHoc()
        {
            List<BaiHoc> lstBaiHoc = bh.GetListAllBaiHoc();
            return lstBaiHoc;
        }
        public int createAutoSubjectCode(string idChuong, string idMonHoc)
        {
            int maBaiHoc = bh.CreateAutoSubjectCode(idChuong, idMonHoc);
            return maBaiHoc;
        }
    }
}
