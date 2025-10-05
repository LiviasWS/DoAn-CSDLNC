using DoAN_CSDLNC.Data;
using DoAN_CSDLNC.Models;
using DoAN_CSDLNC.Views;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class FTableDetail : Form
    {
        private UIHelper helper = new UIHelper();
        private DBConnection connection = new DBConnection();
        private IMongoCollection<Order> Orders;
        private IMongoCollection<OrderItem> OrderItems;
        private Table table;
        private int totalPrice = 0;
        public FTableDetail(Table table)
        {
            this.table = table;
            Orders = connection.GetCollection<Order>("Orders");
            OrderItems = connection.GetCollection<OrderItem>("Order_Items");
            InitializeComponent();
        }

        private void FTableDetail_Load(object sender, EventArgs e)
        {
            lName.Text = "Table " + table.TableNumber.ToString();
            switch(table.Status)
            {
                case "Free":
                    ShowFreeMessage();
                    break;
                case "Occupied":
                    TableLoad();
                    break;
                case "Reserved":
                    break;
            }
            layOutConfig();
        }

        private void TableLoad()
        {
            flpOrderList.Controls.Clear();
            var orderFilter = Builders<Order>.Filter.And
                (
                    Builders<Order>.Filter.Eq(o => o.TableId, table.Id),
                    Builders<Order>.Filter.Eq(o => o.Status, "in_progress")
                );
            Order order = Orders.Find(orderFilter).FirstOrDefault();
            var filter = Builders<OrderItem>.Filter.Eq( o => o.OrderId, order.Id );
            List<OrderItem> orderItems = OrderItems.Find(filter).ToList();
            foreach( OrderItem item in orderItems )
            {
                UCOrderItem ucMainOrderItem = new UCOrderItem(item.ProductId, item.Size, item.Quantity);
                flpOrderList.Controls.Add(ucMainOrderItem);
                totalPrice += ucMainOrderItem.GetTotalPrice();
                foreach(Topping topping in item.Toppings)
                {
                    UCOrderItem ucToppingOrderItem = new UCOrderItem(topping.Product.Id, null, topping.Quantity);
                    flpOrderList.Controls.Add(ucToppingOrderItem);
                    totalPrice += ucToppingOrderItem.GetTotalPrice();
                }
                UCOrderItemDescription ucDes = new UCOrderItemDescription(item.Description);
                flpOrderList.Controls.Add(ucDes);
            }    
        }

        private void ShowFreeMessage()
        {
            flpOrderList.Controls.Clear();
            flpOrderList.Controls.Add(new UCOrderItemFreeTable());
        }

        private void layOutConfig()
        {
            helper.MakeRoundedPanel(pFunction, 30);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FProductList fProductList = new FProductList(table);
            fProductList.ShowDialog();
            TableLoad();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            FPayment fPayment = new FPayment(table, totalPrice);
            fPayment.ShowDialog();
            this.Close();
        }
    }
}
