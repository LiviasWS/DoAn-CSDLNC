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

        // Thêm user
        private void button1_Click(object sender, EventArgs e)
        {
            var addForm = new AddUser();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        // Sửa user
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn user cần sửa!");
                return;
            }

            var user = (User)dataGridView1.CurrentRow.DataBoundItem;
            var updateForm = new UpdateUser(user);
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        // Xóa user
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn user cần xóa!");
                    return;
                }

                var usersCollection = _db.GetCollection<User>("users");

                string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                var filter = Builders<User>.Filter.Eq(u => u.Id, id);

                var confirm = MessageBox.Show("Bạn có chắc muốn xóa user này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    usersCollection.DeleteOne(filter);
                    MessageBox.Show("Xóa user thành công!");
                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa user: " + ex.Message);
            }
        }

    }
}
