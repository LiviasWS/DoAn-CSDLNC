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
    public partial class UCTableReserveDashBoard : UserControl
    {
        private DBConnection connection = new DBConnection();
        private IMongoCollection<Table> Tables;
        private IMongoCollection<TableReserve> TableReserves;
        private IMongoCollection<Customer> Customers;
        private DateTime start;
        private DateTime end;
        public UCTableReserveDashBoard()
        {
            Customers = connection.GetCollection<Customer>("Customers");
            Tables = connection.GetCollection<Table>("Tables");
            TableReserves = connection.GetCollection<TableReserve>("Table_Reserves");
            InitializeComponent();
        }

        private void UCTableReserveDashBoardcs_Load(object sender, EventArgs e)
        {
            UIConfig();
            timeConfig();
        }

        private void UIConfig()
        {
            DateTime now = DateTime.Now;
            dtpDate.Value = now;
            cbbHour.SelectedItem = now.Hour.ToString();
            cbbMinutes.SelectedItem = now.Minute.ToString();
            txtDuration.Text = 0.ToString();
            List<Customer> customers = Customers.Find(Builders<Customer>.Filter.Empty).ToList();
            cbbCustomer.Items.Clear();
            foreach (Customer customer in customers)
            {
                cbbCustomer.Items.Add(customer.Name);
            }
        }

        private void timeConfig()
        {
            start = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, int.Parse(cbbHour.SelectedItem.ToString()), int.Parse(cbbMinutes.SelectedItem.ToString()), 59);
            end = start.AddMinutes(int.Parse(txtDuration.Text));
            if(start.AddSeconds(60) > DateTime.Now)
            {
                Reload();
            }
            else
            {
                MessageBox.Show("Time must be later than now");
            }
        }

        private void Reload()
        {
            flpTableList.Controls.Clear();
            List<Table> tables = Tables.Find(Builders<Table>.Filter.Empty).ToList();
            Customer customer = Customers.Find(Builders<Customer>.Filter.Eq( o => o.Name, cbbCustomer.Text )).FirstOrDefault();
            TableReserve newReserve = new TableReserve()
            {
                Customer = customer,
                Start = start,
                End = start.AddMinutes(int.Parse(txtDuration.Text)),
                Status = "incomplete",
                DateCreate = DateTime.Now
            };
            foreach (Table table in tables)
            {
                var filter = Builders<TableReserve>.Filter.And
                    (
                        Builders<TableReserve>.Filter.Eq( o => o.Table.Id, table.Id ),
                        Builders<TableReserve>.Filter.Eq( o => o.Status, "incomplete" )
                    );
                List<TableReserve> tableReserves = TableReserves.Find(filter).ToList();
                foreach(TableReserve item in tableReserves)
                {
                    item.Start = item.Start;
                    item.End = item.End;
                }
                TableReserve tableReserve = tableReserves.FirstOrDefault( o => o.Start <= start && start <= o.End );
                UCTableReserve uCTableReserve = new UCTableReserve(table, tableReserve, newReserve);
                flpTableList.Controls.Add( uCTableReserve );
            }
        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbbMinutes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbbHour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pFunction_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void txtDuration_TextChanged_1(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtDuration.Text, out var duration))
                timeConfig();
            else
                MessageBox.Show("Duration must be number");
        }
    }
}
