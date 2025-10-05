using MongoDB.Driver;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DoAN_CSDLNC.Data;

namespace DoAN_CSDLNC
{
    public partial class UpdateSupplier : Form
    {
        private readonly IMongoCollection<Supplier> _suppliers;
        private readonly Supplier _supplier;

        public UpdateSupplier(Supplier supplier)
        {
            InitializeComponent();
            var db = new DBConnection();
            _suppliers = db.GetCollection<Supplier>("suppliers");
            _supplier = supplier;

            // Load dữ liệu vào form
            txtName.Text = supplier.Name;
            txtPhone.Text = supplier.Phone;
            txtEmail.Text = supplier.Email;
            txtAddress.Text = supplier.Address;
            txtContactPerson.Text = supplier.ContactPerson;
            txtSupplyProduct.Text = supplier.SupplyProduct;
            chkIsActive.Checked = supplier.IsActive; // nếu đang active thì checkbox được tick
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // nút Trở về
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // nút Cập nhật nhà cung cấp
            if (!ValidateInput()) return;

            var update = Builders<Supplier>.Update
                .Set(s => s.Name, txtName.Text.Trim())
                .Set(s => s.Phone, txtPhone.Text.Trim())
                .Set(s => s.Email, txtEmail.Text.Trim())
                .Set(s => s.Address, txtAddress.Text.Trim())
                .Set(s => s.ContactPerson, txtContactPerson.Text.Trim())
                .Set(s => s.SupplyProduct, txtSupplyProduct.Text.Trim())
                .Set(s => s.IsActive, chkIsActive.Checked);

            _suppliers.UpdateOne(s => s.Id == _supplier.Id, update);

            MessageBox.Show("Cập nhật nhà cung cấp thành công!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!");
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
