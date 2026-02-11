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
        private string name;
        private string size;
        private int quantity;
        private int totalPrice;
        public UCOrderItem(string name, string size, int quantity, int totalPrice)
        {
            this.name = name;
            this.size = size;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
            InitializeComponent();
        }

        private void UCOrderItem_Load(object sender, EventArgs e)
        {
            lName.Text = name;
            lSize.Text = size;
            lQuantity.Text = quantity.ToString();
            lTotalPrice.Text = totalPrice.ToString();
        }
    }
}
