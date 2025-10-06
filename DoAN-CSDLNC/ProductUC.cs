using DoAN_CSDLNC.Data;
using DoAN_CSDLNC.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class ProductUC : UserControl
    {
        private readonly DBConnection db;
        private readonly IMongoCollection<Product> productCollection;
        private readonly IMongoCollection<SizeManage> sizeCollection;

        public ProductUC()
        {
            InitializeComponent();
            db = new DBConnection();
            productCollection = db.GetCollection<Product>("products");
            sizeCollection = db.GetCollection<SizeManage>("sizemanage");

            // Thiết lập combo tìm kiếm
            cbSearchBy.Items.AddRange(new string[] { "Mã sản phẩm", "Tên sản phẩm", "Loại sản phẩm" });
            cbSearchBy.SelectedIndex = 0;

            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = productCollection.Find(FilterDefinition<Product>.Empty).ToList();
            DisplayProducts(products);
        }

        private void DisplayProducts(List<Product> products)
        {
            var allSizes = sizeCollection.Find(FilterDefinition<SizeManage>.Empty).ToList();
            var productView = from p in products
                              select new
                              {
                                  p.Id,
                                  p.Code,
                                  p.Name,
                                  p.Category,
                                  SizeS = allSizes.FirstOrDefault(s => s.ProductId == p.Id && s.Size == "S")?.Price ?? 0,
                                  SizeM = allSizes.FirstOrDefault(s => s.ProductId == p.Id && s.Size == "M")?.Price ?? 0,
                                  SizeL = allSizes.FirstOrDefault(s => s.ProductId == p.Id && s.Size == "L")?.Price ?? 0,
                                  p.IsActive
                              };

            dataGridView1.DataSource = productView.ToList();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string searchBy = cbSearchBy.SelectedItem?.ToString();

            // Nếu người dùng không nhập gì → Load toàn bộ
            if (string.IsNullOrEmpty(keyword))
            {
                LoadProducts();
                return;
            }

            List<Product> products;

            switch (searchBy)
            {
                case "Mã sản phẩm":
                    products = productCollection.Find(p => p.Code.ToLower().Contains(keyword.ToLower())).ToList();
                    break;
                case "Tên sản phẩm":
                    products = productCollection.Find(p => p.Name.ToLower().Contains(keyword.ToLower())).ToList();
                    break;
                case "Loại sản phẩm":
                    products = productCollection.Find(p => p.Category.ToLower().Contains(keyword.ToLower())).ToList();
                    break;
                default:
                    products = productCollection.Find(FilterDefinition<Product>.Empty).ToList();
                    break;
            }

            DisplayProducts(products);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            AddProduct addForm = new AddProduct();
            addForm.ShowDialog();
            LoadProducts();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                UpdateProducts updateForm = new UpdateProducts(id);
                updateForm.ShowDialog();
                LoadProducts();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

                var confirm = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    productCollection.DeleteOne(p => p.Id == id);
                    sizeCollection.DeleteMany(s => s.ProductId == id);
                    MessageBox.Show("Đã xóa sản phẩm thành công!");
                    LoadProducts();
                }
            }
        }
    }
}
