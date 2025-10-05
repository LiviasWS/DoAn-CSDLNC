using DoAN_CSDLNC.Data;
using DoAN_CSDLNC.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class FSaleMain : Form
    {
        private DBConnection dBConnection = new DBConnection();
        public FSaleMain()
        {
            InitializeComponent();
        }

        private void FSaleMain_Load(object sender, EventArgs e)
        {
            UCTableDashboard uCTableDashboard = new UCTableDashboard();
            pConainer.Controls.Add(uCTableDashboard);
        }

        private void msiHome_Click(object sender, EventArgs e)
        {
            pConainer.Controls.Clear();
            UCTableDashboard uCTableDashboard = new UCTableDashboard();
            pConainer.Controls.Add(uCTableDashboard);
        }
    }
}
