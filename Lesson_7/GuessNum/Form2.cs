using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNum
{
    public partial class formInputNumber : Form
    {
        public mainForm mf;

        public formInputNumber()
        {
            InitializeComponent();
        }
        public formInputNumber(mainForm f)
        {
            InitializeComponent();
            mf = f;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            if (int.TryParse(txtInputNumber.Text, out x))
            {
                mf.TakeResultForm(x);
                this.Close();
            }
            else lblInputNumber.Text = "Вы ввели не целое число!!!";
        }
    }
}
