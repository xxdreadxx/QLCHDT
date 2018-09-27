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

        public void LoaiCH_Add(string loaiCH, string maLoai, int soLuong)
        {
            LoaiCauHoi l = new LoaiCauHoi();
            l.ID = System.Guid.NewGuid().ToString();
            l.MaLoai = maLoai;
            l.LoaiCauHoi1 = loaiCH;
            l.SoLuong = soLuong;
            l.CreatedDate = DateTime.Now.Date;
            l.IsDeleted = false;
            l.InUsed = false;
            db.LoaiCauHois.InsertOnSubmit(l);
            db.SubmitChanges();
        }
    }
}
