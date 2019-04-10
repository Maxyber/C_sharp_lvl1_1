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
            lblInfo.MaximumSize = new Size(this.Width - 20,0);
        }

        int max = 100; // максимальное загадываемое число
        int count = 1; // счетчик попыток
        int player = 1; // порядковый номер игрока
        int maxPlayers = 2;
        Random r = new Random();
        int gNumber; // загаданное число
        
        // ЛОГИКА
        private void mainForm_Load(object sender, EventArgs e)
        {
            gNumber = r.Next(max + 1);
            ButtonChange(btnInputNumber, false);
            LabelChange(lblPlayer, false);
        }
        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            lblInfo.MaximumSize = new Size(this.Width - 20, 0);
        }
        private void start_Click(object sender, EventArgs e) // метод по кнопке Начать игру
        {
            int count = 1;
            int player = 1;
            InitialFormData(true);
            Print(new delPrint(PrintNumber), "");
            Print(new delPrint(PrintTry), "Попытка №" + count);
            Print(new delPrint(PrintInfo), "Число загадано, нажмите \"Ввести число\" для продолжения");
            ButtonChange(btnInputNumber, true);
            ButtonChange(btnStart, false);
        }
        private void CheckAnswer(int answer) // метод проверки ответа пользователя
        {
            if (gNumber == answer) WinTheGame();
            else if (gNumber < answer)
            {
                count++;
                Print(new delPrint(PrintInfo), $"Число {answer} слишком большое! Ход {count}");
                ReNew();
            }
            else if (gNumber > answer)
            {
                count++;
                Print(new delPrint(PrintInfo), $"Число {answer} слишком маленькое! Ход {count}");
                ReNew();
            }
        }
        private void ReNew() // обновление информации в форме
        {
            Print(new delPrint(PrintTry), "Попытка №" + count);
            player = maxPlayers + 1 - player;
            Print(new delPrint(PrintPlayer), "Ход игрока " + player);

        }
        private void WinTheGame() // метод срабатывающий в случае угаданного числа
        {
            InitialFormData(false);
            Print(new delPrint(PrintInfo), $"Поздравляем! Вы выиграли за {count} ходов!");
            ButtonChange(btnStart, true);
            ButtonChange(btnInputNumber, false);
        }
        public void TakeResultForm(int x) // публичный метод, который получает число из второй формы
        {
            Print(new delPrint(PrintNumber), $"Вы ввели число {x}");
            CheckAnswer(x);
        }
        // ИНТЕРФЕЙС
        private void btnInputNumber_Click(object sender, EventArgs e) // метод по кнопке ввести номер
        {
            formInputNumber frmInput = new formInputNumber(this);
            frmInput.Show();
            /* метод работает
            if (int.TryParse(txtInputNumber.Text, out int x))
            {
                Print(new delPrint(PrintNumber), $"Вы ввели число {x}");
                CheckAnswer(x);
            }
            else Print(new delPrint(PrintInfo), "Вы ввели не целое число!");
            */
        }
        private void LabelChange(Label l, bool x)
        {
            l.Visible = x;
        }
        private void ButtonChange(Button b, bool x)
        {
            b.Visible = x;
        }
        private void ButtonChange(Button b)
        {
            if (b.Visible) b.Visible = false;
            else b.Visible = true;
        }
        private void InitialFormData(bool flag)
        {
            if (flag == true)
            {
                lblTry.Show();
                //lblPlayer.Show();
                number.Show();
                btnInputNumber.Show();
            }
            else
            {
                lblTry.Hide();
                //lblPlayer.Hide();
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
