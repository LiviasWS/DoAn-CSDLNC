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
        private Product product;
        private string size;
        private int quantity;
        private int totalPrice;
        public UCOrderItem(string productID, string size, int quantity)
        {
            Products = connection.GetCollection<Product>("Products");
            SizeManages = connection.GetCollection<SizeManage>("Size_Manages");
            product = Products.Aggregate().Match(o => o.Id == productID).FirstOrDefault();
            this.size = size;
            this.quantity = quantity;
            InitializeComponent();
        }

        private void UCOrderItem_Load(object sender, EventArgs e)
        {
            lName.Text = product.Name;
            lSize.Text = size;
            lQuantity.Text = quantity.ToString();
            SizeManage sizeManage = new SizeManage();
            if (product.Category != "Topping")
            {
                var filter = Builders<SizeManage>.Filter.And
                (
                    Builders<SizeManage>.Filter.Eq(o => o.ProductId, product.Id),
                    Builders<SizeManage>.Filter.Eq(o => o.Size, size)
                );
                sizeManage = SizeManages.Find(filter).FirstOrDefault();
            }
            else
            {
                var filter = Builders<SizeManage>.Filter.And
                    (
                        Builders<SizeManage>.Filter.Eq(o => o.ProductId, product.Id)
                    );
                sizeManage = SizeManages.Find(filter).FirstOrDefault();
            }
            totalPrice = sizeManage.Price * quantity;
            lTotalPrice.Text = totalPrice.ToString();
            if(product.Category == "Topping")
            {
                lName.ForeColor = Color.Gray;
                lQuantity.ForeColor = Color.Gray;
                lTotalPrice.ForeColor = Color.Gray;
            }
        }

        public int GetTotalPrice()
        {
            return totalPrice;
        }

    }
}
