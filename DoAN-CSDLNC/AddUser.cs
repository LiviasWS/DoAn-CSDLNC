using DoAN_CSDLNC.Data;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class AddUser : Form
    {
        private readonly DBConnection _db;

        // Khai báo sự kiện
        public event EventHandler UserAdded;

        public AddUser()
        {
            InitializeComponent();
            _db = new DBConnection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (SaveUser())
            {
                MessageBox.Show("Thêm user thành công!");

                UserAdded?.Invoke(this, EventArgs.Empty);

                this.DialogResult = DialogResult.OK; // báo form cha reload
                this.Close();
            }
        }

        private void btnThemUserKhac_Click(object sender, EventArgs e)
        {
            if (SaveUser())
            {
                MessageBox.Show("Thêm user thành công! Mời nhập user khác.");

                UserAdded?.Invoke(this, EventArgs.Empty);

                // Reset form
                textBox1.Clear();
                textBox2.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                textBox1.Focus();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Lưu user vào MongoDB, trả về true nếu lưu thành công
        /// </summary>
        private bool SaveUser()
        {
            try
            {
                var usersCollection = _db.GetCollection<User>("users");

                string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();
                string role = radioButton1.Checked ? "manager" :
                              radioButton2.Checked ? "sell_staff" :
                              radioButton3.Checked ? "inventory_staff": null;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || role == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Username, Password và chọn Role!");
                    return false;
                }

                // Check user tồn tại
                var exists = usersCollection.Find(u => u.Username == username).FirstOrDefault();
                if (exists != null)
                {
                    MessageBox.Show("Username đã tồn tại!");
                    return false;
                }

                var newUser = new User
                {
                    Username = username,
                    PasswordHash = PasswordHelper.HashPassword(password),
                    Role = role
                };

                usersCollection.InsertOne(newUser);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm user: " + ex.Message);
                return false;
            }
        }
    }
}
