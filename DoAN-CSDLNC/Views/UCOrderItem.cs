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

namespace DoAN_CSDLNC
{
    public partial class UCOrderItem : UserControl
    {
        private DBConnection connection = new DBConnection();
        private IMongoCollection<Product> Products;
        private IMongoCollection<SizeManage> SizeManages;
        private OrderItem orderItem;
        private string productID;
        private string size;
        private int quantity;
        private int totalPrice;
        public UCOrderItem(string productID, string size, int quantity)
        {
            this.productID = productID;
            this.size = size;
            this.quantity = quantity;
            this.Products = connection.GetCollection<Product>("Products");
            SizeManages = connection.GetCollection<SizeManage>("Size_Manages");
            InitializeComponent();
        }

        private void UCOrderItem_Load(object sender, EventArgs e)
        {
            Product product = Products.Find(Builders<Product>.Filter.Eq(o => o.Id, productID)).FirstOrDefault();
            lName.Text = product.Name;
            lSize.Text = size;
            lQuantity.Text = quantity.ToString();
            var filter = Builders<SizeManage>.Filter.And
                (
                    Builders<SizeManage>.Filter.Eq(o => o.ProductId, product.Id),
                    Builders<SizeManage>.Filter.Eq(o => o.Size, size)
                );
            SizeManage sizeManage = SizeManages.Find(filter).FirstOrDefault();
            totalPrice = sizeManage.Price * quantity;
            lTotalPrice.Text = totalPrice.ToString();
            if (product.Category == "Topping")
            {
                lName.ForeColor = Color.Gray;
                lQuantity.ForeColor = Color.Gray;
                lSize.ForeColor = Color.Gray;
                lTotalPrice.ForeColor = Color.Gray;
                lSize.Text = "";
            }
        }

        public int GetTotalPrice()
        {
            Product product = Products.Find(Builders<Product>.Filter.Eq(o => o.Id, productID)).FirstOrDefault();
            var filter = Builders<SizeManage>.Filter.And
                (
                    Builders<SizeManage>.Filter.Eq(o => o.ProductId, product.Id),
                    Builders<SizeManage>.Filter.Eq(o => o.Size, size)
                );
            SizeManage sizeManage = SizeManages.Find(filter).FirstOrDefault();
            return sizeManage.Price * quantity;
        }

    }
}
