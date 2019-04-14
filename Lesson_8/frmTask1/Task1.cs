using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace frmTask1
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            PropertyInfo[] props = date.GetType().GetProperties();
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < props.Length;i++)
            {
                string[] sa = props[i].ToString().Split(' ');
                str.Append($"Свойство {sa[1]} типа {sa[0]}\r\n");
            }
            lblInfo.Text = str.ToString();
        }
    }
}
