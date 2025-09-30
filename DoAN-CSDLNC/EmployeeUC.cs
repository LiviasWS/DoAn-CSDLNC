using DoAN_CSDLNC.Data;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class EmployeeUC : UserControl
    {
        private readonly DBConnection _db;

        public EmployeeUC()
        {
            InitializeComponent();
            _db = new DBConnection();

            LoadEmployees();
        }

        // Load dữ liệu nhân viên từ MongoDB
        private void LoadEmployees()
        {
            try
            {
                // Lấy collection employees
                var employeesCollection = _db.GetCollection<Employee>("employees");

                // Lấy tất cả nhân viên
                List<Employee> employees = employeesCollection.Find(_ => true).ToList();

                // Đổ dữ liệu vào DataGridView
                dataGridView1.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu nhân viên: " + ex.Message);
            }
        }

        // Thêm nhân viên
        private void button1_Click(object sender, EventArgs e)
        {
            // Mở form UpdateEmployee để thêm mới
            var form = new AddEmployee(); // form trống
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees(); // reload lại bảng
            }
        }

        // Sửa nhân viên
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!");
                return;
            }

            // Lấy nhân viên đang chọn
            var selectedEmployee = (Employee)dataGridView1.CurrentRow.DataBoundItem;

            // Mở form UpdateEmployee với dữ liệu có sẵn
            var form = new UpdateEmployee(selectedEmployee);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees(); // reload sau khi update
            }
        }

        // Xóa nhân viên
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
                return;
            }

            var selectedEmployee = (Employee)dataGridView1.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa nhân viên: {selectedEmployee.Name}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var employeesCollection = _db.GetCollection<Employee>("employees");
                    employeesCollection.DeleteOne(emp => emp.Id == selectedEmployee.Id);
                    MessageBox.Show("Đã xóa nhân viên!");
                    LoadEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

    }
}
