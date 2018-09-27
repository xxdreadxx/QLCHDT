using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class MonHocBLL
    {
        MonHocDAL monHoc = new MonHocDAL();
        public List<MonHoc> GetAllMonHoc()
        {
            return monHoc.GetAllMonHoc();
        }

        public List<MonHoc> GetMonHocByID_Khoi(int Khoi)
        {
            return monHoc.GetMonHocByID_Khoi(Khoi);
        }

        public MonHoc GetMonHocByMaMon(string maMon)
        {
            return monHoc.GetMonHocByMaMon(maMon);
        }

        public List<MonHoc> GetMonHoc(int Khoi, string maMon)
        {
            return monHoc.GetMonHoc(maMon, Khoi);
        }

        public MonHoc GetMonHocByID(string ID)
        {
            return monHoc.GetMonHocByID(ID);
        }

        public void MonHoc_Add(string maMon, int khoi, string tenMon)
        {
            monHoc.MonHoc_Add(khoi, maMon, tenMon);
        }

        public void MonHoc_Del(string ID)
        {
            monHoc.MonHoc_Del(ID);
        }

        public void MonHoc_Change(string ID)
        {
            monHoc.MonHoc_Change(ID);
        }
        public string getTenMonHocByID(string idMonHoc)
        {
            string tenMon = monHoc.GetMonHocByID(idMonHoc).TenMonHoc;
            return tenMon;
        }
        public string getMaMonHocByID(string idMonHoc)
        {
            string maMon = monHoc.GetMonHocByID(idMonHoc).MaMonHoc;
            return maMon;
        }
    }
}
