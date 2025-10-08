using DoAN_CSDLNC.Data;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class EmployeeUC : UserControl
    {
        private readonly DBConnection _db;

        public EmployeeUC()
        {
            InitializeComponent();
            _db = new DBConnection();

            comboBoxSearchField.Items.AddRange(new string[] { "Name", "Email", "Phone", "Role" });
            comboBoxSearchField.SelectedIndex = 0;

            comboBoxSearchField.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadEmployees();
        }

        // Load dữ liệu nhân viên từ MongoDB
        private void LoadEmployees(List<Employee> employees = null)
        {
            try
            {
                var employeesCollection = _db.GetCollection<Employee>("employees");
                var data = employees ?? employeesCollection.Find(_ => true).ToList();
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu nhân viên: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var employeesCollection = _db.GetCollection<Employee>("employees");
                string keyword = txtSearch.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(keyword))
                {
                    LoadEmployees();
                    return;
                }

                string field = comboBoxSearchField.SelectedItem.ToString();
                FilterDefinition<Employee> filter = Builders<Employee>.Filter.Empty;

                switch (field)
                {
                    case "Name":
                        filter = Builders<Employee>.Filter.Regex(f => f.Name, new MongoDB.Bson.BsonRegularExpression(keyword, "i"));
                        break;
                    case "Email":
                        filter = Builders<Employee>.Filter.Regex(f => f.Email, new MongoDB.Bson.BsonRegularExpression(keyword, "i"));
                        break;
                    case "Phone":
                        filter = Builders<Employee>.Filter.Regex(f => f.Phone, new MongoDB.Bson.BsonRegularExpression(keyword, "i"));
                        break;
                    case "Role":
                        filter = Builders<Employee>.Filter.Regex(f => f.Role, new MongoDB.Bson.BsonRegularExpression(keyword, "i"));
                        break;
                }

                var employees = employeesCollection.Find(filter).ToList();
                LoadEmployees(employees);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm nhân viên: " + ex.Message);
            }
        }

        // Thêm nhân viên
        private void button1_Click(object sender, EventArgs e)
        {
            // Mở form UpdateEmployee để thêm mới
            var form = new AddEmployee(); // form trống
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    LoadEmployees(); // reload lại bảng
            //}

            // Khi form thêm nhân viên báo "đã thêm", thì reload lại bảng
            form.EmployeeAdded += (s, args) => LoadEmployees();

            form.Show(); // dùng Show() để form mở song song, không cần đóng mới load
        }

        // Sửa nhân viên
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!");
                return;
            }

            // Lấy nhân viên đang chọn
            var selectedEmployee = (Employee)dataGridView1.CurrentRow.DataBoundItem;

            // Mở form UpdateEmployee với dữ liệu có sẵn
            var form = new UpdateEmployee(selectedEmployee);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees(); // reload sau khi update
            }
        }

        // Xóa nhân viên
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
                return;
            }

            var selectedEmployee = (Employee)dataGridView1.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa nhân viên: {selectedEmployee.Name}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var employeesCollection = _db.GetCollection<Employee>("employees");
                    employeesCollection.DeleteOne(emp => emp.Id == selectedEmployee.Id);
                    MessageBox.Show("Đã xóa nhân viên!");
                    LoadEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

    }
}
