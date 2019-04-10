using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    public partial class Form1 : Form
    {
        public delegate void mtdPrint(string s);

        public Form1()
        {
            InitializeComponent();
            plusBtn.Text = "+1";
            muliBtn.Text = "x2";
            clearBtn.Text = "Сброс";
            timer.Text = "0:00:00";
            Print(new mtdPrint(PrintInfo), "Нажмите \"Новая игра\" для начала");
        }
        int maxNumber = 1000; // переменная для изменения максимально загадываемого компьютером числа
        int vTarget = 0;
        int vNumber = 0;
        int comands = 0;
        Stack<int> log = new Stack<int>();

        // Логика
        private void start_Click(object sender, EventArgs e) // метод нажатия на кнопку старт
        {
            log.Clear();
            Random r = new Random();
            vTarget = r.Next(maxNumber-maxNumber/10) + maxNumber/10;
            Print(new mtdPrint(PrintTarget), vTarget.ToString());
            playTime.Enabled = true;
            AddLog(ref log, 0);
        }

        private void playTime_Tick(object sender, EventArgs e) // обработка тика таймера
        {
            int[] timerArray = ConvertTimeString(timer.Text);
            timerArray[2]++;
            if (timerArray[2] >= 60)
            {
                timerArray[2] = timerArray[2] - 60;
                timerArray[1] = timerArray[1] + 1;
            }
            if (timerArray[1] >= 60)
            {
                timerArray[1] = timerArray[1] - 60;
                timerArray[0] = timerArray[0] + 1;
            }
            Print(new mtdPrint(PrintTimer), $"{timerArray[0]}:{timerArray[1]:D2}:{timerArray[2]:D2}");
        }

        private void plusBtn_Click(object sender, EventArgs e) // метод нажатия на кнопку +1
        {
            vNumber++;
            comands++;
            Print(new mtdPrint(PrintNumber), vNumber.ToString());
            AddLog(ref log, 1);
            CheckGame();

        }
        private void PlusOneCancel() // отмена операции +1
        {
            comands++;
            vNumber--;
            Print(new mtdPrint(PrintNumber), vNumber.ToString());
        }
        private void muliBtn_Click(object sender, EventArgs e) // метод нажатия на кнопку х2
        {
            vNumber = vNumber * 2;
            comands++;
            Print(new mtdPrint(PrintNumber), vNumber.ToString());
            AddLog(ref log, 2);
            CheckGame();
        }
        private void MultyCancel() // отмена операции х2
        {
            comands++;
            vNumber = vNumber / 2;
            Print(new mtdPrint(PrintNumber), vNumber.ToString());
        }
        private void cancel_Click(object sender, EventArgs e) // метод отмены последнего хода
        {
            int move = log.Pop();
            switch (move)
            {
                case 0:
                    Print(new mtdPrint(PrintInfo), "Начало игры невозможно отменить");
                    break;
                case 1:
                    Print(new mtdPrint(PrintInfo), "Последний ход +1 отменен");
                    PlusOneCancel();
                    break;
                case 2:
                    Print(new mtdPrint(PrintInfo), "Последний ход *2 отменен");
                    MultyCancel();
                    break;
                default:
                    Print(new mtdPrint(PrintInfo), "Неизвестная ошибка");
                    break;
            }
        }
        private void clearBtn_Click(object sender, EventArgs e) // после нажатия кнопки сброса, пользовательское число возовращается на 0, увеличивается счетчик числа команд и обнуляется лог
        {
            vNumber = 0;
            Print(new mtdPrint(PrintNumber), vNumber.ToString());
            comands++;
            log.Clear();
        }
        private void CheckGame() // метод проверки состояния игры, нужно ли ее завершить или можно продолжить
        {
            if (vTarget < vNumber) LoseTheGame();
            else if (vTarget == vNumber) WinTheGame();
        }
        private void LoseTheGame() // метод конца игры в случае поражения
        {
            int[] timerArray = ConvertTimeString(timer.Text);
            Print(new mtdPrint(PrintAlert), $"К сожалению вы проиграли!\nЗатрачено {comands} ходов\nВремя игры составил {timer.Text}");
            EndOfGame();
        }
        private void WinTheGame() // метод конца игры в случае победы
        {
            int[] timerArray = ConvertTimeString(timer.Text);
            Print(new mtdPrint(PrintAlert), $"Поздравляем с победой!\nЗатрачено {comands} ходов\nВремя игры составило {timer.Text}");
            EndOfGame();
        }
        private void EndOfGame() // метод окончания игры, обнуляющий переменные и позволяющий начать игру заново
        {
            playTime.Enabled = false;
            Print(new mtdPrint(PrintTimer), "0:00:00");
            comands = 0;
            vTarget = 0;
            Print(new mtdPrint(PrintTarget), vTarget.ToString());
            vNumber = 0;
            Print(new mtdPrint(PrintNumber), vNumber.ToString());
            Print(new mtdPrint(PrintInfo),"");
            log.Clear();
        }
        private int[] ConvertTimeString(string s) // метод, преобразующий строку состояния таймера в целочисленный массив формата x = {час, минута, секунда}
        {
            string[] sTemp = s.Split(':');
            int[] result = new int[3];
            for (int i = 0; i < 3; i++) result[i] = int.Parse(sTemp[i]);
            return result;
        }
        private void AddLog(ref Stack<int> log, int move) // метод добавления последнего хода в лог ходов, выведение информации на экран
        {
            log.Push(move);
            switch (move) {
                case 0:
                    Print(new mtdPrint(PrintInfo), "Игра запущена");
                    break;
                case 1:
                    Print(new mtdPrint(PrintInfo), "К вашему числу прибавлена 1");
                    break;
                case 2:
                    Print(new mtdPrint(PrintInfo), "Ваше число умножено на 2");
                    break;
                default:
                    Print(new mtdPrint(PrintInfo), "Ошибка добавления лога");
                    break;
            }

        }
        // Интерфейс
        private void PrintAlert(string s) // метод вывода окна с сообщением
        {
            MessageBox.Show(s);
        }
        private void PrintInfo(string s) // метод вывода info
        {
            info.Text = s;
        }
        private void PrintNumber(string s) // метод вывода пользовательского числа
        {
            number.Text = s;
        }
        private void PrintTimer(string s) // метод вывода таймера
        {
            timer.Text = s;
        }
        private void PrintTarget(string s) // метод вывода целевого числа
        {
            target.Text = s;
        }
        private void Print(mtdPrint P, string s) // метод обработки делегата
        {
            P(s);
        }
    }
}
