using DoAN_CSDLNC.BLL;
using DoAN_CSDLNC.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoAN_CSDLNC.DAL.NguyenLieuDAL;
using DoAN_CSDLNC.Models;

namespace DoAN_CSDLNC
{
    public partial class ProductManagementForm : Form
    {
        private readonly NguyenLieuBLL _nguyenLieuBLL;
        public ProductManagementForm()
        {
            InitializeComponent();
            _nguyenLieuBLL = new NguyenLieuBLL();
            LoadData();
            LoadSuppliersToCombo();
        }

        private void LoadData()
        {
            try
            {
                var items = _nguyenLieuBLL.GetAllNguyenLieus();
                dgvProducts.AutoGenerateColumns = true;
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = items;
                if (dgvProducts.Columns["Id"] != null)
                    dgvProducts.Columns["Id"].Visible = false;
                dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private NguyenLieu GetSelected()
        {
            return dgvProducts.CurrentRow?.DataBoundItem as NguyenLieu;
        }

        private NguyenLieu ReadForm()
        {
            return new NguyenLieu
            {
                SKU = txtSKU.Text?.Trim(),
                Name = txtName.Text?.Trim(),
                Group = cboGroup.Text,
                Supplier = cboSupplier.Text,
                Warehouse = cboWarehouse.Text,
                UomBase = txtUomBase.Text?.Trim(),
                UomAlt = txtUomAlt.Text?.Trim(),
                ConversionRate = (int?)nudConv.Value,
                PriceIn = nudPriceIn.Value,
                MinStock = (int?)nudMin.Value,
                MaxStock = (int?)nudMax.Value,
                Batch = txtBatch.Text?.Trim(),
                MfgDate = dtpMfg.Checked ? (DateTime?)dtpMfg.Value : null,
                ExpDate = dtpExp.Checked ? (DateTime?)dtpExp.Value : null,
                Fefo = chkFEFO.Checked,
                LossPercent = (double?)nudLoss.Value,
                Note = txtNote.Text,

                // >>> Lưu đường dẫn ảnh
                ImagePath = picImage.Tag as string,
            };
        }

        private void FillForm(NguyenLieu nl)
        {
            if (nl == null) return;

            txtSKU.Text = nl.SKU;
            txtName.Text = nl.Name;
            cboGroup.Text = nl.Group;
            cboSupplier.Text = nl.Supplier;
            cboWarehouse.Text = nl.Warehouse;
            txtUomBase.Text = nl.UomBase;
            txtUomAlt.Text = nl.UomAlt;

            nudConv.Value = (decimal)(nl.ConversionRate ?? 0);
            nudPriceIn.Value = (nl.PriceIn ?? 0);
            nudMin.Value = (decimal)(nl.MinStock ?? 0);
            nudMax.Value = (decimal)(nl.MaxStock ?? 0);

            txtBatch.Text = nl.Batch;

            dtpMfg.Checked = nl.MfgDate.HasValue;
            if (nl.MfgDate.HasValue) dtpMfg.Value = nl.MfgDate.Value;

            dtpExp.Checked = nl.ExpDate.HasValue;
            if (nl.ExpDate.HasValue) dtpExp.Value = nl.ExpDate.Value;

            chkFEFO.Checked = nl.Fefo ?? false;
            nudLoss.Value = (decimal)(nl.LossPercent ?? 0);
            txtNote.Text = nl.Note;

            // >>> Hiển thị ảnh theo sản phẩm
            ShowImage(nl.ImagePath);
        }

        private void ClearForm()
        {
            txtSKU.Clear();
            txtName.Clear();
            cboGroup.SelectedIndex = -1;
            cboSupplier.SelectedIndex = -1;
            cboWarehouse.SelectedIndex = -1;
            txtUomBase.Clear();
            txtUomAlt.Clear();
            nudConv.Value = 0;
            nudPriceIn.Value = 0;
            nudMin.Value = 0;
            nudMax.Value = 0;
            txtBatch.Clear();
            dtpMfg.Checked = false;
            dtpExp.Checked = false;
            chkFEFO.Checked = false;
            nudLoss.Value = 0;
            txtNote.Clear();

            // >>> Xóa ảnh hiển thị
            ShowImage(null);
        }

        // ================== BUTTON HANDLERS ==================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var nl = ReadForm();
                _nguyenLieuBLL.AddNguyenLieu(nl);

                // ✍️ Ghi lịch sử tạo mới (không thay đổi tồn, nên Qty = 0)
                LogHistory(nl, "ADD", 0, 0, nl.MaxStock ?? 0, "Tạo mới sản phẩm");

                LoadData();
                ClearForm();
                MessageBox.Show("Thêm nguyên liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = GetSelected();
                if (selected == null) { MessageBox.Show("Chọn dòng để sửa."); return; }

                var beforeQty = selected.MaxStock ?? 0;

                var updated = ReadForm();
                updated.Id = selected.Id;

                _nguyenLieuBLL.UpdateNguyenLieu(selected.Id, updated);

                var afterQty = updated.MaxStock ?? beforeQty;
                var delta = afterQty - beforeQty;

                LogHistory(updated, "UPDATE", delta, beforeQty, afterQty, "Cập nhật thông tin");

                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = GetSelected();
                if (selected == null) { MessageBox.Show("Chọn dòng để xóa."); return; }

                if (MessageBox.Show("Xóa nguyên liệu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var beforeQty = selected.MaxStock ?? 0;
                    _nguyenLieuBLL.DeleteNguyenLieu(selected.Id);

                    // ✍️ Log trước/ sau = 0
                    LogHistory(selected, "DELETE", -beforeQty, beforeQty, 0, "Xóa sản phẩm");

                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtName.Text?.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadData();
                return;
            }

            var result = _nguyenLieuBLL.SearchNguyenLieu(keyword);
            dgvProducts.DataSource = result;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var list = dgvProducts.DataSource as IEnumerable<NguyenLieu>;
                if (list == null || !list.Any())
                {
                    MessageBox.Show("Không có dữ liệu để xuất.");
                    return;
                }

                using (var sfd = new SaveFileDialog() { Filter = "CSV Files|*.csv", FileName = "NguyenLieu.csv" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        var sb = new StringBuilder();
                        sb.AppendLine("SKU,Name,Group,Supplier,Warehouse,PriceIn,MinStock,MaxStock,Note");
                        foreach (var x in list)
                        {
                            sb.AppendLine(string.Join(",", x.SKU, x.Name, x.Group, x.Supplier, x.Warehouse,
                                x.PriceIn, x.MinStock, x.MaxStock, x.Note));
                        }
                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất CSV thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất CSV: " + ex.Message);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) { MessageBox.Show("Chọn một dòng."); return; }

            using (var stockInForm = new StockInForm())
            {
                if (stockInForm.ShowDialog() == DialogResult.OK)
                {
                    int qty = stockInForm.QuantityToAdd;
                    int before = selected.MaxStock ?? 0;
                    int after = before + qty;

                    selected.MaxStock = after;
                    _nguyenLieuBLL.UpdateNguyenLieu(selected.Id, selected);

                    LogHistory(selected, "IN", +qty, before, after, "Nhập kho");
                    LoadData();
                    MessageBox.Show($"Đã nhập kho +{qty}.");
                }
            }
        }


        private void btnIssue_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) { MessageBox.Show("Chọn một dòng."); return; }

            var current = selected.MaxStock ?? 0;
            if (current <= 0) { MessageBox.Show("Không đủ hàng để xuất."); return; }

            using (var stockOutForm = new StockOutForm())
            {
                if (stockOutForm.ShowDialog() == DialogResult.OK)
                {
                    int qty = stockOutForm.QuantityToDeduct;
                    if (qty > current) { MessageBox.Show($"Không đủ hàng. Tồn: {current}."); return; }

                    int before = current;
                    int after = current - qty;

                    selected.MaxStock = after;
                    _nguyenLieuBLL.UpdateNguyenLieu(selected.Id, selected);

                    LogHistory(selected, "OUT", -qty, before, after, "Xuất kho");
                    LoadData();
                    MessageBox.Show($"Đã xuất kho -{qty}.");
                }
            }
        }


        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) { MessageBox.Show("Chọn một dòng."); return; }

            var before = selected.MaxStock ?? 0;

            selected.Warehouse = "Kho Lạnh"; // ví dụ
            _nguyenLieuBLL.UpdateNguyenLieu(selected.Id, selected);

            LogHistory(selected, "TRANSFER", 0, before, before, "Chuyển kho → Kho Lạnh");
            LoadData();
            MessageBox.Show("Đã chuyển sang Kho Lạnh.");
        }


        private readonly InventoryDAL _inventoryDAL = new InventoryDAL();

        private void btnStockCount_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) { MessageBox.Show("Chọn một mặt hàng để kiểm kê."); return; }

            int current = selected.MaxStock ?? 0;

            // hộp thoại nhập tồn thực tế
            using (var f = new InputNumberForm("Nhập tồn thực tế", current))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    int actual = f.Value;                 // tồn thực tế
                    int delta = actual - current;        // chênh lệch

                    selected.MaxStock = actual;
                    _nguyenLieuBLL.UpdateNguyenLieu(selected.Id, selected);

                    LogHistory(selected, "COUNT", delta, current, actual, "Kiểm kê điều chỉnh");
                    LoadData();
                    MessageBox.Show($"Đã cập nhật tồn từ {current} → {actual} (Δ {delta}).");
                }
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            var nl = GetSelected();
            if (nl != null) FillForm(nl);   // FillForm sẽ tự ShowImage(nl.ImagePath)
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate cơ bản
                if (string.IsNullOrWhiteSpace(txtSKU.Text))
                {
                    MessageBox.Show("Mã (SKU) không được để trống.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSKU.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Tên nguyên liệu không được để trống.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }

                // Lấy dữ liệu từ form
                var nlFromForm = ReadForm();

                // Kiểm tra xem có đang chọn 1 dòng trong grid hay không
                var selected = GetSelected();

                if (selected == null)
                {
                    // Không có dòng chọn => Thêm mới
                    try
                    {
                        _nguyenLieuBLL.AddNguyenLieu(nlFromForm);
                        MessageBox.Show("Đã thêm nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadData();
                    }
                    catch (Exception exAdd)
                    {
                        MessageBox.Show("Lỗi khi thêm nguyên liệu: " + exAdd.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Có dòng chọn => Cập nhật (Save)
                    try
                    {
                        nlFromForm.Id = selected.Id; // gán Id để update
                        _nguyenLieuBLL.UpdateNguyenLieu(selected.Id, nlFromForm);
                        MessageBox.Show("Đã lưu (cập nhật) nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception exUpd)
                    {
                        MessageBox.Show("Lỗi khi cập nhật nguyên liệu: " + exUpd.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không mong muốn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            // Khi form load, gọi hàm để nạp danh sách NCC
            LoadSuppliersToCombo();
        }

        private void LoadSuppliersToCombo()
        {
            cboSupplier.DataSource = null;
            cboSupplier.DataSource = supplierList;
            cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dgvProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || dgvProducts.Rows.Count == 0)
                    return;

                // Lấy dòng hiện tại
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                // Gán giá trị cho các ô nhập liệu
                txtSKU.Text = row.Cells["SKU"].Value?.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
                cboGroup.Text = row.Cells["Group"].Value?.ToString();
                cboSupplier.Text = row.Cells["Supplier"].Value?.ToString();
                cboWarehouse.Text = row.Cells["Warehouse"].Value?.ToString();

                txtUomBase.Text = row.Cells["UomBase"].Value?.ToString();
                txtUomAlt.Text = row.Cells["UomAlt"].Value?.ToString();
                txtBatch.Text = row.Cells["Batch"].Value?.ToString();
                txtNote.Text = row.Cells["Note"].Value?.ToString();

                // NumericUpDown
                if (decimal.TryParse(row.Cells["PriceIn"].Value?.ToString(), out decimal price))
                    nudPriceIn.Value = price > nudPriceIn.Maximum ? nudPriceIn.Maximum : price;

                if (decimal.TryParse(row.Cells["MinStock"].Value?.ToString(), out decimal min))
                    nudMin.Value = min > nudMin.Maximum ? nudMin.Maximum : min;

                if (decimal.TryParse(row.Cells["MaxStock"].Value?.ToString(), out decimal max))
                    nudMax.Value = max > nudMax.Maximum ? nudMax.Maximum : max;

                if (decimal.TryParse(row.Cells["ConversionRate"].Value?.ToString(), out decimal conv))
                    nudConv.Value = conv > nudConv.Maximum ? nudConv.Maximum : conv;

                if (decimal.TryParse(row.Cells["LossPercent"].Value?.ToString(), out decimal loss))
                    nudLoss.Value = loss > nudLoss.Maximum ? nudLoss.Maximum : loss;

                // FEFO checkbox
                if (bool.TryParse(row.Cells["Fefo"].Value?.ToString(), out bool fefo))
                    chkFEFO.Checked = fefo;
                else
                    chkFEFO.Checked = false;

                // DateTimePicker
                if (DateTime.TryParse(row.Cells["MfgDate"].Value?.ToString(), out DateTime mfg))
                {
                    dtpMfg.Value = mfg;
                    dtpMfg.Checked = true;
                }
                else
                    dtpMfg.Checked = false;

                if (DateTime.TryParse(row.Cells["ExpDate"].Value?.ToString(), out DateTime exp))
                {
                    dtpExp.Value = exp;
                    dtpExp.Checked = true;
                }
                else
                    dtpExp.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu dòng: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                var login = new Login();
                login.Show();
                this.Close();
            }

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Chọn ảnh nguyên liệu";
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    ofd.Multiselect = false;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string imgDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images");
                        Directory.CreateDirectory(imgDir);

                        string sku = string.IsNullOrWhiteSpace(txtSKU.Text)
                                     ? Guid.NewGuid().ToString("N")
                                     : txtSKU.Text.Trim();

                        string ext = Path.GetExtension(ofd.FileName);
                        string destPath = Path.Combine(imgDir, $"{sku}{ext}");

                        File.Copy(ofd.FileName, destPath, true);

                        // hiển thị ảnh ngay lập tức
                        ShowImage(destPath);
                        MessageBox.Show("Ảnh đã copy: " + destPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn ảnh: " + ex.Message);
            }
        }


        private void ShowImage(string path)
        {
            try
            {
                if (picImage.Image != null)
                {
                    picImage.Image.Dispose();
                    picImage.Image = null;
                }

                if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
                {
                    picImage.Tag = null;
                    return;
                }

                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var img = Image.FromStream(fs))
                {
                    picImage.Image = (Image)img.Clone();
                }

                picImage.SizeMode = PictureBoxSizeMode.Zoom;
                picImage.Tag = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị ảnh: " + ex.Message);
                picImage.Image = null;
                picImage.Tag = null;
            }
        }




        private readonly StockHistoryDAL _historyDal = new StockHistoryDAL();

        // TODO: lấy username đăng nhập thực tế của bạn.
        // Tạm thời hardcode:
        private string CurrentUsername => "admin";

        private void LogHistory(NguyenLieu nl, string action, int deltaQty, int before, int after, string note = null)
        {
            var h = new StockHistory
            {
                ProductId = nl.Id,
                SKU = nl.SKU,
                Name = nl.Name,
                Action = action,
                Qty = deltaQty,
                BeforeQty = before,
                AfterQty = after,
                Warehouse = nl.Warehouse,
                Username = CurrentUsername,
                Note = note,
                CreatedAt = DateTime.UtcNow
            };

            _historyDal.Insert(h);
        }


        private void btnHistory_Click(object sender, EventArgs e)
        {
            using (var f = new StockHistoryForm())
            {
                f.ShowDialog(this);
            }
        }

        private readonly List<string> supplierList = new List<string>
        {
            "Vinamilk",
            "TH True Milk",
            "Trung Nguyên",
            "Highlands Coffee",
            "An Phát Plastic",
            "Nhựa Minh Tâm",
            "Bao Bì Xanh",
            "Green Pack",
            "The Coffee House",
               "Nestlé"
        };



        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Bỏ qua khi form đang load dữ liệu (không phải thao tác người dùng)
                if (dgvProducts.CurrentRow == null || cboSupplier.SelectedItem == null)
                    return;

                var selected = GetSelected();
                if (selected == null) return;

                string newSupplier = cboSupplier.SelectedItem.ToString();

                // Nếu trùng với giá trị cũ thì không cần làm gì
                if (selected.Supplier == newSupplier) return;

                string oldSupplier = selected.Supplier;

                // Cập nhật vào DB
                selected.Supplier = newSupplier;
                _nguyenLieuBLL.UpdateNguyenLieu(selected.Id, selected);

                // Ghi lịch sử
                LogHistory(selected, "UPDATE", 0, selected.MaxStock ?? 0, selected.MaxStock ?? 0,
                    $"Đổi nhà cung cấp từ '{oldSupplier}' sang '{newSupplier}'");

                MessageBox.Show($"✅ Đã đổi nhà cung cấp sang: {newSupplier}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi nhà cung cấp: " + ex.Message);
            }
        }
    }
}
