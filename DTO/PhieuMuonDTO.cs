using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.DTO

{
    public class PhieuMuonDTO
    {
        public int MaPhieuMuon { get; set; }
        public int MaThanhVienMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public string TinhTrang { get; set; }
    }
}
