using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   public class DeThiBLL
    {
      static  DeThiDAL dA = new DeThiDAL();
        public List<DeThi> GetAllTest(int Thang, int Nam)
        {
            List<DeThi> lstDeThi = new List<DeThi>();
            lstDeThi = dA.getAllListTestByCreateDate(Thang, Nam);
            return lstDeThi;
        }
    }
}
