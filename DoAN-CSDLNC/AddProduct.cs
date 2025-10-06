using DoAN_CSDLNC.Data;
using DoAN_CSDLNC.Models;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class AddProduct : Form
    {
        private readonly DBConnection db;
        private readonly IMongoCollection<Product> productCollection;
        private readonly IMongoCollection<SizeManage> sizeCollection;

        public AddProduct()
        {
            InitializeComponent();
            db = new DBConnection();
            productCollection = db.GetCollection<Product>("products");
            sizeCollection = db.GetCollection<SizeManage>("sizemanage");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                // Kiểm tra trùng mã hoặc tên
                if (productCollection.Find(k => k.Code == txtMaSP.Text.Trim()).Any())
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại, vui lòng nhập mã khác!");
                    return;
                }
                if (productCollection.Find(k => k.Name.ToLower() == txtTenSP.Text.Trim().ToLower()).Any())
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại, vui lòng nhập tên khác!");
                    return;
                }

                // Tạo đối tượng Product, mặc định IsActive = true
                Product p = new Product
                {
                    Code = txtMaSP.Text.Trim(),
                    Name = txtTenSP.Text.Trim(),
                    Category = txtLoaiSP.Text.Trim(),
                    Image = "",
                    IsActive = true // mặc định còn bán
                };

                productCollection.InsertOne(p);

                // Lưu các size nếu hợp lệ
                SaveSizeIfValid(p.Id, "S", txtSizeS.Text);
                SaveSizeIfValid(p.Id, "M", txtSizeM.Text);
                SaveSizeIfValid(p.Id, "L", txtSizeL.Text);

                MessageBox.Show("Thêm sản phẩm thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                if (productCollection.Find(b => b.Code == txtMaSP.Text.Trim()).Any())
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại, vui lòng nhập mã khác!");
                    return;
                }
                if (productCollection.Find(b => b.Name.ToLower() == txtTenSP.Text.Trim().ToLower()).Any())
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại, vui lòng nhập tên khác!");
                    return;
                }

                Product p = new Product
                {
                    Code = txtMaSP.Text.Trim(),
                    Name = txtTenSP.Text.Trim(),
                    Category = txtLoaiSP.Text.Trim(),
                    Image = "",
                    IsActive = true
                };

                productCollection.InsertOne(p);

                SaveSizeIfValid(p.Id, "S", txtSizeS.Text);
                SaveSizeIfValid(p.Id, "M", txtSizeM.Text);
                SaveSizeIfValid(p.Id, "L", txtSizeL.Text);

                MessageBox.Show("Đã thêm sản phẩm! Mời nhập sản phẩm mới...");

                txtMaSP.Clear();
                txtTenSP.Clear();
                txtLoaiSP.Clear();
                txtSizeS.Clear();
                txtSizeM.Clear();
                txtSizeL.Clear();
                txtMaSP.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        // Hàm lưu size hợp lệ
        private void SaveSizeIfValid(string productId, string size, string priceText)
        {
            if (int.TryParse(priceText, out int price))
            {
                sizeCollection.InsertOne(new SizeManage
                {
                    ProductId = productId,
                    Size = size,
                    Price = price
                });
            }
        }

        // Hàm kiểm tra hợp lệ trước khi lưu
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
                string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(txtLoaiSP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã, Tên và Loại sản phẩm!");
                return false;
            }

            // Kiểm tra các ô giá (nếu có nhập thì phải là số)
            if (!string.IsNullOrWhiteSpace(txtSizeS.Text) && !int.TryParse(txtSizeS.Text, out _))
            {
                MessageBox.Show("Giá size S phải là số nguyên!");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtSizeM.Text) && !int.TryParse(txtSizeM.Text, out _))
            {
                MessageBox.Show("Giá size M phải là số nguyên!");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtSizeL.Text) && !int.TryParse(txtSizeL.Text, out _))
            {
                MessageBox.Show("Giá size L phải là số nguyên!");
                return false;
            }

            return true;
        }
    }
}
