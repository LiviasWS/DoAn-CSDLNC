namespace DoAN_CSDLNC
{
    partial class DashboardUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chartPayment = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtTotalToday = new System.Windows.Forms.TextBox();
            this.txtAvgBill = new System.Windows.Forms.TextBox();
            this.txtEmployeeCount = new System.Windows.Forms.TextBox();
            this.txtTotalMonth = new System.Windows.Forms.TextBox();
            this.txtStockCount = new System.Windows.Forms.TextBox();
            this.txtProductCount = new System.Windows.Forms.TextBox();
            this.cbRevenueFilter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chartTopTables = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.chartSlowProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSlowProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "DASHBOARD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tổng doanh thu hôm nay:";
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(17, 265);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(841, 300);
            this.chartRevenue.TabIndex = 22;
            this.chartRevenue.Text = "chart1";
            // 
            // chartTopProducts
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend2);
            this.chartTopProducts.Location = new System.Drawing.Point(17, 652);
            this.chartTopProducts.Name = "chartTopProducts";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTopProducts.Series.Add(series2);
            this.chartTopProducts.Size = new System.Drawing.Size(841, 300);
            this.chartTopProducts.TabIndex = 23;
            this.chartTopProducts.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tổng doanh thu tháng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Trung bình hóa đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tổng số lượng mặt hàng trong kho:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tổng số lượng sản phẩm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tổng số lượng nhân viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "BIỂU ĐỒ DOANH THU THEO THỜI GIAN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 996);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "BIỂU ĐỒ TỈ LỆ PHƯƠNG THỨC THANH TOÁN";
            // 
            // chartPayment
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPayment.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPayment.Legends.Add(legend3);
            this.chartPayment.Location = new System.Drawing.Point(17, 1034);
            this.chartPayment.Name = "chartPayment";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartPayment.Series.Add(series3);
            this.chartPayment.Size = new System.Drawing.Size(841, 300);
            this.chartPayment.TabIndex = 30;
            this.chartPayment.Text = "chart3";
            // 
            // txtTotalToday
            // 
            this.txtTotalToday.Location = new System.Drawing.Point(191, 55);
            this.txtTotalToday.Name = "txtTotalToday";
            this.txtTotalToday.Size = new System.Drawing.Size(165, 22);
            this.txtTotalToday.TabIndex = 32;
            // 
            // txtAvgBill
            // 
            this.txtAvgBill.Location = new System.Drawing.Point(191, 154);
            this.txtAvgBill.Name = "txtAvgBill";
            this.txtAvgBill.Size = new System.Drawing.Size(165, 22);
            this.txtAvgBill.TabIndex = 33;
            // 
            // txtEmployeeCount
            // 
            this.txtEmployeeCount.Location = new System.Drawing.Point(669, 55);
            this.txtEmployeeCount.Name = "txtEmployeeCount";
            this.txtEmployeeCount.Size = new System.Drawing.Size(165, 22);
            this.txtEmployeeCount.TabIndex = 34;
            // 
            // txtTotalMonth
            // 
            this.txtTotalMonth.Location = new System.Drawing.Point(191, 106);
            this.txtTotalMonth.Name = "txtTotalMonth";
            this.txtTotalMonth.Size = new System.Drawing.Size(165, 22);
            this.txtTotalMonth.TabIndex = 35;
            // 
            // txtStockCount
            // 
            this.txtStockCount.Location = new System.Drawing.Point(669, 154);
            this.txtStockCount.Name = "txtStockCount";
            this.txtStockCount.Size = new System.Drawing.Size(165, 22);
            this.txtStockCount.TabIndex = 36;
            // 
            // txtProductCount
            // 
            this.txtProductCount.Location = new System.Drawing.Point(669, 106);
            this.txtProductCount.Name = "txtProductCount";
            this.txtProductCount.Size = new System.Drawing.Size(165, 22);
            this.txtProductCount.TabIndex = 37;
            // 
            // cbRevenueFilter
            // 
            this.cbRevenueFilter.FormattingEnabled = true;
            this.cbRevenueFilter.Location = new System.Drawing.Point(291, 226);
            this.cbRevenueFilter.Name = "cbRevenueFilter";
            this.cbRevenueFilter.Size = new System.Drawing.Size(121, 24);
            this.cbRevenueFilter.TabIndex = 38;
            this.cbRevenueFilter.SelectedIndexChanged += new System.EventHandler(this.cbRevenueFilter_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 616);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "BIỂU ĐỒ TOP SẢN PHẨM BÁN CHẠY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 1378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "BIỂU ĐỒ TOP BÀN CHỌN NHIỀU NHẤT";
            // 
            // chartTopTables
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTopTables.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTopTables.Legends.Add(legend4);
            this.chartTopTables.Location = new System.Drawing.Point(23, 1416);
            this.chartTopTables.Name = "chartTopTables";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTopTables.Series.Add(series4);
            this.chartTopTables.Size = new System.Drawing.Size(841, 300);
            this.chartTopTables.TabIndex = 40;
            this.chartTopTables.Text = "chart3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 1759);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 43;
            // 
            // chartSlowProducts
            // 
            chartArea5.Name = "ChartArea1";
            this.chartSlowProducts.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartSlowProducts.Legends.Add(legend5);
            this.chartSlowProducts.Location = new System.Drawing.Point(29, 1796);
            this.chartSlowProducts.Name = "chartSlowProducts";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartSlowProducts.Series.Add(series5);
            this.chartSlowProducts.Size = new System.Drawing.Size(841, 300);
            this.chartSlowProducts.TabIndex = 42;
            this.chartSlowProducts.Text = "chart3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 1759);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(237, 16);
            this.label13.TabIndex = 44;
            this.label13.Text = "BIỂU ĐỒ TOP SẢN PHẨM BÁN CHẬM";
            // 
            // DashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chartSlowProducts);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chartTopTables);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbRevenueFilter);
            this.Controls.Add(this.txtProductCount);
            this.Controls.Add(this.txtStockCount);
            this.Controls.Add(this.txtTotalMonth);
            this.Controls.Add(this.txtEmployeeCount);
            this.Controls.Add(this.txtAvgBill);
            this.Controls.Add(this.txtTotalToday);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chartPayment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartTopProducts);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "DashboardUC";
            this.Size = new System.Drawing.Size(879, 2109);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSlowProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPayment;
        private System.Windows.Forms.TextBox txtTotalToday;
        private System.Windows.Forms.TextBox txtAvgBill;
        private System.Windows.Forms.TextBox txtEmployeeCount;
        private System.Windows.Forms.TextBox txtTotalMonth;
        private System.Windows.Forms.TextBox txtStockCount;
        private System.Windows.Forms.TextBox txtProductCount;
        private System.Windows.Forms.ComboBox cbRevenueFilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopTables;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSlowProducts;
        private System.Windows.Forms.Label label13;
    }
}
