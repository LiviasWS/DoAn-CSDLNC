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
    public partial class UCOrderItemDescription : UserControl
    {
        private string des;
        public UCOrderItemDescription(string des)
        {
            this.des = des;
            InitializeComponent();
        }

        private void UCOrderItemDescription_Load(object sender, EventArgs e)
        {
            rtbDes.Text = des;
        }
    }
}
