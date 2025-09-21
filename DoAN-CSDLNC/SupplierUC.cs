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
    }
}
