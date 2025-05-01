using QuanLyThuQuan.DTO;
using QuanLyThuQuan.DAO;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    public class PhieuMuonBUS
    {
        private PhieuMuonDAO _phieuMuonDAO;

        public PhieuMuonBUS()
        {
            _phieuMuonDAO = new PhieuMuonDAO();
        }

        // Lấy tất cả các phiếu mượn
        public List<PhieuMuonDTO> GetAll()
        {
            return _phieuMuonDAO.GetAll();
        }

        // Thêm phiếu mượn
        public bool AddPhieuMuon(PhieuMuonDTO phieuMuon)
        {
            return _phieuMuonDAO.Insert(phieuMuon);
        }

        // Cập nhật phiếu mượn
        public bool UpdatePhieuMuon(PhieuMuonDTO phieuMuon)
        {
            return _phieuMuonDAO.Update(phieuMuon);
        }

        // Xóa phiếu mượn
        public bool DeletePhieuMuon(int maPhieuMuon)
        {
            return _phieuMuonDAO.Delete(maPhieuMuon);
        }
    }
}
