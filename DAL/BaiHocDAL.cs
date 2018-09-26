using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
   public class BaiHocDAL
    {
        dbQLCHDataContext db = new dbQLCHDataContext();
        public List<BaiHoc> GetListAllBaiHoc()
        {
            List<BaiHoc> lstBaiHoc = new List<BaiHoc>();
            lstBaiHoc = db.BaiHocs.Where(p => p.InUsed == true).ToList();
            return lstBaiHoc;
        }
        public BaiHoc getbaiHocByID(string idBaiHoc)
        {
            BaiHoc bh = new BaiHoc();
            bh = db.BaiHocs.SingleOrDefault(p => p.ID == idBaiHoc && p.InUsed == true);
            return bh;
        }
        public int CreateAutoSubjectCode(string idChuongBai,string idMonHoc)
        {
            int BaiSo;
            List<string> lstChuongBai = db.ChuongBais.Where(k=>k.ID_MonHoc==idMonHoc).Select(p => p.ID).ToList();
            BaiHoc objBaiHoc = db.BaiHocs.OrderByDescending(k => k.BaiSo).FirstOrDefault(p => p.InUsed == true && lstChuongBai.Contains(p.ID_Chuong) == true);
            if (objBaiHoc != null)
            {
                int noMax = (int)objBaiHoc.BaiSo;
                BaiSo = noMax + 1;
            }
            else
            {
                BaiSo = 1;
            }
            return BaiSo;
        }
        public void CreateBaiHoc(string maBaiHoc, string tenBaiHoc, string idChuong, string noiDung, int khoi, string idMonHoc)
        {
            BaiHoc ch = new BaiHoc();
            ch.ID = Guid.NewGuid().ToString();
            ch.BaiSo = CreateAutoSubjectCode(idChuong, idMonHoc);
            ch.MaBaiHoc = maBaiHoc;
            ch.TenBaiHoc = tenBaiHoc;
            ch.ID_Chuong = idChuong;
            ch.NoiDung = noiDung;
            ch.InUsed = true;
            ch.IsDeleted = false;
            db.BaiHocs.InsertOnSubmit(ch);
            db.SubmitChanges();
        }
    }
}
