using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Form f = new Form();

            Button btn = new Button()
            {
                Text = "Жми меня"
            };

            btn.Click += Btn_Click;


            f.Controls.Add(btn);

            Application.Run(f);
        }

        private static void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Огогого");
        }
    }
}
