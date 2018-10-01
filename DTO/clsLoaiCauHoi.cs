using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsLoaiCauHoi
    {
        public string ID { get; set; }

        public string MaLoaiCauHoi { get; set; }

        public string LoaiCH { get; set; }

        public int SoLuong { get; set; }

        public DateTime NgayTao { get; set; }

        public string TrangThai { get; set; }
    }
}
