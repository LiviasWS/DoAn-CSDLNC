using DoAN_CSDLNC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using ImageMagick;
using DoAN_CSDLNC.Data;

namespace DoAN_CSDLNC.Views
{
    public partial class UCProduct : UserControl
    {
        private UIHelper uIHelper = new UIHelper();
        private Product product;
        private Table table;
        public UCProduct(Product product, Table table)
        {
            this.product = product;
            InitializeComponent();
            this.table = table;
        }

        private void UCProduct_Load(object sender, EventArgs e)
        {
            try
            {
                lName.Text = product.Name;
                string projectPath = Path.GetFullPath(Path.Combine(System.Windows.Forms.Application.StartupPath, @"..\..\"));
                string imagePath = Path.Combine(projectPath, "Images", product.Image);
                pbImage.Image = System.Drawing.Image.FromFile(imagePath);
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UCProduct_Click(object sender, EventArgs e)
        {
            FOrderItem fOrderItem = new FOrderItem(product, table);
            fOrderItem.ShowDialog();
        }
    }
}
