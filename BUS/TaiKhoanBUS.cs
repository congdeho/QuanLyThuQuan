using QuanLyThuQuan.DTO;
using QuanLyThuQuan.DAO;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAO _taiKhoanDAO;

        public TaiKhoanBUS()
        {
            _taiKhoanDAO = new TaiKhoanDAO();
        }

        // Lấy tất cả tài khoản
        public List<TaiKhoanDTO> GetAll()
        {
            return _taiKhoanDAO.GetAll();
        }

        // Thêm tài khoản
        public bool AddTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            return _taiKhoanDAO.Insert(taiKhoan);
        }

        // Cập nhật tài khoản
        public bool UpdateTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            return _taiKhoanDAO.Update(taiKhoan);
        }

        // Xóa tài khoản
        public bool DeleteTaiKhoan(int maThanhVien)
        {
            return _taiKhoanDAO.Delete(maThanhVien);
        }
    }
}
