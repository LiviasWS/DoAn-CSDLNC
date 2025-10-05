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
    public partial class FOrderItem : Form
    {
        private DBConnection conn = new DBConnection();
        private IMongoCollection<SizeManage> SizeManages;
        private IMongoCollection<Table> Tables;
        private IMongoCollection<Product> Products;
        private IMongoCollection<Order> Orders;
        private IMongoCollection<OrderItem> OrderItems;
        private Product product;
        private Table table;
        public FOrderItem(Product product, Table table)
        {
            this.product = product;
            this.Tables = conn.GetCollection<Table>("Tables");
            this.SizeManages = conn.GetCollection<SizeManage>("SizeManages");
            this.Products = conn.GetCollection<Product>("Products");
            this.Orders = conn.GetCollection<Order>("Orders");
            this.OrderItems = conn.GetCollection<OrderItem>("Order_Items");
            InitializeComponent();
            this.table = table;
        }

        private void FOrderItem_Load(object sender, EventArgs e)
        {
            lName.Text = product.Name;
            cbbSize.SelectedIndex = 0;
            List<Product> products = Products.Aggregate().Match(p => p.Category == "Topping").ToList();
            foreach (Product p in products)
            {
                UCTopping uCTopping = new UCTopping(p);
                flpTopping.Controls.Add(uCTopping);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch(table.Status)
            {
                case "Free":
                    FreeTableCase();
                    break;
                case "Occupied":
                    OccupiedTableCase();
                    break;
                case "Reserve":
                    break;
                default:
                    break;
            }
            this.Close();
        }

        private void OccupiedTableCase()
        {
            if(nudQuantity.Value == 0)
            {
                MessageBox.Show("Enter quantity Value");
                return;
            }
            ConfigOrderItem();
        }

        private void ConfigOrderItem()
        {
            var orderFilter = Builders<Order>.Filter.And
                (
                    Builders<Order>.Filter.Eq(o => o.TableId, table.Id),
                    Builders<Order>.Filter.Eq(o => o.Status, "in_progress")
                );
            Order order = Orders.Find(orderFilter).FirstOrDefault();
            OrderItem orderItem = new OrderItem() 
            {
                OrderId = order.Id,
                ProductId = product.Id,
                Size = cbbSize.Text,
                Quantity = (int)nudQuantity.Value,
                Description = rtbDescription.Text
            };
            foreach(UCTopping ucTopping in flpTopping.Controls)
            {
                if(ucTopping.getQuantity() > 0)
                {
                    Topping topping = new Topping()
                    {
                        Product = ucTopping.GetProduct(),
                        Quantity = ucTopping.getQuantity() * (int)nudQuantity.Value
                    };
                    orderItem.Toppings.Add(topping);
                }
            }
            OrderItems.InsertOne(orderItem);
        }

        private void FreeTableCase()
        {
            Order newOrder = new Order()
            {
                TableId = table.Id,
                Status = "in_progress",
                CreatedAt = DateTime.Now
            };
            Orders.InsertOne(newOrder);
            updateTableStatus("Occupied");
        }

        private void updateTableStatus(string status)
        {
            var filter = Builders<Table>.Filter.Eq(o => o.Id, table.Id);
            var update = Builders<Table>.Update.Set( o => o.Status, status );
            Tables.UpdateOne(filter, update);
        }

    }
}
