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
    }
}
