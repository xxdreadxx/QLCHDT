using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoaiCauHoiDAL
    {
        dbQLCHDataContext db = new dbQLCHDataContext();

        public List<LoaiCauHoi> GetAll()
        {
            return db.LoaiCauHois.Where(x => x.IsDeleted == false).ToList();
        }

        public LoaiCauHoi GetByID(string ID)
        {
            return db.LoaiCauHois.SingleOrDefault(x => x.ID == ID);
        }

        public void LoaiCH_Add(string maLoai, string loaiCH)
        {
            LoaiCauHoi l = new LoaiCauHoi();
            l.ID = System.Guid.NewGuid().ToString();
            l.MaLoai = maLoai;
            l.LoaiCauHoi1 = loaiCH;
            l.SoLuong = 0;
            l.CreatedDate = DateTime.Now.Date;
            l.IsDeleted = false;
            l.InUsed = false;
            db.LoaiCauHois.InsertOnSubmit(l);
            db.SubmitChanges();
        }

        public void LoaiCH_Del(string ID)
        {
            LoaiCauHoi l = db.LoaiCauHois.SingleOrDefault(x => x.ID == ID);
            if (l != null)
            {
                db.LoaiCauHois.DeleteOnSubmit(l);
                db.SubmitChanges();
            }
        }

        public void LoaiCH_Change(string ID)
        {
            LoaiCauHoi l = db.LoaiCauHois.SingleOrDefault(x => x.ID == ID);
            if (l != null)
            {
                if (l.InUsed==true)
                {
                    l.InUsed = false;
                    db.SubmitChanges();
                }
                else
                {
                    l.InUsed = true;
                    db.SubmitChanges();
                }
            }
        }
    }
}
