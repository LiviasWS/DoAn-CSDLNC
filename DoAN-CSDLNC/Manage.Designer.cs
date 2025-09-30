namespace DoAN_CSDLNC
{
    partial class Manage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button15;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.Supplier = new System.Windows.Forms.Button();
            this.InventoryRecord = new System.Windows.Forms.Button();
            this.Inventory = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            button15 = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button15
            // 
            button15.BackColor = System.Drawing.Color.Red;
            button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            button15.ForeColor = System.Drawing.Color.White;
            button15.Location = new System.Drawing.Point(881, 12);
            button15.Name = "button15";
            button15.Size = new System.Drawing.Size(92, 41);
            button15.TabIndex = 2;
            button15.Text = "Logout";
            button15.UseVisualStyleBackColor = false;
            button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.Supplier);
            this.panelSidebar.Controls.Add(this.InventoryRecord);
            this.panelSidebar.Controls.Add(this.Inventory);
            this.panelSidebar.Controls.Add(this.Order);
            this.panelSidebar.Controls.Add(this.Product);
            this.panelSidebar.Controls.Add(this.User);
            this.panelSidebar.Controls.Add(this.Employee);
            this.panelSidebar.Controls.Add(this.Dashboard);
            this.panelSidebar.Location = new System.Drawing.Point(1, 85);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(144, 388);
            this.panelSidebar.TabIndex = 0;
            // 
            // Supplier
            // 
            this.Supplier.BackColor = System.Drawing.Color.SandyBrown;
            this.Supplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Supplier.Location = new System.Drawing.Point(0, 336);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(144, 52);
            this.Supplier.TabIndex = 8;
            this.Supplier.Text = "Nhà cung cấp";
            this.Supplier.UseVisualStyleBackColor = false;
            this.Supplier.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // InventoryRecord
            // 
            this.InventoryRecord.BackColor = System.Drawing.Color.SandyBrown;
            this.InventoryRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.InventoryRecord.Location = new System.Drawing.Point(0, 288);
            this.InventoryRecord.Name = "InventoryRecord";
            this.InventoryRecord.Size = new System.Drawing.Size(144, 48);
            this.InventoryRecord.TabIndex = 7;
            this.InventoryRecord.Text = "Đơn nhập/xuất";
            this.InventoryRecord.UseVisualStyleBackColor = false;
            this.InventoryRecord.Click += new System.EventHandler(this.InventoryRecord_Click);
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.SandyBrown;
            this.Inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Inventory.Location = new System.Drawing.Point(0, 240);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(144, 48);
            this.Inventory.TabIndex = 6;
            this.Inventory.Text = "Kho";
            this.Inventory.UseVisualStyleBackColor = false;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.SandyBrown;
            this.Order.Dock = System.Windows.Forms.DockStyle.Top;
            this.Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Order.Location = new System.Drawing.Point(0, 192);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(144, 48);
            this.Order.TabIndex = 5;
            this.Order.Text = "Đơn hàng";
            this.Order.UseVisualStyleBackColor = false;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // Product
            // 
            this.Product.BackColor = System.Drawing.Color.SandyBrown;
            this.Product.Dock = System.Windows.Forms.DockStyle.Top;
            this.Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Product.Location = new System.Drawing.Point(0, 144);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(144, 48);
            this.Product.TabIndex = 4;
            this.Product.Text = "Sản phẩm";
            this.Product.UseVisualStyleBackColor = false;
            this.Product.Click += new System.EventHandler(this.button10_Click);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.SandyBrown;
            this.User.Dock = System.Windows.Forms.DockStyle.Top;
            this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.User.Location = new System.Drawing.Point(0, 96);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(144, 48);
            this.User.TabIndex = 3;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = false;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Employee
            // 
            this.Employee.BackColor = System.Drawing.Color.SandyBrown;
            this.Employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Employee.Location = new System.Drawing.Point(0, 48);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(144, 48);
            this.Employee.TabIndex = 2;
            this.Employee.Text = "Nhân viên";
            this.Employee.UseVisualStyleBackColor = false;
            this.Employee.Click += new System.EventHandler(this.button8_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.SandyBrown;
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(144, 48);
            this.Dashboard.TabIndex = 1;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.button7_Click);
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.SandyBrown;
            this.panelContent.Location = new System.Drawing.Point(151, 59);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(822, 421);
            this.panelContent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "TRANG QUẢN LÝ";
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(1, 59);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(33, 26);
            this.btnToggle.TabIndex = 4;
            this.btnToggle.Text = "<";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // Manage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(977, 507);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.label1);
            this.Controls.Add(button15);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Manage";
            this.Text = "Management Page";
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button Supplier;
        private System.Windows.Forms.Button InventoryRecord;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button Product;
        private System.Windows.Forms.Button User;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToggle;
    }
}