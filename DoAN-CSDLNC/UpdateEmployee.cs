using MongoDB.Driver;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DoAN_CSDLNC.Data;

namespace DoAN_CSDLNC
{
    public partial class UpdateEmployee : Form
    {
        private readonly DBConnection _db;
        private Employee _employee;

        public UpdateEmployee(Employee emp)
        {
            InitializeComponent();       // ⚡ Quan trọng: khởi tạo control trước
            _db = new DBConnection();

            // Thêm các role cố định
            comboBoxRole.Items.Clear();
            comboBoxRole.Items.AddRange(new string[]
            {
                "manage",
                "staff",
                "security guard",
                "shipper"
            });

            _employee = emp;
            if (_employee != null)
            {
                // Load dữ liệu cũ lên form
                txtName.Text = emp.Name;
                txtPhone.Text = emp.Phone;
                txtEmail.Text = emp.Email;
                txtAddress.Text = emp.Address;
                txtIdNumber.Text = emp.IdNumber;
                dateTimePicker1.Value = emp.DateOfBirth;

                if (!string.IsNullOrEmpty(emp.Role))
                {
                    comboBoxRole.SelectedItem = emp.Role;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var employeesCollection = _db.GetCollection<Employee>("employees");

            if (_employee == null)
            {
                // Thêm mới
                var newEmp = new Employee
                {
                    Name = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    IdNumber = txtIdNumber.Text.Trim(),
                    DateOfBirth = dateTimePicker1.Value,
                    Role = comboBoxRole.Text,
                    IsActive = true
                };
                employeesCollection.InsertOne(newEmp);
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            else
            {
                // Cập nhật
                var update = Builders<Employee>.Update
                    .Set(emp => emp.Name, txtName.Text.Trim())
                    .Set(emp => emp.Phone, txtPhone.Text.Trim())
                    .Set(emp => emp.Email, txtEmail.Text.Trim())
                    .Set(emp => emp.Address, txtAddress.Text.Trim())
                    .Set(emp => emp.IdNumber, txtIdNumber.Text.Trim())
                    .Set(emp => emp.DateOfBirth, dateTimePicker1.Value)
                    .Set(emp => emp.Role, comboBoxRole.Text);

                employeesCollection.UpdateOne(emp => emp.Id == _employee.Id, update);
                MessageBox.Show("Cập nhật nhân viên thành công!");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hàm kiểm tra dữ liệu nhập vào
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên nhân viên không được để trống!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!");
                return false;
            }
            else if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số!");
                return false;
            }

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!emailRegex.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email không hợp lệ!");
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(comboBoxRole.Text))
            {
                MessageBox.Show("Vui lòng chọn vai trò!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIdNumber.Text))
            {
                MessageBox.Show("CMND/CCCD (ID Number) không được để trống!");
                return false;
            }
            else if (!Regex.IsMatch(txtIdNumber.Text.Trim(), @"^\d+$"))
            {
                MessageBox.Show("CMND/CCCD (ID Number) chỉ được nhập số!");
                return false;
            }

            return true;
        }
    }
}
