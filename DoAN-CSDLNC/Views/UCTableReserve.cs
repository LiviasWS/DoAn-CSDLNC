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
    public partial class UCTableReserve : UserControl
    {
        private DBConnection connection = new DBConnection();
        private IMongoCollection<TableReserve> TableReserves;
        private Table table;
        private TableReserve tableReserve;
        private TableReserve newReserve;
        public UCTableReserve(Table table, TableReserve tableReserve, TableReserve newReserve)
        {
            TableReserves = connection.GetCollection<TableReserve>("Table_Reserves");
            InitializeComponent();
            this.tableReserve = tableReserve;
            this.newReserve = newReserve;
            this.table = table;
            
        }

        private void UCTableReserve_Load(object sender, EventArgs e)
        {
            lName.Text = "Table " + table.TableNumber;
            if (tableReserve != null)
            {
                lName.ForeColor = Color.Orange;
                pHighlight.BackColor = Color.Orange;
                lStatus.Text = "Reserved";
                lStart.Text = tableReserve.Start.ToString();
                lEnd.Text = tableReserve.End.ToString();
            }
            else
            {
                lName.ForeColor = Color.Gray;
                pHighlight.BackColor = Color.Gray;
                lStatus.Text = "Reserve";
                lStart.Text = "";
                lEnd.Text = "";
            }
        }
        private void UCTableReserve_Click(object sender, EventArgs e)
        {
            
            if (tableReserve == null)
            {
                if (newReserve.Customer != null)
                {
                    newReserve.Table = table;
                    TableReserves.InsertOne(newReserve);
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Customer is required");
                }
            }
        }
    }
}
