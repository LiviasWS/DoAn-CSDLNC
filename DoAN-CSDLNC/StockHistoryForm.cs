using DoAN_CSDLNC.DAL;
using DoAN_CSDLNC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class StockHistoryForm : Form
    {
        // ✅ Giữ lại đúng 1 dòng này
        private readonly StockHistoryDAL _dal = new StockHistoryDAL();

        public StockHistoryForm()
        {
            InitializeComponent();
        }

        private void StockHistoryForm_Load(object sender, EventArgs e)
        {
            cboAction.Items.Clear();
            cboAction.Items.AddRange(new object[] { "", "ADD", "UPDATE", "DELETE", "IN", "OUT", "TRANSFER", "COUNT", "ADJUST" });
            cboAction.SelectedIndex = 0;

            dtFrom.Checked = false;
            dtTo.Checked = false;

            LoadGrid(_dal.GetAll(500));
        }

        private void LoadGrid(List<StockHistory> list)
        {
            var view = list.Select(x => new
            {
                x.SKU,
                x.Name,
                x.Action,
                Qty = x.Qty,
                Before = x.BeforeQty,
                After = x.AfterQty,
                Warehouse = x.Warehouse,
                User = x.Username,
                x.Note,
                CreatedAt = x.CreatedAt.ToLocalTime()
            }).ToList();

            dgvHistory.DataSource = view;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string sku = txtSku.Text?.Trim();
            string user = txtUser.Text?.Trim();
            string action = cboAction.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(action)) action = null;

            DateTime? fromUtc = null, toUtc = null;

            if (dtFrom.Checked)
                fromUtc = DateTime.SpecifyKind(dtFrom.Value.Date, DateTimeKind.Local).ToUniversalTime();

            if (dtTo.Checked)
            {
                var endLocal = dtTo.Value.Date.AddDays(1).AddTicks(-1);
                toUtc = DateTime.SpecifyKind(endLocal, DateTimeKind.Local).ToUniversalTime();
            }

            var result = _dal.Filter(sku, user, action, fromUtc, toUtc);
            LoadGrid(result);
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
