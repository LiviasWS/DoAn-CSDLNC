using MongoDB.Driver;
using System;
using System.Windows.Forms;
using DoAN_CSDLNC.Data;

namespace DoAN_CSDLNC
{
    public partial class Login : Form
    {
        private IMongoCollection<User> _usersCollection;

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = button1;

            var db = new DBConnection();
            _usersCollection = db.GetCollection<User>("users");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đủ username và password!");
                return;
            }

            // Tìm user trong MongoDB
            var user = _usersCollection.Find(u => u.Username == username).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Sai username hoặc password!");
                return;
            }

            // Verify password với BCrypt
            if (PasswordHelper.VerifyPassword(password, user.PasswordHash))
            {
                MessageBox.Show("Đăng nhập thành công!");

                if (user.Role == "manager")
                {
                    Manage manageForm = new Manage();
                    manageForm.Show();
                    this.Hide();

                    // khi form Staff đóng thì thoát app
                    manageForm.FormClosed += (s, args) => Application.Exit();
                }
                else if (user.Role == "staff")
                {
                    StaffForm staffForm = new StaffForm();
                    staffForm.Show();
                    this.Hide();

                    // khi form Staff đóng thì thoát app
                    staffForm.FormClosed += (s, args) => Application.Exit();
                }
                else
                {
                    MessageBox.Show("Vai trò không hợp lệ!");
                }
            }
            else
            {
                MessageBox.Show("Sai username hoặc password!");
            }
        }

    }
}

