using QuanLyThuQuan.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
{
    public class DatChoDAO
    {
        // Lấy tất cả các bản ghi đặt chỗ
        public List<DatChoDTO> GetAll()
        {
            var list = new List<DatChoDTO>();
            string query = "SELECT * FROM DatCho";

            using (var cmd = new MySqlCommand(query, Database.Connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new DatChoDTO
                    {
                        MaThanhVien = reader.GetInt32("MaThanhVien"),
                        MaThietBi = reader.GetInt32("MaThietBi"),
                        NgayDat = reader.GetDateTime("NgayDat"),
                        NgayMuonDuKien = reader.GetDateTime("NgayMuonDuKien"),
                        ThoiGianMuon = reader.GetInt32("ThoiGianMuon"),
                        TinhTrang = reader.GetString("TinhTrang")
                    });
                }
            }
            return list;
        }

        // Thêm một bản ghi đặt chỗ mới
        public bool Insert(DatChoDTO dc)
        {
            string query = @"INSERT INTO DatCho (MaThanhVien, MaThietBi, NgayDat, NgayMuonDuKien, ThoiGianMuon, TinhTrang)
                             VALUES (@MaThanhVien, @MaThietBi, @NgayDat, @NgayMuonDuKien, @ThoiGianMuon, @TinhTrang)";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaThanhVien", dc.MaThanhVien);
                cmd.Parameters.AddWithValue("@MaThietBi", dc.MaThietBi);
                cmd.Parameters.AddWithValue("@NgayDat", dc.NgayDat);
                cmd.Parameters.AddWithValue("@NgayMuonDuKien", dc.NgayMuonDuKien);
                cmd.Parameters.AddWithValue("@ThoiGianMuon", dc.ThoiGianMuon);
                cmd.Parameters.AddWithValue("@TinhTrang", dc.TinhTrang);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Cập nhật thông tin đặt chỗ
        public bool Update(DatChoDTO dc)
        {
            string query = @"UPDATE DatCho
                             SET MaThanhVien = @MaThanhVien,
                                 MaThietBi = @MaThietBi,
                                 NgayDat = @NgayDat,
                                 NgayMuonDuKien = @NgayMuonDuKien,
                                 ThoiGianMuon = @ThoiGianMuon,
                                 TinhTrang = @TinhTrang
                             WHERE MaThanhVien = @MaThanhVien AND MaThietBi = @MaThietBi";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaThanhVien", dc.MaThanhVien);
                cmd.Parameters.AddWithValue("@MaThietBi", dc.MaThietBi);
                cmd.Parameters.AddWithValue("@NgayDat", dc.NgayDat);
                cmd.Parameters.AddWithValue("@NgayMuonDuKien", dc.NgayMuonDuKien);
                cmd.Parameters.AddWithValue("@ThoiGianMuon", dc.ThoiGianMuon);
                cmd.Parameters.AddWithValue("@TinhTrang", dc.TinhTrang);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa một bản ghi đặt chỗ
        public bool Delete(int maThanhVien, int maThietBi)
        {
            string query = "DELETE FROM DatCho WHERE MaThanhVien = @MaThanhVien AND MaThietBi = @MaThietBi";

            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaThanhVien", maThanhVien);
                cmd.Parameters.AddWithValue("@MaThietBi", maThietBi);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
