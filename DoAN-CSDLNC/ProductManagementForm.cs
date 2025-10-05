using DoAN_CSDLNC.DAL;
using Hethongbancafe.CafeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoAN_CSDLNC
{
    public partial class ProductManagementForm : Form
    {
        private readonly NguyenLieuDAL _nguyenLieuDAL;

        private enum FormMode { None, Add, Edit }
        private FormMode _mode = FormMode.None;
        private string _editingId = null;
        public ProductManagementForm()
        {
            InitializeComponent();

            _nguyenLieuDAL = new NguyenLieuDAL();

            // Gắn event: TÊN HÀM phải trùng 100%
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnSave.Click += btnSave_Click;
            btnSearch.Click += btnSearch_Click;

            // Các nút khác nếu có trên form
            btnExport.Click += btnExport_Click;
            btnReceive.Click += btnRecieve_Click;   // tên đúng: Receive (không phải Recieve)
            btnIssue.Click += btnIssue_Click;
            btnTransfer.Click += btnTransfer_Click;
            btnStockCount.Click += btnStockCount_Click;
            btnClear.Click += btnClear_Click;

            // Chọn dòng -> đổ lên form
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;

            // Load dữ liệu lúc mở form
            this.Load += async (_, __) => await RefreshGridAsync();

            // (khuyên) bật checkbox cho DateTimePicker nếu muốn cho phép null
            dtpMfg.ShowCheckBox = true;
            dtpExp.ShowCheckBox = true;
        }

        // ================== DATA BIND ==================
        private async Task RefreshGridAsync()
        {
            var items = await _nguyenLieuDAL.GetAllNguyenLieusAsync();
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = items;
            if (dgvProducts.Columns["Id"] != null)
                dgvProducts.Columns["Id"].Visible = false;
        }

        private NguyenLieu GetSelectedRow()
        {
            return dgvProducts.CurrentRow?.DataBoundItem as NguyenLieu;
        }

        private void FillForm(NguyenLieu nl)
        {
            if (nl == null) return;
            _editingId = nl.Id;

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

            if (nl.MfgDate.HasValue) { dtpMfg.Value = nl.MfgDate.Value; dtpMfg.Checked = true; } else dtpMfg.Checked = false;
            if (nl.ExpDate.HasValue) { dtpExp.Value = nl.ExpDate.Value; dtpExp.Checked = true; } else dtpExp.Checked = false;

            chkFEFO.Checked = nl.Fefo ?? false;
            nudLoss.Value = (decimal)(nl.LossPercent ?? 0);
            txtNote.Text = nl.Note;
        }

        private void ClearForm()
        {
            _editingId = null;
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

        private bool ValidateForm(out string message)
        {
            if (string.IsNullOrWhiteSpace(txtSKU.Text))
            {
                message = "Mã (SKU) không được để trống.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                message = "Tên nguyên liệu không được để trống.";
                return false;
            }
            message = null;
            return true;
        }

        private NguyenLieu ReadForm()
        {
            return new NguyenLieu
            {
                Id = _editingId,
                SKU = txtSKU.Text?.Trim(),
                Name = txtName.Text?.Trim(),
                Group = cboGroup.Text,
                Supplier = cboSupplier.Text,
                Warehouse = cboWarehouse.Text,
                UomBase = txtUomBase.Text?.Trim(),
                UomAlt = txtUomAlt.Text?.Trim(),
                ConversionRate = (int?)nudConv.Value,         // nullable
                PriceIn = nudPriceIn.Value,            // decimal?
                MinStock = (int?)nudMin.Value,
                MaxStock = (int?)nudMax.Value,
                Batch = txtBatch.Text?.Trim(),
                MfgDate = dtpMfg.Checked ? dtpMfg.Value : (DateTime?)null,
                ExpDate = dtpExp.Checked ? dtpExp.Value : (DateTime?)null,
                Fefo = chkFEFO.Checked,
                LossPercent = (double?)nudLoss.Value,
                Note = txtNote.Text
            };
        }

        // ================== EVENTS ==================
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (_mode == FormMode.Add) return;
            var nl = GetSelectedRow();
            if (nl != null)
            {
                _mode = FormMode.Edit;
                FillForm(nl);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _mode = FormMode.Add;
            ClearForm();
            txtSKU.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var nl = GetSelectedRow();
            if (nl == null) { MessageBox.Show("Chọn một dòng để sửa."); return; }
            _mode = FormMode.Edit;
            FillForm(nl);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var nl = GetSelectedRow();
            if (nl == null) { MessageBox.Show("Chọn một dòng để xóa."); return; }

            if (MessageBox.Show("Xóa nguyên liệu này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await _nguyenLieuDAL.DeleteNguyenLieuAsync(nl.Id);
                await RefreshGridAsync();
                ClearForm();
                _mode = FormMode.None;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(out var msg))
            {
                MessageBox.Show(msg, "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var data = ReadForm();

                if (_mode == FormMode.Add)
                {
                    // tránh trùng SKU (client-side)
                    var all = await _nguyenLieuDAL.GetAllNguyenLieusAsync();
                    if (all.Any(x => string.Equals(x.SKU, data.SKU, StringComparison.OrdinalIgnoreCase)))
                    {
                        MessageBox.Show("SKU đã tồn tại. Vui lòng nhập mã khác.");
                        return;
                    }

                    await _nguyenLieuDAL.AddNguyenLieuAsync(data);
                    MessageBox.Show("Đã thêm nguyên liệu!");
                }
                else if (_mode == FormMode.Edit && !string.IsNullOrEmpty(_editingId))
                {
                    await _nguyenLieuDAL.UpdateNguyenLieuAsync(_editingId, data);
                    MessageBox.Show("Đã cập nhật nguyên liệu!");
                }
                else
                {
                    MessageBox.Show("Chưa chọn chế độ Thêm/Sửa.");
                    return;
                }

                _mode = FormMode.None;
                await RefreshGridAsync();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            // Nếu muốn InputBox: uncomment using Microsoft.VisualBasic và block dưới
            // var keyword = Interaction.InputBox("Nhập từ khóa (SKU/Tên):", "Tìm kiếm", "");
            // if (string.IsNullOrWhiteSpace(keyword)) { await RefreshGridAsync(); return; }
            // var k = keyword.Trim();

            // Mình dùng Prompt đơn giản:
            var k = txtName.Text?.Trim(); // ví dụ lấy theo ô tên; bạn có thể làm TextBox riêng cho search
            if (string.IsNullOrWhiteSpace(k)) { await RefreshGridAsync(); return; }

            var items = await _nguyenLieuDAL.GetAllNguyenLieusAsync();
            var filtered = items.Where(x =>
                (!string.IsNullOrEmpty(x.SKU) && x.SKU.IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrEmpty(x.Name) && x.Name.IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0)
            ).ToList();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = filtered;
            if (dgvProducts.Columns["Id"] != null)
                dgvProducts.Columns["Id"].Visible = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Xuất CSV (tránh lỗi ClosedXML). Nếu muốn Excel .xlsx, cài ClosedXML + DocumentFormat.OpenXml
            using (var sfd = new SaveFileDialog() { Filter = "CSV Files|*.csv", FileName = "NguyenLieu.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var list = dgvProducts.DataSource as IEnumerable<NguyenLieu>;
                        if (list == null)
                        {
                            MessageBox.Show("Không có dữ liệu để xuất.");
                            return;
                        }

                        var sb = new StringBuilder();
                        sb.AppendLine("SKU,Name,Group,Supplier,Warehouse,UomBase,UomAlt,ConversionRate,PriceIn,MinStock,MaxStock,Batch,MfgDate,ExpDate,FEFO,LossPercent,Note");
                        foreach (var x in list)
                        {
                            sb.AppendLine(string.Join(",",
                                Escape(x.SKU), Escape(x.Name), Escape(x.Group), Escape(x.Supplier), Escape(x.Warehouse),
                                Escape(x.UomBase), Escape(x.UomAlt),
                                (x.ConversionRate ?? 0),
                                (x.PriceIn ?? 0),
                                (x.MinStock ?? 0),
                                (x.MaxStock ?? 0),
                                Escape(x.Batch),
                                x.MfgDate?.ToString("yyyy-MM-dd") ?? "",
                                x.ExpDate?.ToString("yyyy-MM-dd") ?? "",
                                (x.Fefo ?? false),
                                (x.LossPercent ?? 0),
                                Escape(x.Note)
                            ));
                        }
                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất CSV thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi xuất CSV: {ex.Message}");
                    }
                }
            }

            string Escape(string s)
            {
                if (string.IsNullOrEmpty(s)) return "";
                if (s.Contains(",") || s.Contains("\""))
                    return "\"" + s.Replace("\"", "\"\"") + "\"";
                return s;
            }
        }

        private async void btnRecieve_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedRow();
            if (selected == null) { MessageBox.Show("Chọn một dòng."); return; }

            // ví dụ: nhập thêm 50
            selected.MaxStock = (selected.MaxStock ?? 0) + 50;
            await _nguyenLieuDAL.UpdateNguyenLieuAsync(selected.Id, selected);
            await RefreshGridAsync();
            MessageBox.Show("Đã nhập kho +50.");
        }

        private async void btnIssue_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedRow();
            if (selected == null) { MessageBox.Show("Chọn một dòng."); return; }

            var current = (selected.MaxStock ?? 0);
            if (current <= 0) { MessageBox.Show("Không đủ hàng để xuất."); return; }

            selected.MaxStock = Math.Max(0, current - 20); // ví dụ: xuất 20
            await _nguyenLieuDAL.UpdateNguyenLieuAsync(selected.Id, selected);
            await RefreshGridAsync();
            MessageBox.Show("Đã xuất kho -20.");
        }

        private async void btnTransfer_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedRow();
            if (selected == null) { MessageBox.Show("Chọn một dòng."); return; }

            // ví dụ chuyển sang "Kho Lạnh"
            selected.Warehouse = "Kho Lạnh";
            await _nguyenLieuDAL.UpdateNguyenLieuAsync(selected.Id, selected);
            await RefreshGridAsync();
            MessageBox.Show("Đã chuyển kho.");
        }

        private void btnStockCount_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.DataBoundItem is NguyenLieu nl)
                    total += (nl.MaxStock ?? 0);
            }
            MessageBox.Show($"Tổng tồn kho: {total}");
        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            await RefreshGridAsync();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Ẩn form hiện tại
                this.Hide();

                // Mở lại form đăng nhập
                var loginForm = new Login();
                loginForm.Show();

                // Đóng form quản lý sau khi logout
                this.Close();
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn quay lại màn hình đăng nhập?",
                                "Xác nhận",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide(); // Ẩn form hiện tại
                var loginForm = new Login(); // Mở form đăng nhập giả
                loginForm.Show();
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
