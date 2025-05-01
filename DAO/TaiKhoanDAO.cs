using QuanLyThuQuan.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
{
    public class TaiKhoanDAO
    {
        // Lấy toàn bộ tài khoản
        public List<TaiKhoanDTO> GetAll()
        {
            var list = new List<TaiKhoanDTO>();
            string query = "SELECT * FROM TaiKhoan";

            using (var cmd = new MySqlCommand(query, Database.Connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new TaiKhoanDTO
                    {
                        MaThanhVien = reader.GetInt32("MaThanhVien"),
                        TenDangNhap = reader.GetString("TenDangNhap"),
                        MatKhau = reader.GetString("MatKhau"),
                        Email = reader.GetString("Email"),
                        NgayThamGia = reader.GetDateTime("NgayThamGia"),
                        TrangThai = reader.GetBoolean("TrangThai")
                    });
                }
            }
            return list;
        }

        // Thêm tài khoản mới
        public bool Insert(TaiKhoanDTO tk)
        {
            string query = @"INSERT INTO TaiKhoan (MaThanhVien, TenDangNhap, MatKhau, Email, NgayThamGia, TrangThai) 
                             VALUES (@MaThanhVien, @TenDangNhap, @MatKhau, @Email, @NgayThamGia, @TrangThai)";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaThanhVien", tk.MaThanhVien);
                cmd.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
                cmd.Parameters.AddWithValue("@Email", tk.Email);
                cmd.Parameters.AddWithValue("@NgayThamGia", tk.NgayThamGia);
                cmd.Parameters.AddWithValue("@TrangThai", tk.TrangThai);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Cập nhật tài khoản
        public bool Update(TaiKhoanDTO tk)
        {
            string query = @"UPDATE TaiKhoan 
                             SET TenDangNhap = @TenDangNhap, 
                                 MatKhau = @MatKhau, 
                                 Email = @Email, 
                                 NgayThamGia = @NgayThamGia, 
                                 TrangThai = @TrangThai 
                             WHERE MaThanhVien = @MaThanhVien";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
                cmd.Parameters.AddWithValue("@Email", tk.Email);
                cmd.Parameters.AddWithValue("@NgayThamGia", tk.NgayThamGia);
                cmd.Parameters.AddWithValue("@TrangThai", tk.TrangThai);
                cmd.Parameters.AddWithValue("@MaThanhVien", tk.MaThanhVien);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa tài khoản
        public bool Delete(int maThanhVien)
        {
            string query = "DELETE FROM TaiKhoan WHERE MaThanhVien = @MaThanhVien";

            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@MaThanhVien", maThanhVien);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
