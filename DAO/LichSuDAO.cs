using QuanLyThuQuan.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
{
    public class LichSuDAO
    {
        // Lấy toàn bộ lịch sử
        public List<LichSuDTO> GetAll()
        {
            var list = new List<LichSuDTO>();
            string query = "SELECT * FROM LichSu";

            using (var cmd = new MySqlCommand(query, Database.Connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new LichSuDTO
                    {
                        MaLichSu = reader.GetInt32("MaLichSu"),
                        MaThanhVien = reader.GetInt32("MaThanhVien"),
                        LoaiHoatDong = reader.GetString("LoaiHoatDong"),
                        ThoiGian = reader.GetDateTime("ThoiGian")
                    });
                }
            }
            return list;
        }

        // Thêm một bản ghi lịch sử mới
        public bool Insert(LichSuDTO ls)
        {
            string query = @"INSERT INTO LichSu (MaThanhVien, LoaiHoatDong, ThoiGian)
                             VALUES (@MaThanhVien, @LoaiHoatDong, @ThoiGian)";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaThanhVien", ls.MaThanhVien);
                cmd.Parameters.AddWithValue("@LoaiHoatDong", ls.LoaiHoatDong);
                cmd.Parameters.AddWithValue("@ThoiGian", ls.ThoiGian);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Cập nhật bản ghi lịch sử
        public bool Update(LichSuDTO ls)
        {
            string query = @"UPDATE LichSu
                             SET MaThanhVien = @MaThanhVien,
                                 LoaiHoatDong = @LoaiHoatDong,
                                 ThoiGian = @ThoiGian
                             WHERE MaLichSu = @MaLichSu";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaThanhVien", ls.MaThanhVien);
                cmd.Parameters.AddWithValue("@LoaiHoatDong", ls.LoaiHoatDong);
                cmd.Parameters.AddWithValue("@ThoiGian", ls.ThoiGian);
                cmd.Parameters.AddWithValue("@MaLichSu", ls.MaLichSu);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa bản ghi lịch sử
        public bool Delete(int maLichSu)
        {
            string query = "DELETE FROM LichSu WHERE MaLichSu = @MaLichSu";

            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaLichSu", maLichSu);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}

