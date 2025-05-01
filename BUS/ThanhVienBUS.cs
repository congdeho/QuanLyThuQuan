using QuanLyThuQuan.DTO;
using QuanLyThuQuan.DAO;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    public class ThanhVienBUS
    {
        private ThanhVienDAO _thanhVienDAO;

        public ThanhVienBUS()
        {
            _thanhVienDAO = new ThanhVienDAO();
        }

        // Lấy tất cả thành viên
        public List<ThanhVienDTO> GetAll()
        {
            return _thanhVienDAO.GetAll();
        }

        // Thêm thành viên mới
        public int AddThanhVien(ThanhVienDTO thanhVien)
        {
            return _thanhVienDAO.Add(thanhVien);
        }

        // Cập nhật thông tin thành viên
        public int UpdateThanhVien(ThanhVienDTO thanhVien)
        {
            return _thanhVienDAO.Update(thanhVien);
        }

        // Xóa thành viên
        public int DeleteThanhVien(int maThanhVien)
        {
            return _thanhVienDAO.Delete(maThanhVien);
        }
    }
}
