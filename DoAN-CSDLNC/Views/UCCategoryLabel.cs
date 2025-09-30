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
    public partial class UCCategoryLabel : UserControl
    {
        private string title;
        public UCCategoryLabel(string title)
        {
            InitializeComponent();
            this.title = title;
        }

        private void UCCategoryLabel_Load(object sender, EventArgs e)
        {
            lTittle.Text = title + ":";
        }
    }
}
