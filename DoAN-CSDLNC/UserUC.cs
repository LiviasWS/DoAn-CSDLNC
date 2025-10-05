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

            comboBoxSearchField.Items.AddRange(new string[] { "Username", "Role" });
            comboBoxSearchField.SelectedIndex = 0;

            LoadUsers();
        }

        private void LoadUsers(List<User> users = null)
        {
            try
            {
                var usersCollection = _db.GetCollection<User>("users");
                var data = users ?? usersCollection.Find(_ => true).ToList();

                dataGridView1.DataSource = data;

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var usersCollection = _db.GetCollection<User>("users");
                string keyword = txtSearch.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(keyword))
                {
                    LoadUsers();
                    return;
                }

                string field = comboBoxSearchField.SelectedItem.ToString();
                FilterDefinition<User> filter = Builders<User>.Filter.Empty;

                if (field == "Username")
                    filter = Builders<User>.Filter.Regex(u => u.Username, new MongoDB.Bson.BsonRegularExpression(keyword, "i"));
                else if (field == "Role")
                    filter = Builders<User>.Filter.Regex(u => u.Role, new MongoDB.Bson.BsonRegularExpression(keyword, "i"));

                var users = usersCollection.Find(filter).ToList();
                LoadUsers(users);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm user: " + ex.Message);
            }
        }

        // Thêm user
        private void button1_Click(object sender, EventArgs e)
        {
            //var addForm = new AddUser();
            AddUser form = new AddUser();
            //if (addForm.ShowDialog() == DialogResult.OK)
            //{
            //    LoadUsers();
            //}

            // Khi form thêm Supplier báo "đã thêm", thì reload lại bảng
            form.UserAdded += (s, args) => LoadUsers();
            form.Show(); // dùng Show() để form mở song song, không cần đóng mới load
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
