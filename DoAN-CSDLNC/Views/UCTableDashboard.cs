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
        private DBConnection connection = new DBConnection();
        private IMongoCollection<Table> Tables;
        private IMongoCollection<TableReserve> TableReserves;
        private UIHelper helper = new UIHelper();
        public UCTableDashboard()
        {
            Tables = connection.GetCollection<Table>("Tables");
            TableReserves = connection.GetCollection<TableReserve>("Table_Reserves");
            InitializeComponent();
        }

        private void UCTableDashboard_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void ReLoad()
        {
            var filter = Builders<Table>.Filter.Empty;
            List<Table> tables = Tables.Find(filter).ToList();
            foreach (Table table in tables)
            {
                var reservefilter = Builders<TableReserve>.Filter.And
                    (
                        Builders<TableReserve>.Filter.Eq(o => o.Table.Id, table.Id),
                        Builders<TableReserve>.Filter.Eq(o => o.Status, "incomplete")
                    );
                List<TableReserve> tableReserves = TableReserves.Find(reservefilter).ToList();
                foreach(TableReserve reserve in tableReserves)
                {
                    if(reserve.End < DateTime.Now && reserve.Status == "incomplete")
                    {
                        updateReserveStatus(reserve, "cancel");
                    }
                }
                TableReserve tableReserve = tableReserves.FirstOrDefault(o => o.Start <= DateTime.Now && DateTime.Now <= o.End);
                if (table.Status == "Free" && tableReserve != null)
                    updateTableStatus(table, "Reserved");
                if(table.Status == "Reserved" && tableReserve == null)
                    updateTableStatus(table, "Free");
                UCTable uCTable = new UCTable(table);
                flpTableList.Controls.Add(uCTable);
            }
        }

        private void updateTableStatus(Table table, string status)
        {
            var filter = Builders<Table>.Filter.Eq(o => o.Id, table.Id);
            var update = Builders<Table>.Update.Set(o => o.Status, status);
            Tables.UpdateOne(filter, update);
        }

        private void updateReserveStatus(TableReserve tableReserve, string status)
        {
            var filter = Builders<TableReserve>.Filter.Eq(o => o.Id, tableReserve.Id);
            var update = Builders<TableReserve>.Update.Set(o => o.Status, status);
            TableReserves.UpdateOne(filter, update);
        }

    }
}
