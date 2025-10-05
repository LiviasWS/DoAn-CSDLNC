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
    public partial class FProductList : Form
    {
        private DBConnection dBConnection = new DBConnection();
        private Table table;
        private IMongoCollection<Product> Products;
        public FProductList(Table table)
        {
            Products = dBConnection.GetCollection<Product>("Products");
            InitializeComponent();
            this.table = table;
        }

        private void FProductList_Load(object sender, EventArgs e)
        {
            var groups = Products.Aggregate().Group
                (
                    o => o.Category,
                    g => new
                    {
                        Key = g.Key,
                        Products = g.Select(x => x).ToList()
                    }
                ).ToList();
            foreach(var group in groups)
            {
                if(group.Key != "Topping")
                {
                    UCCategoryLabel ucLabel = new UCCategoryLabel(group.Key);
                    flpProductList.Controls.Add(ucLabel);
                    foreach (Product product in group.Products)
                    {
                        UCProduct ucProduct = new UCProduct(product, table);
                        flpProductList.Controls.Add(ucProduct);
                    }
                }
            }
        }
    }
}
