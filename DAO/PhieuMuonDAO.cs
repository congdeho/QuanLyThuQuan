using QuanLyThuQuan.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
{
    public class PhieuMuonDAO
    {
        // Lấy toàn bộ phiếu mượn
        public List<PhieuMuonDTO> GetAll()
        {
            var list = new List<PhieuMuonDTO>();
            string query = "SELECT * FROM PhieuMuon";

            using (var cmd = new MySqlCommand(query, Database.Connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new PhieuMuonDTO
                    {
                        MaPhieuMuon = reader.GetInt32("MaPhieuMuon"),
                        MaThanhVienMuon = reader.GetInt32("MaThanhVienMuon"),
                        NgayMuon = reader.GetDateTime("NgayMuon"),
                        NgayTra = reader.GetDateTime("NgayTra"),
                        TinhTrang = reader.GetString("TinhTrang")
                    });
                }
            }
            return list;
        }

        // Thêm phiếu mượn mới
        public bool Insert(PhieuMuonDTO pm)
        {
            string query = @"INSERT INTO PhieuMuon (MaThanhVienMuon, NgayMuon, NgayTra, TinhTrang)
                             VALUES (@MaThanhVienMuon, @NgayMuon, @NgayTra, @TinhTrang)";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaThanhVienMuon", pm.MaThanhVienMuon);
                cmd.Parameters.AddWithValue("@NgayMuon", pm.NgayMuon);
                cmd.Parameters.AddWithValue("@NgayTra", pm.NgayTra);
                cmd.Parameters.AddWithValue("@TinhTrang", pm.TinhTrang);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Cập nhật phiếu mượn
        public bool Update(PhieuMuonDTO pm)
        {
            string query = @"UPDATE PhieuMuon
                             SET MaThanhVienMuon = @MaThanhVienMuon,
                                 NgayMuon = @NgayMuon,
                                 NgayTra = @NgayTra,
                                 TinhTrang = @TinhTrang
                             WHERE MaPhieuMuon = @MaPhieuMuon";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaThanhVienMuon", pm.MaThanhVienMuon);
                cmd.Parameters.AddWithValue("@NgayMuon", pm.NgayMuon);
                cmd.Parameters.AddWithValue("@NgayTra", pm.NgayTra);
                cmd.Parameters.AddWithValue("@TinhTrang", pm.TinhTrang);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", pm.MaPhieuMuon);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa phiếu mượn
        public bool Delete(int maPhieuMuon)
        {
            string query = "DELETE FROM PhieuMuon WHERE MaPhieuMuon = @MaPhieuMuon";

            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
