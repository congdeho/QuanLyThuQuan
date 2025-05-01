using QuanLyThuQuan.DTO;
using QuanLyThuQuan.DAO;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    public class ChiTietMuonBUS
    {
        private ChiTietMuonDAO _chiTietMuonDAO;

        public ChiTietMuonBUS()
        {
            _chiTietMuonDAO = new ChiTietMuonDAO();
        }

        // Lấy tất cả các chi tiết mượn
        public List<ChiTietMuonDTO> GetAll()
        {
            return _chiTietMuonDAO.GetAll();
        }

        // Thêm chi tiết mượn
        public bool AddChiTietMuon(ChiTietMuonDTO chiTietMuon)
        {
            return _chiTietMuonDAO.Insert(chiTietMuon);
        }

        // Cập nhật chi tiết mượn
        public bool UpdateChiTietMuon(ChiTietMuonDTO chiTietMuon)
        {
            return _chiTietMuonDAO.Update(chiTietMuon);
        }

        // Xóa chi tiết mượn
        public bool DeleteChiTietMuon(int maPhieuMuon, int maThietBi)
        {
            return _chiTietMuonDAO.Delete(maPhieuMuon, maThietBi);
        }
    }
}
