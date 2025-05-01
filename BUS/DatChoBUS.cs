using QuanLyThuQuan.DTO;
using QuanLyThuQuan.DAO;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    public class DatChoBUS
    {
        private DatChoDAO _datChoDAO;

        public DatChoBUS()
        {
            _datChoDAO = new DatChoDAO();
        }

        // Lấy tất cả các đặt chỗ
        public List<DatChoDTO> GetAll()
        {
            return _datChoDAO.GetAll();
        }

        // Thêm đặt chỗ
        public bool AddDatCho(DatChoDTO datCho)
        {
            return _datChoDAO.Insert(datCho);
        }

        // Cập nhật đặt chỗ
        public bool UpdateDatCho(DatChoDTO datCho)
        {
            return _datChoDAO.Update(datCho);
        }

        // Xóa đặt chỗ
        public bool DeleteDatCho(int maThanhVien, int maThietBi)
        {
            return _datChoDAO.Delete(maThanhVien, maThietBi);
        }
    }
}
