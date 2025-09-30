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

            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            try
            {
                var suppliersCollection = _db.GetCollection<Supplier>("suppliers");
                List<Supplier> suppliers = suppliersCollection.Find(_ => true).ToList();

                dataGridView1.DataSource = suppliers;

                // Ẩn cột _id nếu không muốn hiển thị
                if (dataGridView1.Columns["_id"] != null)
                    dataGridView1.Columns["_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu nhà cung cấp: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSupplier form = new AddSupplier();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSuppliers();
            }
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
