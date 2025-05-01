using QuanLyThuQuan.DTO;
using QuanLyThuQuan.DAO;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    public class LichSuBUS
    {
        private LichSuDAO _lichSuDAO;

        public LichSuBUS()
        {
            _lichSuDAO = new LichSuDAO();
        }

        // Lấy tất cả lịch sử hoạt động
        public List<LichSuDTO> GetAll()
        {
            return _lichSuDAO.GetAll();
        }

        // Thêm lịch sử hoạt động
        public bool AddLichSu(LichSuDTO lichSu)
        {
            return _lichSuDAO.Insert(lichSu);
        }

        // Cập nhật lịch sử hoạt động
        public bool UpdateLichSu(LichSuDTO lichSu)
        {
            return _lichSuDAO.Update(lichSu);
        }

        // Xóa lịch sử hoạt động
        public bool DeleteLichSu(int maLichSu)
        {
            return _lichSuDAO.Delete(maLichSu);
        }
    }
}
