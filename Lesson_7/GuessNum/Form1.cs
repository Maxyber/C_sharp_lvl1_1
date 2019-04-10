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
    public partial class mainForm : Form
    {
        public delegate void delPrint(string s);

        public mainForm()
        {
            InitializeComponent();
            InitialFormData(false);
            formInputNumber inputNumber = new formInputNumber();
            lblInfo.MaximumSize = new Size(this.Width - 20,0);
        }

        int max = 100; // максимальное загадываемое число
        int count = 0; // счетчик попыток
        int player = 1; // порядковый номер игрока
        int uNumber; // число игрока
        int gNumber; // загаданное число


        private void mainForm_Load(object sender, EventArgs e)
        {

        }
        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            lblInfo.MaximumSize = new Size(this.Width - 20, 0);
        }
        private void start_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int gNumber = r.Next(max + 1);
            int count = 1;
            int player = 1;
            InitialFormData(true);
            Print(new delPrint(PrintNumber), "");
            Print(new delPrint(PrintTry), "Попытка №" + count);
            Print(new delPrint(PrintInfo), "Число загадано, нажмите \"угадать\" для продолжения" + count);
        }
        // интерфейс
        private void InitialFormData(bool flag)
        {
            if (flag == true)
            {
                lblTry.Show();
                lblPlayer.Show();
                number.Show();
            }
            else
            {
                lblTry.Hide();
                lblPlayer.Hide();
                number.Hide();
            }
        }
        private void PrintInfo(string s)
        {
            lblInfo.Text = s;
        }
        private void PrintPlayer(string s)
        {
            lblPlayer.Text = s;
        }
        private void PrintTry(string s)
        {
            lblTry.Text = s;
        }
        private void PrintNumber(string s)
        {
            number.Text = s;
        }
        private void Print(delPrint P, string s)
        {
            P(s);
        }
    }
}
