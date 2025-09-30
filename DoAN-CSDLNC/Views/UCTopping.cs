using DoAN_CSDLNC.Models;
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
    public partial class UCTopping : UserControl
    {
        private Product product;
        public UCTopping(Product product)
        {
            this.product = product;
            InitializeComponent();
        }

        private void UCTopping_Load(object sender, EventArgs e)
        {
            lName.Text = product.Name;
        }

        public int getQuantity()
        {
            return (int)nudQuantity.Value;
        }

    }
}
