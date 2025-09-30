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
        private IMongoCollection<SizeManage> SizeManage;
        private IMongoCollection<Product> Product;
        private IMongoCollection<Order> Order;
        private Product product;
        private Table table;
        public FOrderItem(Product product, Table table)
        {
            this.product = product;
            this.SizeManage = conn.GetCollection<SizeManage>("SizeManages");
            this.Product = conn.GetCollection<Product>("Products");
            this.Order = conn.GetCollection<Order>("Orders");
            InitializeComponent();
            this.table = table;
        }

        private void FOrderItem_Load(object sender, EventArgs e)
        {
            lName.Text = product.Name;
            List<Product> products = Product.Aggregate().Match(p => p.Category == "Topping").ToList();
            foreach (Product p in products)
            {
                UCTopping uCTopping = new UCTopping(p);
                flpTopping.Controls.Add(uCTopping);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Order order = Order.Aggregate().Match( o => o.TableId == table.Id && o.Status == "in_progress").FirstOrDefault();
            if (order == null)
            {

            }
        }
    }
}
