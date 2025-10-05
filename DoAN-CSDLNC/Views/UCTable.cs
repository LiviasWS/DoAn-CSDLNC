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

namespace DoAN_CSDLNC
{
    public partial class UCTable : UserControl
    {
        private Table table;
        public UCTable(Table table)
        {
            this.table = table;
            InitializeComponent();
        }

        private void UCTable_Load(object sender, EventArgs e)
        {
            lName.Text = "Table " + table.TableNumber.ToString();
            lStatus.Text = table.Status;
            switch(table.Status)
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
            FTableDetail fTableDetail = new FTableDetail(table);
            fTableDetail.Show();
        }
    }
}
