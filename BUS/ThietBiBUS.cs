using QuanLyThuQuan.DTO;
using QuanLyThuQuan.DAO;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS

{
    public class ThietBiBUS
    {
        private ThietBiDAO _thietBiDAO;

        public ThietBiBUS()
        {
            _thietBiDAO = new ThietBiDAO();
        }

        // Lấy tất cả các thiết bị
        public List<ThietBiDTO> GetAll()
        {
            return _thietBiDAO.GetAll();
        }

        // Thêm thiết bị mới
        public bool AddThietBi(ThietBiDTO thietBi)
        {
            return _thietBiDAO.Add(thietBi);
        }

        // Cập nhật thông tin thiết bị
        public bool UpdateThietBi(ThietBiDTO thietBi)
        {
            return _thietBiDAO.Update(thietBi);
        }

        // Xóa thiết bị
        public bool DeleteThietBi(int maThietBi)
        {
            return _thietBiDAO.Delete(maThietBi);
        }
    }
}
