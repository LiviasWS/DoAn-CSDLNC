using System;
using System.Windows.Forms;

namespace DoAN_CSDLNC
{
    public partial class InputNumberForm : Form
    {
        public int Value { get; private set; }

        public InputNumberForm(string title, int currentValue)
        {
            InitializeComponent();
            this.Text = title;
            nudValue.Value = currentValue > nudValue.Maximum ? nudValue.Maximum : currentValue;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Value = (int)nudValue.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void InputNumberForm_Load(object sender, EventArgs e)
        {

        }
    }
}