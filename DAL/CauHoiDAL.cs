using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CauHoiDAL
    {
        dbQLCHDataContext db = new dbQLCHDataContext();
        public List<CauHoi> GetAllList()
        {
            List<CauHoi> lst = db.CauHois.Where(p => p.InUsed == true).ToList();
            return lst;
        }

        public CauHoi GetByID(string ID)
        {
            CauHoi lst = db.CauHois.SingleOrDefault(p => p.ID == ID);
            return lst;
        }
        public void CreateCauHoi(string idMon, string idLoaiCauHoi,string tieuDe, string NoiDung, int mucDo, string idChuong,string idBai, string maCauHoi,string idacc)
        {
            CauHoi ch = new CauHoi();
            ch.ID = Guid.NewGuid().ToString();
            ch.ID_Mon = idMon;
            ch.ID_LoaiCauHoi = idLoaiCauHoi;
            ch.TieuDe = tieuDe;
            ch.NoiDung = NoiDung;
            ch.MucDo = mucDo;
            ch.ID_Chuong = idChuong;
            ch.ID_Bai = idBai;
            ch.MaCauHoi = maCauHoi;
            ch.ID_Account = idacc;
            ch.InUsed = true;
            ch.IsDeleted = false;
            db.CauHois.InsertOnSubmit(ch);
            db.SubmitChanges();
        }

        public void CreateCauHoi1(string NoiDung, int mucDo, string maCauHoi)
        {
            CauHoi ch = new CauHoi();
            ch.ID = Guid.NewGuid().ToString();
            ch.NoiDung = NoiDung;
            ch.MucDo = mucDo;
            ch.MaCauHoi = maCauHoi;
            ch.InUsed = true;
            ch.IsDeleted = false;
            db.CauHois.InsertOnSubmit(ch);
            db.SubmitChanges();
        }
    }
}
