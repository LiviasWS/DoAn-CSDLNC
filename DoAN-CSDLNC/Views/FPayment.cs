using DoAN_CSDLNC.Data;
using DoAN_CSDLNC.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAN_CSDLNC.Views
{
    public partial class FPayment : Form
    {
        private DBConnection connection = new DBConnection();
        private IMongoCollection<Employee> Employees;
        private IMongoCollection<Customer> Customers;
        private IMongoCollection<Payment> Payments;
        private IMongoCollection<Table> Tables;
        private IMongoCollection<Order> Orders;
        private List<Employee> employees;
        private List<Customer> customers;
        private Table table;
        private int totalCost;
        public FPayment(Table table, int totalCost)
        {
            this.table = table;
            Employees = connection.GetCollection<Employee>("Employees");
            Customers = connection.GetCollection<Customer>("Customers");
            Payments = connection.GetCollection<Payment>("Payments");
            Tables = connection.GetCollection<Table>("Tables");
            Orders = connection.GetCollection<Order>("Orders");
            InitializeComponent();
            this.totalCost = totalCost;
        }

        private void FPayment_Load(object sender, EventArgs e)
        {
            employees = Employees.Find(Builders<Employee>.Filter.Empty).ToList();
            customers = Customers.Find(Builders<Customer>.Filter.Empty).ToList();
            cbbCustomer.Items.Add("None");
            cbbCustomer.SelectedIndex = 0;
            cbbMethod.SelectedIndex = 0;
            foreach(Employee employee in employees)
            {
                cbbEmployee.Items.Add(employee.Name);
            }
            foreach(Customer customer in customers)
            {
                cbbCustomer.Items.Add(customer.Name);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string customer_id = null;
            if(cbbEmployee.Text == null)
            {
                MessageBox.Show("Please choose Employee");
                return;
            }
            if(cbbCustomer.Text != "None")
            {
                Customer customer = Customers.Aggregate().Match(o => o.Name == cbbCustomer.Text).FirstOrDefault();
            }
            Employee employee = Employees.Aggregate().Match(o => o.Name == cbbEmployee.Text).FirstOrDefault();
            Payment payment = new Payment() 
            {
                CustomerId = customer_id,
                EmployeeId = employee.Id,
                Method = cbbMethod.Text,
                TotalCost = totalCost,
                DateCreate = DateTime.Now
            };
            Payments.InsertOne(payment);
            updateTableStatus("Free");
            updateOrderStatus("completed");
            this.Close();
        }

        private void updateTableStatus(string status)
        {
            var filter = Builders<Table>.Filter.Eq(o => o.Id, table.Id);
            var update = Builders<Table>.Update.Set(o => o.Status, status);
            Tables.UpdateOne(filter, update);
        }

        private void updateOrderStatus(string status)
        {
            var filter = Builders<Order>.Filter.Eq(o => o.TableId, table.Id);
            var update = Builders<Order>.Update.Set(o => o.Status, status);
            Orders.UpdateMany(filter, update);
        }

    }
}
