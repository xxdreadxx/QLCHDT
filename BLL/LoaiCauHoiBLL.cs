using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class LoaiCauHoiBLL
    {
        LoaiCauHoiDAL dal = new LoaiCauHoiDAL();

        public List<LoaiCauHoi> getAll()
        {
            return dal.GetAll();
        }

        public LoaiCauHoi getByID(string ID)
        {
            return dal.GetByID(ID);
        }

        public void Add(string maLoai, string loaiCH)
        {
            dal.LoaiCH_Add(maLoai, loaiCH);
        }

        public void Del(string ID)
        {
            dal.LoaiCH_Del(ID);
        }

        public void Change(string ID)
        {
            dal.LoaiCH_Change(ID);
        }
    }
}
