using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
            //LoadDashboard();
        }

        private void HighlightButton(Button activeButton)
        {
            // Reset lại màu của tất cả button trong sidebar
            foreach (Control ctrl in panelSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.LightGray; // màu mặc định
                    btn.ForeColor = Color.Black;
                }
            }

            // Set màu nổi bật cho button đang chọn
            activeButton.BackColor = Color.DodgerBlue;
            activeButton.ForeColor = Color.White;
        }

        private void LoadDashboard(object sender)
        {
            panelContent.Controls.Clear();

            DashboardUC uc = new DashboardUC();
            uc.Dock = DockStyle.None;
            uc.Location = new Point(0, 0);
            uc.Size = new Size(800, 1200); // cao hơn panel để test scroll

            panelContent.AutoScroll = true;
            panelContent.AutoScrollMinSize = uc.Size;

            panelContent.Controls.Add(uc);
            HighlightButton((Button)sender);
        }

        private void LoadControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadControl(new ProductUC());
            //HighlightButton((Button)sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Xóa control cũ trong panel (nếu có)
            panelContent.Controls.Clear();

            // Tạo UserControl mới
            DashboardUC uc = new DashboardUC();

            // Không dock Fill (nếu muốn cuộn), để kích thước lớn hơn panel
            uc.Dock = DockStyle.None;
            uc.Location = new Point(0, 0);
            uc.Size = new Size(800, 1200); // thử đặt cao hơn panel

            // Bật AutoScroll cho panel
            panelContent.AutoScroll = true;
            panelContent.AutoScrollMinSize = uc.Size;

            // Thêm UserControl vào panel
            panelContent.Controls.Add(uc);

            //HighlightButton((Button)sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadControl(new EmployeeUC());
            //HighlightButton((Button)sender);
        }

        private void User_Click(object sender, EventArgs e)
        {
            LoadControl(new UserUC());
            //HighlightButton((Button)sender);
        }

        private void Order_Click(object sender, EventArgs e)
        {
            LoadControl(new OrderUC());
            //HighlightButton((Button)sender);
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            LoadControl(new InventoryUC());
            //HighlightButton((Button)sender);
        }

        private void InventoryRecord_Click(object sender, EventArgs e)
        {
            LoadControl(new InventoryRecorddUC());
            //HighlightButton((Button)sender);
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            LoadControl(new SupplierUC());
            //HighlightButton((Button)sender);
        }
    }
}
