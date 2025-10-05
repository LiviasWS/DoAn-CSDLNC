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
    public partial class UCTable : UserControl
    {
        private string name;
        private string status;
        public UCTable(string name, string status)
        {
            this.name = name;
            this.status = status;
            InitializeComponent();
        }

        private void UCTable_Load(object sender, EventArgs e)
        {
            lName.Text = name;
            lStatus.Text = status;
            switch(status)
            {
                case "Free":
                    lName.ForeColor = Color.LimeGreen;
                    pHighlight.BackColor = Color.LimeGreen;
                    break;
                case "Occupied":
                    lName.ForeColor = Color.LightCoral;
                    pHighlight.BackColor = Color.LightCoral;
                    break;
                case "Reserved":
                    lName.ForeColor = Color.Orange;
                    pHighlight.BackColor = Color.Orange;
                    break;
                default:
                    break;
            }
        }

        private void UCTable_Click(object sender, EventArgs e)
        {
            FTableDetail fTableDetail = new FTableDetail(name, status);
            fTableDetail.Show();
        }
    }
}
