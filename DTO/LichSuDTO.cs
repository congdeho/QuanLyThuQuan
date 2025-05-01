using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.DTO

{
    public class LichSuDTO
    {
        public int MaLichSu { get; set; }
        public int MaThanhVien { get; set; }
        public string LoaiHoatDong { get; set; } // Có thể dùng enum nếu muốn
        public DateTime ThoiGian { get; set; }
    }
}
