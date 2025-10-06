using DoAN_CSDLNC.BLL;
using DoAN_CSDLNC.DAL;
using Hethongbancafe.CafeManagement.Models;
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
                Note = txtNote.Text
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
        }

        // ================== BUTTON HANDLERS ==================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var nl = ReadForm();
                _nguyenLieuBLL.AddNguyenLieu(nl);
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

                var updated = ReadForm();
                updated.Id = selected.Id;

                _nguyenLieuBLL.UpdateNguyenLieu(selected.Id, updated);
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
                if (selected == null)
                {
                    MessageBox.Show("Chọn dòng để xóa."); return;
                }

                if (MessageBox.Show("Xóa nguyên liệu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _nguyenLieuBLL.DeleteNguyenLieu(selected.Id);
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
            if (selected == null)
            {
                MessageBox.Show("Chọn một dòng.");
                return;
            }

            using (var stockInForm = new StockInForm())
            {
                if (stockInForm.ShowDialog() == DialogResult.OK)
                {
                    int quantityToAdd = stockInForm.QuantityToAdd;

                    selected.MaxStock = (selected.MaxStock ?? 0) + quantityToAdd;
                    _nguyenLieuBLL.UpdateNguyenLieu(selected.Id, selected);
                    LoadData();
                    MessageBox.Show($"Đã nhập kho +{quantityToAdd}.");
                }
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null)
            {
                MessageBox.Show("Chọn một dòng.");
                return;
            }

            var currentStock = selected.MaxStock ?? 0;
            if (currentStock <= 0)
            {
                MessageBox.Show("Không đủ hàng để xuất.");
                return;
            }

            using (var stockOutForm = new StockOutForm())
            {
                if (stockOutForm.ShowDialog() == DialogResult.OK)
                {
                    int quantityToDeduct = stockOutForm.QuantityToDeduct;

                    if (quantityToDeduct > currentStock)
                    {
                        MessageBox.Show($"Không đủ hàng. Tồn kho hiện tại: {currentStock}.");
                        return;
                    }

                    selected.MaxStock = currentStock - quantityToDeduct;
                    _nguyenLieuBLL.UpdateNguyenLieu(selected.Id, selected);
                    LoadData();
                    MessageBox.Show($"Đã xuất kho -{quantityToDeduct}.");
                }
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var selected = GetSelected();
            if (selected == null) { MessageBox.Show("Chọn một dòng."); return; }

            selected.Warehouse = "Kho Lạnh";
            _nguyenLieuBLL.UpdateNguyenLieu(selected.Id, selected);
            LoadData();
            MessageBox.Show("Đã chuyển sang Kho Lạnh.");
        }

        private void btnStockCount_Click(object sender, EventArgs e)
        {
            var items = _nguyenLieuBLL.GetAllNguyenLieus();
            int total = items.Sum(x => x.MaxStock ?? 0);
            MessageBox.Show("Tổng tồn kho: " + total);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            var nl = GetSelected();
            if (nl != null) FillForm(nl);
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

        }
    }
}
