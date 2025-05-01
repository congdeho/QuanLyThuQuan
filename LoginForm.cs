using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuQuan.DAO;
using QuanLyThuQuan.DTO;

namespace QuanLyThuQuan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaiKhoanDAO dao = new TaiKhoanDAO();
            List<TaiKhoanDTO> taiKhoans = dao.GetAll(); // Giả sử DAO trả về danh sách tất cả tài khoản

            var user = taiKhoans.Find(x => x.Email == email && x.MatKhau == password);

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form chính nếu có
                this.Hide();
                MainForm main = new MainForm(); // Bạn cần tạo MainForm
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
