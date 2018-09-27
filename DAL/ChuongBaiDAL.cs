using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChuongBaiDAL
    {
        dbQLCHDataContext db = new dbQLCHDataContext();
        public List<ChuongBai> getListAllChuongBai()
        {
            List<ChuongBai> lstChuongBai = db.ChuongBais.Where(p => p.InUsed == true).ToList();
            return lstChuongBai;
        }
        public List<ChuongBai> getListAllChuongBaiByIDMonHoc(string idMonHoc)
        {
            List<ChuongBai> lstChuongBai = db.ChuongBais.Where(p => p.InUsed == true && p.ID_MonHoc == idMonHoc).ToList();
            return lstChuongBai;
        }
        public ChuongBai getChuongBaiByID(string idChuongBai)
        {
            ChuongBai cb = db.ChuongBais.SingleOrDefault(p => p.ID == idChuongBai);
            return cb;
        }
        public void CreateChuongBai(string idMonHoc, int soChuong,string tenChuong, string maChuong, int soBai)
        {
            ChuongBai cb = new ChuongBai();
            cb.ID = Guid.NewGuid().ToString();
            cb.ID_MonHoc = idMonHoc;
            cb.SoChuong = soChuong;
            cb.TenChuong = tenChuong;
            cb.MaChuong = maChuong;
            cb.SoBai = soBai;
            cb.InUsed = true;
            cb.IsDeleted = false;
            db.ChuongBais.InsertOnSubmit(cb);
            db.SubmitChanges();
        }
    }
}
