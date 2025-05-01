using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.DTO
{
    public class DatChoDTO
    {
        public int MaThanhVien { get; set; }
        public int MaThietBi { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime NgayMuonDuKien { get; set; }
        public int ThoiGianMuon { get; set; } // Số giờ mượn
        public string TinhTrang { get; set; }
    }
}
