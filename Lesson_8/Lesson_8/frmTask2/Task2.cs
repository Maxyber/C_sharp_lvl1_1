using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTask2
{
    public partial class Task2 : Form
    {
        NumericUpDown nud = new NumericUpDown();

        public Task2()
        {
            InitializeComponent();
            lblnud.Text = $"Значение переменной типа NumericUpDown {nud.Value.ToString()}";
        }

        private void SetNUD(decimal x)
        {
            if (x < nud.Minimum) x = nud.Minimum;
            if (x > nud.Maximum) x = nud.Maximum;
            nud.Value = x;
            lblnud.Text = $"Значение переменной типа NumericUpDown {x.ToString()}";
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNumber.Text, out decimal x))
            {
                SetNUD(x);
            }
        }
    }
}
