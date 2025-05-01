using QuanLyThuQuan.DTO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
{
    public class ChiTietMuonDAO
    {
        // Lấy tất cả các bản ghi chi tiết mượn
        public List<ChiTietMuonDTO> GetAll()
        {
            var list = new List<ChiTietMuonDTO>();
            string query = "SELECT * FROM ChiTietMuon";

            using (var cmd = new MySqlCommand(query, Database.Connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new ChiTietMuonDTO
                    {
                        MaPhieuMuon = reader.GetInt32("MaPhieuMuon"),
                        MaThietBi = reader.GetInt32("MaThietBi"),
                        SoLuong = reader.GetInt32("SoLuong")
                    });
                }
            }
            return list;
        }

        // Thêm một bản ghi chi tiết mượn mới
        public bool Insert(ChiTietMuonDTO ctMuon)
        {
            string query = @"INSERT INTO ChiTietMuon (MaPhieuMuon, MaThietBi, SoLuong)
                             VALUES (@MaPhieuMuon, @MaThietBi, @SoLuong)";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaPhieuMuon", ctMuon.MaPhieuMuon);
                cmd.Parameters.AddWithValue("@MaThietBi", ctMuon.MaThietBi);
                cmd.Parameters.AddWithValue("@SoLuong", ctMuon.SoLuong);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Cập nhật thông tin chi tiết mượn
        public bool Update(ChiTietMuonDTO ctMuon)
        {
            string query = @"UPDATE ChiTietMuon
                             SET MaThietBi = @MaThietBi,
                                 SoLuong = @SoLuong
                             WHERE MaPhieuMuon = @MaPhieuMuon";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaPhieuMuon", ctMuon.MaPhieuMuon);
                cmd.Parameters.AddWithValue("@MaThietBi", ctMuon.MaThietBi);
                cmd.Parameters.AddWithValue("@SoLuong", ctMuon.SoLuong);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa một bản ghi chi tiết mượn
        public bool Delete(int maPhieuMuon, int maThietBi)
        {
            string query = "DELETE FROM ChiTietMuon WHERE MaPhieuMuon = @MaPhieuMuon AND MaThietBi = @MaThietBi";

            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
                cmd.Parameters.AddWithValue("@MaThietBi", maThietBi);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
