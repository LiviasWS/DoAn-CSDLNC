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

namespace DoAN_CSDLNC
{
    public partial class UCTableDashboard : UserControl
    {
        private UIHelper helper = new UIHelper();
        private DBConnection connection = new DBConnection();
        private IMongoCollection<Table> Table;
        public UCTableDashboard()
        {
            Table = connection.GetCollection<Table>("Tables");
            InitializeComponent();
        }

        private void UCTableDashboard_Load(object sender, EventArgs e)
        {
            helper.MakeRoundedPanel(pFunction, 50);
            reloadTable();
        }

        private void reloadTable()
        {
            List<Table> tables = Table.Find(Builders<Table>.Filter.Empty).ToList();
            flpTableList.Controls.Clear();
            foreach (Table table in tables)
            {
                UCTable ucTable = new UCTable(table);
                flpTableList.Controls.Add(ucTable);
            }
        }

    }
}
