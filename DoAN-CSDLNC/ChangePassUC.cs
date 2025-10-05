using DoAN_CSDLNC.Data;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class ChangePassUC : UserControl
    {
        private readonly DBConnection _db;

        public ChangePassUC()
        {
            InitializeComponent();
            _db = new DBConnection();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string currentPass = txtCurrentPassword.Text.Trim();
            string newPass = txtNewPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(currentPass) ||
                string.IsNullOrEmpty(newPass) ||
                string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            var currentUser = Session.CurrentUser;
            if (currentUser == null)
            {
                MessageBox.Show("Không xác định được người dùng hiện tại!");
                return;
            }

            // Kiểm tra mật khẩu hiện tại đúng không
            if (!PasswordHelper.VerifyPassword(currentPass, currentUser.PasswordHash))
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!");
                return;
            }

            // Kiểm tra mật khẩu mới trùng khớp
            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp!");
                return;
            }

            // Kiểm tra trùng mật khẩu cũ
            if (PasswordHelper.VerifyPassword(newPass, currentUser.PasswordHash))
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu hiện tại!");
                return;
            }

            try
            {
                // Mã hóa mật khẩu mới
                string newHash = PasswordHelper.HashPassword(newPass);

                // Cập nhật trong DB
                var users = _db.GetCollection<User>("users");
                var filter = Builders<User>.Filter.Eq(u => u.Id, currentUser.Id);
                var update = Builders<User>.Update.Set(u => u.PasswordHash, newHash);
                users.UpdateOne(filter, update);

                // Cập nhật lại trong Session
                currentUser.PasswordHash = newHash;

                MessageBox.Show("Đổi mật khẩu thành công!");
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu: " + ex.Message);
            }
        }
    }
}
