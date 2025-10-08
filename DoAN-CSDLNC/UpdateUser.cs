using DoAN_CSDLNC.Data;
using MongoDB.Driver;
using System;
using System.Windows.Forms;
using BCrypt.Net;

namespace DoAN_CSDLNC
{
    public partial class UpdateUser : Form
    {
        private readonly DBConnection _db;
        private readonly string _userId;

        public UpdateUser(User user)
        {
            InitializeComponent();
            _db = new DBConnection();

            _userId = user.Id;
            textBox1.Text = user.Username;

            if (user.Role == "manager")
                radioButton1.Checked = true;
            else if (user.Role == "sell_staff")
                radioButton2.Checked = true;
            else
                radioButton3.Checked = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                var usersCollection = _db.GetCollection<User>("users");

                string username = textBox1.Text.Trim();
                string newPassword = txtPassword.Text.Trim(); // ô nhập mật khẩu mới
                string role = radioButton1.Checked ? "manager" :
                              radioButton2.Checked ? "sell_staff" :
                              radioButton3.Checked ? "inventory_staff" : null;

                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Tên đăng nhập không được để trống!");
                    return;
                }

                // Xây dựng phần cập nhật
                var filter = Builders<User>.Filter.Eq(u => u.Id, _userId);
                var updateDef = Builders<User>.Update
                    .Set(u => u.Username, username)
                    .Set(u => u.Role, role);

                // Nếu người dùng nhập mật khẩu mới → mã hóa & cập nhật
                if (!string.IsNullOrWhiteSpace(newPassword))
                {
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                    updateDef = updateDef.Set(u => u.PasswordHash, hashedPassword);
                }

                usersCollection.UpdateOne(filter, updateDef);

                MessageBox.Show("Cập nhật user thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật user: " + ex.Message);
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
