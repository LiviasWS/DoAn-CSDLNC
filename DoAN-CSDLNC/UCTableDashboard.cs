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
    public partial class UCTableDashboard : UserControl
    {
        private UIHelper helper = new UIHelper();
        public UCTableDashboard()
        {
            InitializeComponent();
        }

        private void UCTableDashboard_Load(object sender, EventArgs e)
        {
            helper.MakeRoundedPanel(pFunction, 50);
            flpTableList.Controls.Clear();
            UCTable uc1 = new UCTable("Table 1", "Free");
            flpTableList.Controls.Add(uc1);
            UCTable uc2 = new UCTable("Table 2", "Occupied");
            flpTableList.Controls.Add(uc2);
            UCTable uc3 = new UCTable("Table 3", "Free");
            flpTableList.Controls.Add(uc3);
            UCTable uc4 = new UCTable("Table 4", "Free");
            flpTableList.Controls.Add(uc4);
            UCTable uc5 = new UCTable("Table 5", "Occupied");
            flpTableList.Controls.Add(uc5);
            UCTable uc6 = new UCTable("Table 6", "Free");
            flpTableList.Controls.Add(uc6);
            UCTable uc7 = new UCTable("Table 7", "Reserved");
            flpTableList.Controls.Add(uc7);
            UCTable uc8 = new UCTable("Table 8", "Free");
            flpTableList.Controls.Add(uc8);
        }

    }
}
