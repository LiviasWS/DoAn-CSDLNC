using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using DoAN_CSDLNC.Models;
using DoAN_CSDLNC.Data;

namespace DoAN_CSDLNC
{
    public partial class OrderUC : UserControl
    {
        public OrderUC()
        {
            InitializeComponent();
        }

        private void LoadOrdersWithPayment(object sender, EventArgs e)
        {
            try
            {
                var db = new DBConnection();
                var orderCollection = db.GetCollection<Order>("orders");
                var paymentCollection = db.GetCollection<Payment>("payments");

                // Lấy các đơn đã thanh toán
                var orders = orderCollection.Find(o => o.Status == "paid").ToList();

                // Lấy tất cả payment
                var payments = paymentCollection.Find(_ => true).ToList();

                // Ghép Payment Method
                foreach (var order in orders)
                {
                    var payment = payments.FirstOrDefault(p => p.CustomerId == order.CustomerId
                                                             && p.DateCreate.Date == order.CreatedAt.Date);
                    order.PaymentMethod = payment?.Method ?? "Unknown";
                }

                // Chuyển dữ liệu sang DataTable
                var dt = new System.Data.DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Table ID");
                dt.Columns.Add("Customer ID");
                dt.Columns.Add("Employee ID");
                dt.Columns.Add("Status");
                dt.Columns.Add("Total Amount");
                dt.Columns.Add("Created At");
                dt.Columns.Add("Payment Method"); // cột mới

                foreach (var order in orders)
                {
                    dt.Rows.Add(order.Id, order.TableId, order.CustomerId, order.EmployeeId,
                                order.Status, order.TotalAmount, order.CreatedAt, order.PaymentMethod);
                }

                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }
    }
}
