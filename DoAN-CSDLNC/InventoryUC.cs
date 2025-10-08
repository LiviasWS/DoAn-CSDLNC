using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using DoAN_CSDLNC.Data;
using DoAN_CSDLNC.Models;

namespace DoAN_CSDLNC
{
    public partial class InventoryUC : UserControl
    {
        private readonly IMongoCollection<NguyenLieu> _inventoryCollection;

        public InventoryUC()
        {
            InitializeComponent();

            var db = new DBConnection();
            _inventoryCollection = db.GetCollection<NguyenLieu>("Nguyenlieu");

            this.Load += InventoryUC_Load;

            // Gán giá trị cho ComboBox tìm kiếm
            cbSearchCriteria.Items.AddRange(new string[] { "Tên nguyên liệu", "Nhóm" });
            cbSearchCriteria.SelectedIndex = 0;

            // Khóa không cho nhập giá trị ngoài vào ComboBox
            cbSearchCriteria.DropDownStyle = ComboBoxStyle.DropDownList;

            btnSearch.Click += BtnSearch_Click;
        }

        private void InventoryUC_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void LoadInventoryData(FilterDefinition<NguyenLieu> filter = null)
        {
            try
            {
                var nguyenLieus = (filter == null)
                    ? _inventoryCollection.Find(_ => true).ToList()
                    : _inventoryCollection.Find(filter).ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("Mã hàng");
                dt.Columns.Add("Tên nguyên liệu");
                dt.Columns.Add("Nhóm");
                dt.Columns.Add("Nhà cung cấp");
                dt.Columns.Add("Kho");
                dt.Columns.Add("Đơn vị chính");
                dt.Columns.Add("Đơn vị phụ");
                dt.Columns.Add("Tỉ lệ quy đổi");
                dt.Columns.Add("Giá nhập");
                dt.Columns.Add("Tồn tối thiểu");
                dt.Columns.Add("Tồn tối đa");
                dt.Columns.Add("Lô hàng");
                dt.Columns.Add("Ngày SX");
                dt.Columns.Add("HSD");
                dt.Columns.Add("FEFO");
                dt.Columns.Add("% hao hụt");
                dt.Columns.Add("Ghi chú");

                foreach (var item in nguyenLieus)
                {
                    dt.Rows.Add(
                        item.SKU,
                        item.Name,
                        item.Group,
                        item.Supplier,
                        item.Warehouse,
                        item.UomBase,
                        item.UomAlt,
                        item.ConversionRate?.ToString() ?? "",
                        item.PriceIn?.ToString("N0") ?? "",
                        item.MinStock?.ToString() ?? "",
                        item.MaxStock?.ToString() ?? "",
                        item.Batch,
                        item.MfgDate?.ToString("dd/MM/yyyy") ?? "",
                        item.ExpDate?.ToString("dd/MM/yyyy") ?? "",
                        item.Fefo.HasValue ? (item.Fefo.Value ? "Có" : "Không") : "",
                        item.LossPercent?.ToString("0.##") ?? "",
                        item.Note
                    );
                }

                dgvInventory.DataSource = dt;

                dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvInventory.ReadOnly = true;
                dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvInventory.AllowUserToAddRows = false;
                dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu kho: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // === SỰ KIỆN TÌM KIẾM ===
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string criteria = cbSearchCriteria.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                // Nếu không nhập gì thì load toàn bộ
                LoadInventoryData();
                return;
            }

            FilterDefinition<NguyenLieu> filter = null;
            var builder = Builders<NguyenLieu>.Filter;

            if (criteria == "Tên nguyên liệu")
            {
                filter = builder.Regex("name", new MongoDB.Bson.BsonRegularExpression(keyword, "i"));
            }
            else if (criteria == "Nhóm")
            {
                filter = builder.Regex("group", new MongoDB.Bson.BsonRegularExpression(keyword, "i"));
            }

            LoadInventoryData(filter);
        }
    }
}
