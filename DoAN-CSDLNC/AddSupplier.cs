using MongoDB.Driver;
using System;
using System.Windows.Forms;
using DoAN_CSDLNC.Data;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace DoAN_CSDLNC
{
    public partial class AddSupplier : Form
    {
        private readonly IMongoCollection<Supplier> _suppliers;

        public AddSupplier()
        {
            InitializeComponent();
            var db = new DBConnection();
            _suppliers = db.GetCollection<Supplier>("suppliers");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // nút Trở về
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // nút Thêm nhà cung cấp
            if (!ValidateInput()) return;

            var supplier = new Supplier
            {
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                ContactPerson = txtContactPerson.Text.Trim(),
                SupplyProduct = txtSupplyProduct.Text.Trim(),
                // Không cần gán IsActive vì mặc định = true
            };

            _suppliers.InsertOne(supplier);
            MessageBox.Show("Thêm nhà cung cấp thành công!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // nút Thêm nhà cung cấp khác
            if (!ValidateInput()) return;

            var supplier = new Supplier
            {
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                ContactPerson = txtContactPerson.Text.Trim(),
                SupplyProduct = txtSupplyProduct.Text.Trim(),
                // IsActive mặc định true
            };

            _suppliers.InsertOne(supplier);
            MessageBox.Show("Thêm nhà cung cấp thành công!");

            // Clear form để nhập mới
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtContactPerson.Clear();
            txtSupplyProduct.Clear();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !long.TryParse(txtPhone.Text, out _))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return false;
            }
            // Kiểm tra số điện thoại chỉ gồm số
            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số!");
                return false;
            }
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                // Regex kiểm tra email cơ bản
                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!emailRegex.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email không hợp lệ!");
                    return false;
                }
            }
            return true;
        }
    }
}
