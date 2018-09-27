using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
   public class ChuongBaiBLL
    {
        ChuongBaiDAL cb = new ChuongBaiDAL();
        public List<ChuongBai> GetAllListChuongBai()
        {
            List<ChuongBai> lstChuongbai = cb.getListAllChuongBai();
            return lstChuongbai;
        }
        public List<ChuongBai> GetAllListChuongBaiByIDMonHoc(string idMonHoc)
        {
            List<ChuongBai> lstChuongbai = cb.getListAllChuongBaiByIDMonHoc(idMonHoc);
            return lstChuongbai;
        }
        public void CreateChuongBai(string idMonHoc, int soChuong, string tenChuong, string maChuong, int soBai)
        {
            cb.CreateChuongBai(idMonHoc, soChuong, tenChuong, maChuong, soBai);
        }
        public string getTenChuongBaiByID(string idChuongbai)
        {
            string tenchuong = cb.getChuongBaiByID(idChuongbai).TenChuong;
            return tenchuong;
        }
        public string getMaChuongBaiByID(string idChuongbai)
        {
            string maChuong = cb.getChuongBaiByID(idChuongbai).MaChuong;
            return maChuong;
        }
    }
}
