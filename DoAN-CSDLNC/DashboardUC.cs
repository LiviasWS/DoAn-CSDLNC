using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using DoAN_CSDLNC.Data;
using DoAN_CSDLNC.Models;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAN_CSDLNC
{
    public partial class DashboardUC : UserControl
    {
        private readonly DBConnection db;
        private readonly IMongoCollection<Order> orderCollection;
        private readonly IMongoCollection<OrderItem> orderItemCollection;
        private readonly IMongoCollection<Product> productCollection;
        private readonly IMongoCollection<Employee> employeeCollection;
        private readonly IMongoCollection<Payment> paymentCollection;

        public DashboardUC()
        {
            InitializeComponent();
            db = new DBConnection();

            this.AutoScroll = true;

            orderCollection = db.GetCollection<Order>("Orders");
            orderItemCollection = db.GetCollection<OrderItem>("Order_Items");
            productCollection = db.GetCollection<Product>("Products");
            employeeCollection = db.GetCollection<Employee>("employees");
            paymentCollection = db.GetCollection<Payment>("Payments");

            cbRevenueFilter.Items.AddRange(new string[] { "Tuần", "Tháng", "Năm" });
            cbRevenueFilter.SelectedIndex = 0;

            LoadDashboard();

            var refreshTimer = new Timer();
            refreshTimer.Interval = 3000; // 3 giây
            refreshTimer.Tick += (s, e) => LoadDashboard();
            refreshTimer.Start();

            txtTotalToday.ReadOnly = true;
            txtTotalMonth.ReadOnly = true;
            txtAvgBill.ReadOnly = true;
            txtEmployeeCount.ReadOnly = true;
            txtProductCount.ReadOnly = true;
            txtStockCount.ReadOnly = true;
        }

        private void LoadDashboard()
        {
            LoadKPI();
            LoadRevenueChart();
            LoadTopProductsChart();
            LoadPaymentRatioChart();
            LoadTopTablesChart();
            LoadSlowProductsChart();
        }

        // === PHẦN 1: KPI ===
        private void LoadKPI()
        {
            var today = DateTime.Today;
            var monthStart = new DateTime(today.Year, today.Month, 1);

            var orders = orderCollection.Find(o => o.Status == "paid").ToList();

            // Tổng doanh thu hôm nay
            var totalToday = orders
                .Where(o => o.CreatedAt >= today && o.CreatedAt < today.AddDays(1))
                .Sum(o => (decimal?)o.TotalAmount) ?? 0;

            // Tổng doanh thu tháng
            var totalMonth = orders
                .Where(o => o.CreatedAt >= monthStart)
                .Sum(o => (decimal?)o.TotalAmount) ?? 0;

            // Trung bình hóa đơn
            var avgBill = orders.Count > 0 ? orders.Average(o => (double)o.TotalAmount) : 0;

            txtTotalToday.Text = totalToday.ToString("N0") + " đ";
            txtTotalMonth.Text = totalMonth.ToString("N0") + " đ";
            txtAvgBill.Text = avgBill.ToString("N0") + " đ";

            txtEmployeeCount.Text = employeeCollection.CountDocuments(FilterDefinition<Employee>.Empty).ToString();
            txtProductCount.Text = productCollection.CountDocuments(FilterDefinition<Product>.Empty).ToString();
            
            // === ĐẾM SỐ LƯỢNG MẶT HÀNG TRONG KHO ===
            try
            {
                var inventoryCollection = db.GetCollection<NguyenLieu>("Nguyenlieu");
                long inventoryCount = inventoryCollection.CountDocuments(FilterDefinition<NguyenLieu>.Empty);
                txtStockCount.Text = inventoryCount.ToString("N0");
            }
            catch (Exception ex)
            {
                txtStockCount.Text = "Lỗi kho!";
                MessageBox.Show("Không thể tải dữ liệu kho: " + ex.Message);
            }
        }

        // === PHẦN 2: BIỂU ĐỒ DOANH THU ===
        private void LoadRevenueChart()
        {
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas[0].AxisX.Title = "Thời gian";
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu";

            var orders = orderCollection.Find(o => o.Status == "completed").ToList();
            var series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            string filter = cbRevenueFilter.SelectedItem.ToString();

            if (filter == "Tuần")
            {
                // Tính ngày bắt đầu tuần (Thứ Hai)
                int daysFromMonday = ((int)DateTime.Today.DayOfWeek + 6) % 7;
                var startOfWeek = DateTime.Today.AddDays(-daysFromMonday);
                var endOfWeek = startOfWeek.AddDays(7);

                // Gom nhóm đơn hàng theo ngày trong tuần
                var data = orders
                    .Where(o => o.CreatedAt >= startOfWeek && o.CreatedAt < endOfWeek)
                    .GroupBy(o => o.CreatedAt.Date)
                    .ToDictionary(g => g.Key, g => g.Sum(x => x.TotalAmount));

                // Mảng tên thứ tiếng Việt (thứ 2 → CN)
                string[] weekdays = { "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "CN" };

                // Duyệt 7 ngày trong tuần
                for (int i = 0; i < 7; i++)
                {
                    DateTime day = startOfWeek.AddDays(i);
                    decimal total = data.ContainsKey(day) ? data[day] : 0;

                    // Hiển thị dạng: "Thứ 2 (06/10)"
                    string label = $"{weekdays[i]} ({day:dd/MM})";

                    series.Points.AddXY(label, total);
                }
            }

            else if (filter == "Tháng")
            {
                // Lấy ngày đầu tháng hiện tại
                var startOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                var endOfMonth = startOfMonth.AddMonths(1);

                // Gom nhóm theo ngày
                var dailyData = orders
                    .Where(o => o.CreatedAt >= startOfMonth && o.CreatedAt < endOfMonth)
                    .GroupBy(o => o.CreatedAt.Date)
                    .ToDictionary(g => g.Key, g => g.Sum(x => x.TotalAmount));

                // Chia tháng thành 4 tuần
                decimal[] weeklyTotals = new decimal[4];
                for (int i = 0; i < 4; i++)
                {
                    DateTime weekStart = startOfMonth.AddDays(i * 7);
                    DateTime weekEnd = weekStart.AddDays(7);

                    weeklyTotals[i] = dailyData
                        .Where(d => d.Key >= weekStart && d.Key < weekEnd)
                        .Sum(d => d.Value);
                }

                for (int i = 0; i < 4; i++)
                {
                    series.Points.AddXY("Tuần " + (i + 1), weeklyTotals[i]);
                }
            }
            else // Năm
            {
                var startOfYear = new DateTime(DateTime.Today.Year, 1, 1);
                var endOfYear = startOfYear.AddYears(1);

                var data = orders
                    .Where(o => o.CreatedAt >= startOfYear && o.CreatedAt < endOfYear)
                    .GroupBy(o => o.CreatedAt.Month)
                    .Select(g => new { Month = g.Key, Total = g.Sum(x => x.TotalAmount) })
                    .OrderBy(x => x.Month);

                for (int month = 1; month <= 12; month++)
                {
                    var match = data.FirstOrDefault(x => x.Month == month);
                    decimal total = match != null ? match.Total : 0;
                    series.Points.AddXY("T" + month, total);
                }
            }

            chartRevenue.Series.Add(series);
        }


        // === PHẦN 3: TOP 3 SẢN PHẨM ===
        private void LoadTopProductsChart()
        {
            chartTopProducts.Series.Clear();

            var items = orderItemCollection.AsQueryable()
                .GroupBy(i => i.ProductId)
                .Select(g => new { ProductId = g.Key, Total = g.Sum(x => x.Quantity) })
                .OrderByDescending(x => x.Total)
                .Take(3)
                .ToList();

            var products = productCollection.AsQueryable().ToList();

            var series = new Series("Top sản phẩm");
            series.ChartType = SeriesChartType.Column;

            foreach (var item in items)
            {
                var name = products.FirstOrDefault(p => p.Id == item.ProductId)?.Name ?? "Unknown";
                series.Points.AddXY(name, item.Total);
            }

            chartTopProducts.Series.Add(series);
        }

        // === PHẦN 4: TỈ LỆ THANH TOÁN ===
        private void LoadPaymentRatioChart()
        {
            chartPayment.Series.Clear();

            var data = paymentCollection.AsQueryable()
                .GroupBy(p => p.Method)
                .Select(g => new { Method = g.Key, Count = g.Count() })
                .ToList();

            var series = new Series("Tỉ lệ thanh toán");
            series.ChartType = SeriesChartType.Pie;

            foreach (var d in data)
                series.Points.AddXY(d.Method, d.Count);

            chartPayment.Series.Add(series);
        }

        // Biểu đồ bàn được chọn
        private void LoadTopTablesChart()
        {
            chartTopTables.Series.Clear();

            // Gom nhóm theo TableId
            var data = orderCollection.AsQueryable()
                .Where(o => o.Status == "paid" && o.TableId != null)
                .GroupBy(o => o.TableId)
                .Select(g => new { TableId = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .Take(5)
                .ToList();

            var series = new Series("Top bàn được chọn");
            series.ChartType = SeriesChartType.Column;

            foreach (var t in data)
            {
                series.Points.AddXY("Bàn " + t.TableId, t.Count);
            }

            chartTopTables.Series.Add(series);
        }

        private void LoadSlowProductsChart()
        {
            chartSlowProducts.Series.Clear();

            // Gom nhóm theo ProductId, lấy sản phẩm có tổng số lượng bán ít nhất
            var items = orderItemCollection.AsQueryable()
                .GroupBy(i => i.ProductId)
                .Select(g => new { ProductId = g.Key, Total = g.Sum(x => x.Quantity) })
                .OrderBy(x => x.Total) // tăng dần
                .Take(3)
                .ToList();

            var products = productCollection.AsQueryable().ToList();

            var series = new Series("Sản phẩm bán chậm");
            series.ChartType = SeriesChartType.Column;

            foreach (var item in items)
            {
                var name = products.FirstOrDefault(p => p.Id == item.ProductId)?.Name ?? "Unknown";
                series.Points.AddXY(name, item.Total);
            }

            chartSlowProducts.Series.Add(series);
        }


        private void cbRevenueFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRevenueChart();
        }
    }
}
