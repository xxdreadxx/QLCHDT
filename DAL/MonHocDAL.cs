using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class MonHocDAL
    {
        static dbQLCHDataContext db = new dbQLCHDataContext();

        //Lấy tất cả môn học
        public List<MonHoc> GetAllMonHoc()
        {
            return db.MonHocs.Where(x => x.IsDeleted == false).ToList();
        }

        //Lấy list môn học theo khối
        public List<MonHoc> GetMonHocByID_Khoi(int ID_Khoi)
        {
            return db.MonHocs.Where(x => x.IsDeleted == false && x.Khoi == ID_Khoi).ToList();
        }

        //Lấy môn học theo mã môn
        public MonHoc GetMonHocByMaMon(string MaMon)
        {
            return db.MonHocs.SingleOrDefault(x => x.IsDeleted == false && x.MaMonHoc == MaMon);
        }

        //Lấy list môn học theo khối, mã môn, inUsed=true
        public List<MonHoc> GetMonHoc(string MaMon, int ID_Khoi)
        {
            return db.MonHocs.Where(x => x.IsDeleted == false && x.MaMonHoc == MaMon && x.Khoi == ID_Khoi && x.InUsed == true).ToList();
        }

        //Lấy list môn học theo ID
        public MonHoc GetMonHocByID(string ID)
        {
            return db.MonHocs.SingleOrDefault(x => x.IsDeleted == false && x.ID == ID);
        }

        //Thêm môn học
        public void MonHoc_Add(int Khoi, string maMon, string tenMon)
        {
            string ID = System.Guid.NewGuid().ToString();
            MonHoc monHoc = new MonHoc();
            monHoc.ID = ID;
            monHoc.Khoi = Khoi;
            monHoc.MaMonHoc = maMon;
            monHoc.TenMonHoc = tenMon;
            monHoc.SoCauHoi = 0;
            monHoc.CreateDate = DateTime.Now.Date;
            monHoc.InUsed = false;
            monHoc.IsDeleted = false;
            db.MonHocs.InsertOnSubmit(monHoc);
            db.SubmitChanges();
        }

        //Xóa môn học
        public void MonHoc_Del(string ID)
        {
            MonHoc monHoc = db.MonHocs.FirstOrDefault(x => x.ID == ID);
            if (monHoc != null)
            {
                monHoc.IsDeleted = true;
                //db.MonHocs.DeleteOnSubmit(monHoc);
                db.SubmitChanges();
            }
        }

        //Duyệt môn học
        public void MonHoc_Change(string ID)
        {
            MonHoc monHoc = db.MonHocs.FirstOrDefault(x => x.ID == ID);
            if (monHoc != null)
            {
                if (monHoc.InUsed == false)
                {
                    monHoc.InUsed = true;
                }
                else
                {
                    monHoc.InUsed = false;
                }
                db.SubmitChanges();
            }
        }
      
    }
}
