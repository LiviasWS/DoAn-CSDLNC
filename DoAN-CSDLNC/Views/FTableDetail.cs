using DoAN_CSDLNC.Models;
using DoAN_CSDLNC.Views;
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
        private UIHelper helper = new UIHelper();
        private Table table;
        public FTableDetail(Table table)
        {
            this.table = table;
            InitializeComponent();
        }

        private void FTableDetail_Load(object sender, EventArgs e)
        {
            lName.Text = "Table " + table.TableNumber.ToString();
            switch(table.Status)
            {
                case "Free":
                    TableLoad();
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
            UCOrderItem uc1 = new UCOrderItem("Tra sua", "S", 1, 30000);
            UCOrderItem uc2 = new UCOrderItem("Coffee", "S", 1, 40000);
            UCOrderItem uc3 = new UCOrderItem("Matcha", "L", 1, 50000);
            UCOrderItem uc4 = new UCOrderItem("Cacao", "XL", 1, 35000);
            flpOrderList.Controls.Add(uc1);
            flpOrderList.Controls.Add(uc2);
            flpOrderList.Controls.Add(uc3);
            flpOrderList.Controls.Add(uc4);
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
        }
    }
}
