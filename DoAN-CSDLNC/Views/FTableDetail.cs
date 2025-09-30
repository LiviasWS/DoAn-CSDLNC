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
        private string tableName;
        private string tableStatus;
        public FTableDetail(string tableName, string tableStatus)
        {
            this.tableName = tableName;
            this.tableStatus = tableStatus;
            InitializeComponent();
        }

        private void FTableDetail_Load(object sender, EventArgs e)
        {
            lName.Text = tableName;
            switch(tableStatus)
            {
                case "Free":
                    lName.ForeColor = Color.LimeGreen;
                    pHighLight.BackColor = Color.LimeGreen;
                    break;
                case "Occupied":
                    OccupiedTableLoad();
                    break;
                case "Reserved":
                    lName.ForeColor = Color.Orange;
                    pHighLight.BackColor = Color.Orange;
                    break;
            }
            layOutConfig();
        }

        private void OccupiedTableLoad()
        {
            lName.ForeColor = Color.LightCoral;
            pHighLight.BackColor = Color.LightCoral;
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
    }
}
