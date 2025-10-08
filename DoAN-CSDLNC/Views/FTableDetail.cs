using DoAN_CSDLNC.Data;
using DoAN_CSDLNC.Models;
using DoAN_CSDLNC.Views;
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

namespace DoAN_CSDLNC
{
    public partial class FTableDetail : Form
    {
        private DBConnection connection = new DBConnection();
        private IMongoCollection<Table> Tables;
        private IMongoCollection<Order> Orders;
        private IMongoCollection<OrderItem> OrderItems;
        private Table table;
        private TableReserve tableReserve;
        private UIHelper helper = new UIHelper();
        private int totalCost;
        public FTableDetail(Table table, TableReserve tableReserve)
        {
            this.table = table;
            this.tableReserve = tableReserve;
            Tables = connection.GetCollection<Table>("Tables");
            Orders = connection.GetCollection<Order>("Orders");
            OrderItems = connection.GetCollection<OrderItem>("Order_Items");
            InitializeComponent();
        }

        private void FTableDetail_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            flpOrderList.Controls.Clear();
            lName.Text = "Table " + table.TableNumber;
            switch (table.Status)
            {
                case "Free":
                    OccupiedTableLoad();
                    break;
                case "Occupied":
                    OccupiedTableLoad();
                    break;
                case "Reserved":

                    break;
            }
            layOutConfig();
        }

        private void OccupiedTableLoad()
        {
            var orderFilter = Builders<Order>.Filter.And
                (
                    Builders<Order>.Filter.Eq( o => o.TableId, table.Id ),
                    Builders<Order>.Filter.Eq( o => o.Status, "in_progress")
                );
            Order order = Orders.Find(orderFilter).FirstOrDefault();
            if(order != null)
            {
                List<OrderItem> orderItems = OrderItems.Aggregate().Match(o => o.OrderId == order.Id).ToList();
                totalCost = 0;
                foreach (OrderItem item in orderItems)
                {
                    UCOrderItem uCMain = new UCOrderItem(item.ProductId, item.Size, item.Quantity);
                    totalCost += uCMain.GetTotalPrice();
                    flpOrderList.Controls.Add(uCMain);
                    foreach (Topping topping in item.Toppings)
                    {
                        UCOrderItem ucTopping = new UCOrderItem(topping.Product.Id, "S", topping.Quantity);
                        totalCost += ucTopping.GetTotalPrice();
                        flpOrderList.Controls.Add(ucTopping);
                    }
                    UCOrderItemDescription ucDes = new UCOrderItemDescription(item.Description);
                    flpOrderList.Controls.Add(ucDes);
                }
            }    
            
        }

        private void layOutConfig()
        {
            helper.MakeRoundedPanel(pFunction, 30);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            FPayment fPayment = new FPayment(table, totalCost);
            fPayment.ShowDialog();
            this.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FProductList fProduct = new FProductList(table);
            fProduct.ShowDialog();
            Reload();
        }
    }
}
