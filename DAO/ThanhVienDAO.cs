using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using QuanLyThuQuan.DTO;

namespace QuanLyThuQuan.DAO
{
    public class ThanhVienDAO
    {

        public ThanhVienDTO Get(int id)
        {
            string query = "SELECT * FROM ThanhVien WHERE MaThanhVien = @Id";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ThanhVienDTO
                        {
                            MaThanhVien = reader.GetInt32("MaThanhVien"),
                            Ten = reader.GetString("Ten"),
                            DiaChi = reader.GetString("DiaChi"),
                            NgaySinh = reader.GetDateTime("NgaySinh")
                        };
                    }
                }
            }
            return null;
        }

        public List<ThanhVienDTO> GetAll()
        {
            var list = new List<ThanhVienDTO>();
            string query = "SELECT * FROM ThanhVien";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new ThanhVienDTO
                    {
                        MaThanhVien = reader.GetInt32("MaThanhVien"),
                        Ten = reader.GetString("Ten"),
                        DiaChi = reader.GetString("DiaChi"),
                        NgaySinh = reader.GetDateTime("NgaySinh")
                    });
                }
            }
            return list;
        }

        public int Add(ThanhVienDTO tv)
        {
            string query = "INSERT INTO ThanhVien (Ten, DiaChi, NgaySinh) VALUES (@Ten, @DiaChi, @NgaySinh)";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@Ten", tv.Ten);
                cmd.Parameters.AddWithValue("@DiaChi", tv.DiaChi);
                cmd.Parameters.AddWithValue("@NgaySinh", tv.NgaySinh);
                return cmd.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
            }
        }

        public int Update(ThanhVienDTO tv)
        {
            string query = "UPDATE ThanhVien SET Ten = @Ten, DiaChi = @DiaChi, NgaySinh = @NgaySinh WHERE MaThanhVien = @Id";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@Ten", tv.Ten);
                cmd.Parameters.AddWithValue("@DiaChi", tv.DiaChi);
                cmd.Parameters.AddWithValue("@NgaySinh", tv.NgaySinh);
                cmd.Parameters.AddWithValue("@Id", tv.MaThanhVien);
                return cmd.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
            }
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM ThanhVien WHERE MaThanhVien = @Id";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                return cmd.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
            }
        }
    }
}
