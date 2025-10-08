using DoAN_CSDLNC.Data;
using DoAN_CSDLNC.Models;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class UpdateProducts : Form
    {
        private readonly DBConnection db;
        private readonly IMongoCollection<Product> productCollection;
        private readonly IMongoCollection<SizeManage> sizeCollection;
        private readonly string productId;

        public UpdateProducts(string id)
        {
            InitializeComponent();
            db = new DBConnection();
            productCollection = db.GetCollection<Product>("Products");
            sizeCollection = db.GetCollection<SizeManage>("Size_Manages");
            productId = id;
            LoadData();
        }

        private void LoadData()
        {
            var product = productCollection.Find(p => p.Id == productId).FirstOrDefault();
            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!");
                this.Close();
                return;
            }

            txtMaSP.Text = product.Code;
            txtTenSP.Text = product.Name;
            txtLoaiSP.Text = product.Category;
            chkConBan.Checked = product.IsActive;

            var sizes = sizeCollection.Find(s => s.ProductId == product.Id).ToList();
            txtSizeS.Text = sizes.FirstOrDefault(s => s.Size == "S")?.Price.ToString() ?? "";
            txtSizeM.Text = sizes.FirstOrDefault(s => s.Size == "M")?.Price.ToString() ?? "";
            txtSizeL.Text = sizes.FirstOrDefault(s => s.Size == "L")?.Price.ToString() ?? "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                // Kiểm tra trùng mã & tên (trừ chính sản phẩm đang cập nhật)
                if (productCollection.Find(p => p.Code == txtMaSP.Text.Trim() && p.Id != productId).Any())
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại!");
                    return;
                }
                if (productCollection.Find(p => p.Name.ToLower() == txtTenSP.Text.Trim().ToLower() && p.Id != productId).Any())
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại!");
                    return;
                }

                var update = Builders<Product>.Update
                    .Set(p => p.Code, txtMaSP.Text.Trim())
                    .Set(p => p.Name, txtTenSP.Text.Trim())
                    .Set(p => p.Category, txtLoaiSP.Text.Trim())
                    .Set(p => p.IsActive, chkConBan.Checked);

                productCollection.UpdateOne(p => p.Id == productId, update);

                UpdateOrInsertSize("S", txtSizeS.Text);
                UpdateOrInsertSize("M", txtSizeM.Text);
                UpdateOrInsertSize("L", txtSizeL.Text);

                MessageBox.Show("Cập nhật sản phẩm thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật sản phẩm: " + ex.Message);
            }
        }

        private void UpdateOrInsertSize(string size, string priceText)
        {
            if (!int.TryParse(priceText, out int price)) return;

            var existing = sizeCollection.Find(s => s.ProductId == productId && s.Size == size).FirstOrDefault();
            if (existing != null)
            {
                var update = Builders<SizeManage>.Update.Set(s => s.Price, price);
                sizeCollection.UpdateOne(s => s.Id == existing.Id, update);
            }
            else
            {
                sizeCollection.InsertOne(new SizeManage
                {
                    ProductId = productId,
                    Size = size,
                    Price = price
                });
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
                string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(txtLoaiSP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã, Tên và Loại sản phẩm!");
                return false;
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn hủy cập nhật không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
