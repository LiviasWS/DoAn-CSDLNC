using DoAN_CSDLNC.Data;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class SupplierUC : UserControl
    {
        private readonly DBConnection _db;

        public SupplierUC()
        {
            InitializeComponent();
            _db = new DBConnection();

            comboBoxSearchField.Items.AddRange(new string[] { "Name", "Phone" });
            comboBoxSearchField.SelectedIndex = 0;

            LoadSuppliers();
        }

        private void LoadSuppliers(List<Supplier> suppliers = null)
        {
            try
            {
                var suppliersCollection = _db.GetCollection<Supplier>("suppliers");
                var data = suppliers ?? suppliersCollection.Find(_ => true).ToList();

                dataGridView1.DataSource = data;

                if (dataGridView1.Columns["_id"] != null)
                    dataGridView1.Columns["_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu nhà cung cấp: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var suppliersCollection = _db.GetCollection<Supplier>("suppliers");
                string keyword = txtSearch.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(keyword))
                {
                    LoadSuppliers();
                    return;
                }

                string field = comboBoxSearchField.SelectedItem.ToString();
                FilterDefinition<Supplier> filter = Builders<Supplier>.Filter.Empty;

                if (field == "Name")
                    filter = Builders<Supplier>.Filter.Regex(s => s.Name, new MongoDB.Bson.BsonRegularExpression(keyword, "i"));
                else if (field == "Phone")
                    filter = Builders<Supplier>.Filter.Regex(s => s.Phone, new MongoDB.Bson.BsonRegularExpression(keyword, "i"));

                var suppliers = suppliersCollection.Find(filter).ToList();
                LoadSuppliers(suppliers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm nhà cung cấp: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSupplier form = new AddSupplier();
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    LoadSuppliers();
            //}

            // Khi form thêm Supplier báo "đã thêm", thì reload lại bảng
            form.supplierAdded += (s, args) => LoadSuppliers();

            form.Show(); // dùng Show() để form mở song song, không cần đóng mới load
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để sửa!");
                return;
            }

            Supplier selected = (Supplier)dataGridView1.CurrentRow.DataBoundItem;
            UpdateSupplier form = new UpdateSupplier(selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSuppliers();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa!");
                return;
            }

            Supplier selected = (Supplier)dataGridView1.CurrentRow.DataBoundItem;

            var result = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này?",
                                         "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var suppliersCollection = _db.GetCollection<Supplier>("suppliers");
                suppliersCollection.DeleteOne(s => s.Id == selected.Id);
                LoadSuppliers();
            }
        }
    }
}
