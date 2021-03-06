﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   public class CauHoiBLL
    {
        CauHoiDAL ch = new CauHoiDAL();
        public List<CauHoi> GetAllListCauHoi()
        {
            List<CauHoi> lst = ch.GetAllList();
            return lst;
        }

        public CauHoi GetByID(string ID)
        {
            return ch.GetByID(ID);
        }

        public void CreateCauHoi(string idMon, string idLoaiCauHoi, string tieuDe, string NoiDung, int mucDo, string idChuong, string idBai, string maCauHoi, string idacc)
        {
            ch.CreateCauHoi(idMon, idLoaiCauHoi, tieuDe, NoiDung, mucDo, idChuong, idBai, maCauHoi, idacc);
        }
        public void CreateCauHoi1(string NoiDung, int mucDo, string maCauHoi)
        {
            ch.CreateCauHoi1(NoiDung, mucDo, maCauHoi);
        }
    }
}
