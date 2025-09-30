using MongoDB.Driver;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DoAN_CSDLNC.Data;

namespace DoAN_CSDLNC
{
    public partial class AddEmployee : Form
    {
        private readonly DBConnection _db;

        public AddEmployee()
        {
            InitializeComponent();
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
        }

        // Hàm validate dữ liệu trước khi thêm
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

        // Hàm thêm nhân viên (tái sử dụng cho nhiều nút)
        private bool AddEmployeeToDB()
        {
            try
            {
                if (!ValidateInput())
                    return false;

                var employeesCollection = _db.GetCollection<Employee>("employees");

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
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message);
                return false;
            }
        }

        // Nút "Thêm" -> thêm xong thì đóng form
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (AddEmployeeToDB())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        // Nút "Thêm nhân viên khác" -> thêm xong thì clear form
        private void button3_Click(object sender, EventArgs e)
        {
            if (AddEmployeeToDB())
            {
                txtName.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtAddress.Clear();
                txtIdNumber.Clear();
                comboBoxRole.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
