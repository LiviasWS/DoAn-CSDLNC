using DoAN_CSDLNC.Data;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class UserUC : UserControl
    {
        private readonly DBConnection _db;

        public UserUC()
        {
            InitializeComponent();
            _db = new DBConnection();

            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                var usersCollection = _db.GetCollection<User>("users");
                List<User> users = usersCollection.Find(_ => true).ToList();

                dataGridView1.DataSource = users;

                // Ẩn mật khẩu vì lý do bảo mật
                if (dataGridView1.Columns["passwordhash"] != null)
                    dataGridView1.Columns["passwordhash"].Visible = false;

                if (dataGridView1.Columns["_id"] != null)
                    dataGridView1.Columns["_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu người dùng: " + ex.Message);
            }
        }
    }
}
