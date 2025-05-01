using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuQuan.DTO;
using MySql.Data.MySqlClient;

namespace QuanLyThuQuan.DAO
{
    public class ThietBiDAO
    {
        public List<ThietBiDTO> GetAll()
        {
            var list = new List<ThietBiDTO>();
            string query = "SELECT * FROM ThietBi";

            using (var cmd = new MySqlCommand(query, Database.Connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new ThietBiDTO
                    {
                        MaThietBi = reader.GetInt32("MaThietBi"),
                        TenThietBi = reader.GetString("TenThietBi"),
                        LoaiThietBi = reader.GetString("LoaiThietBi"),
                        TinhTrang = reader.GetString("TinhTrang")
                    });
                }
            }
            return list;
        }
        public bool Add(ThietBiDTO tb)
        {
            string query = "INSERT INTO ThietBi (TenThietBi, LoaiThietBi, TinhTrang) VALUES (@Ten, @Loai, @TinhTrang)";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@Ten", tb.TenThietBi);
                cmd.Parameters.AddWithValue("@Loai", tb.LoaiThietBi);
                cmd.Parameters.AddWithValue("@TinhTrang", tb.TinhTrang);
                return cmd.ExecuteNonQuery() > 0; // Kiểm tra nếu có ít nhất một dòng bị ảnh hưởng
            }
        }

        public bool Update(ThietBiDTO tb)
        {
            string query = "UPDATE ThietBi SET TenThietBi = @Ten, LoaiThietBi = @Loai, TinhTrang = @TinhTrang WHERE MaThietBi = @Id";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@Ten", tb.TenThietBi);
                cmd.Parameters.AddWithValue("@Loai", tb.LoaiThietBi);
                cmd.Parameters.AddWithValue("@TinhTrang", tb.TinhTrang);
                cmd.Parameters.AddWithValue("@Id", tb.MaThietBi);
                return cmd.ExecuteNonQuery() > 0; // Kiểm tra nếu có ít nhất một dòng bị ảnh hưởng
            }
        }

        public bool Delete(int id)
        {
            string query = "DELETE FROM ThietBi WHERE MaThietBi = @Id";
            using (var cmd = new MySqlCommand(query, Database.Connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                return cmd.ExecuteNonQuery() > 0; // Kiểm tra nếu có ít nhất một dòng bị ảnh hưởng
            }
        }
    }

}
