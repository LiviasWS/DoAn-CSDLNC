using System;
using System.Drawing;
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

        private void Dashboard_Click(object sender, EventArgs e)
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
            //panelContent.AutoScrollMinSize = uc.Size;

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

        // Đổi mật khẩu
        private void ChangePass_Click(object sender, EventArgs e)
        {
            LoadControl(new ChangePassUC());
        }

        // Đăng xuất
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?",
                                                  "Đăng xuất",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Ẩn form Manage
                this.Hide();

                // Mở form Login
                Login loginForm = new Login();
                loginForm.Show();

                // Khi Login đóng thì thoát hẳn ứng dụng
                loginForm.FormClosed += (s, args) => Application.Exit();
            }
        }

        private bool isCollapsed = false;

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                // Mở sidebar
                panelSidebar.Width = 150; // chiều rộng gốc
                foreach (Control ctrl in panelSidebar.Controls)
                {
                    if (ctrl is Button btn && btn != btnToggle)
                        btn.Text = btn.Tag?.ToString(); // khôi phục text
                }
                isCollapsed = false;
            }
            else
            {
                // Thu gọn sidebar
                panelSidebar.Width = 0; // thu hẳn
                foreach (Control ctrl in panelSidebar.Controls)
                {
                    if (ctrl is Button btn && btn != btnToggle)
                    {
                        btn.Tag = btn.Text; // lưu lại text gốc
                        btn.Text = "";      // ẩn text
                    }
                }
                isCollapsed = true;
            }
            // panelContent.Dock = DockStyle.Fill đảm bảo nó tự giãn
        }

    }
}
