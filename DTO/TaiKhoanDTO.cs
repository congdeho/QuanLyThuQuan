using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.DTO

{
    public class TaiKhoanDTO
    {
        public int MaThanhVien { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public DateTime NgayThamGia { get; set; }
        public bool TrangThai { get; set; }
    }
}
