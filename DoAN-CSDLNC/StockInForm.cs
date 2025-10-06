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
    public partial class StockInForm : Form
    {
        public int QuantityToAdd { get; private set; } = 0;

        public StockInForm()
        {
            InitializeComponent();
        }

        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_soLuong.Text, out int value) && value > 0)
            {
                QuantityToAdd = value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương.");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void StockInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
