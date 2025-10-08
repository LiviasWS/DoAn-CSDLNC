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

        // Khai báo sự kiện
        public event EventHandler EmployeeAdded;

        public AddEmployee()
        {
            InitializeComponent();
            _db = new DBConnection();

            // Thêm các role cố định
            comboBoxRole.Items.Clear();
            comboBoxRole.Items.AddRange(new string[]
            {
                "manager",
                "sell staff",
                "inventory staff",
                "barista",
                "security guard",
                "janitor"
            });

            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Hàm validate dữ liệu trước khi thêm
        private bool ValidateInput()
        {
            var employeesCollection = _db.GetCollection<Employee>("employees");

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên nhân viên không được để trống!");
                return false;
            }
            else
            {
                // Regex cho phép chữ cái có dấu, không dấu và khoảng trắng
                var nameRegex = new Regex(@"^[a-zA-ZÀ-ỹ\s]+$");
                if (!nameRegex.IsMatch(txtName.Text.Trim()))
                {
                    MessageBox.Show("Tên nhân viên không hợp lệ! (Chỉ chứa chữ và khoảng trắng, không chứa số hoặc ký tự đặc biệt)");
                    return false;
                }
            }

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
            else
            {
                // Kiểm tra trùng số điện thoại
                var existsPhone = employeesCollection.Find(e => e.Phone == txtPhone.Text.Trim()).FirstOrDefault();
                if (existsPhone != null)
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại!");
                    return false;
                }
            }

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!emailRegex.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email không hợp lệ!");
                    return false;
                }
                else
                {
                    // Kiểm tra trùng email
                    var existsEmail = employeesCollection.Find(e => e.Email == txtEmail.Text.Trim()).FirstOrDefault();
                    if (existsEmail != null)
                    {
                        MessageBox.Show("Email này đã tồn tại!");
                        return false;
                    }
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
            else
            {
                // Kiểm tra trùng ID Number
                var existsId = employeesCollection.Find(e => e.IdNumber == txtIdNumber.Text.Trim()).FirstOrDefault();
                if (existsId != null)
                {
                    MessageBox.Show("CMND/CCCD (ID Number) này đã tồn tại!");
                    return false;
                }
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

                // Gọi sự kiện báo về UserControl
                EmployeeAdded?.Invoke(this, EventArgs.Empty);

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
                // Lấy role hiện tại
                string role = comboBoxRole.Text.Trim().ToLower();

                // Nếu role thuộc nhóm cần hỏi
                if (role == "manager" || role == "sell staff" || role == "inventory staff")
                {
                    var result = MessageBox.Show(
                        "Nhân viên này thuộc nhóm có quyền truy cập hệ thống.\nBạn có muốn thêm tài khoản user cho nhân viên này không?",
                        "Thêm user?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Gọi form AddUser (chỉ hiển thị, không cần truyền dữ liệu)
                        AddUser frm = new AddUser();
                        frm.ShowDialog();
                    }
                }

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
