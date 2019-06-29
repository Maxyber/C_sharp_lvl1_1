using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpet
{
    public delegate void delPrint(string s);

    public partial class frmCarpet : Form
    {
        Graphics g;
        Random r;
        // SolidBrush brush;
        int x, y;
        int frPointCount = 3; // задает количество точек фрактала (3 - треугольник, 4 - квадрат и т.д.
        int[,] aPoints;
        int red, green, blue;

        public frmCarpet()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            r = new Random();
            aPoints = CreatePoints(frPointCount); // создает массив из frPointsCount точек для создания фрактала
            Print(new delPrint(PrintInfo), "Добро пожаловать в программу рисования фракталов");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ЛОГИКА
        private void StartDrawing(int repeater)
        {
            int rnd1, rnd2, x, y;
            do
            {
                rnd1 = r.Next(aPoints.Length / 2);
                rnd2 = r.Next(aPoints.Length / 2);
            }
            while (rnd1 == rnd2);

            x = (aPoints[rnd1, 0] + aPoints[rnd2, 0]) / 2;
            y = (aPoints[rnd1, 1] + aPoints[rnd2, 1]) / 2;

            for (int i = 0; i < repeater; i++)
            {
                red = r.Next(256);
                green = r.Next(256);
                blue = r.Next(256);
                g.FillEllipse(new SolidBrush(Color.FromArgb(255, red, green, blue)),x,y,2,2);
                rnd1 = r.Next(aPoints.Length / 2);
                x = (x + aPoints[rnd1, 0]) / 2;
                y = (y + aPoints[rnd1, 1]) / 2;

            }
            Print(new delPrint(PrintInfo), "Объект нарисован. Нажмите 'Очистить' для очистки формы и обновления точек");
        }
        private int[,] CreatePoints(int count)
        {
            int[,] result = new int[count, 2];
            for (int i = 0; i < count; i++)
            {
                result[i, 0] = r.Next(10, this.Width);
                result[i, 1] = r.Next(45, this.Height);
            }
            return result;
        }

        private void txtRepeater_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRepeater.Text, out int x) && (x <= 100000) && (x >= 10000))
            {
                Print(new delPrint(PrintInfo), "");
                StartDrawing(x);
            }
            else Print(new delPrint(PrintAlert), "Введите, пожалуйста, число повторений не меньше 10 000 и не больше 100 000!");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(this.BackColor.ToArgb())),10,45,this.Width - 10, this.Height - 45);
            aPoints = CreatePoints(frPointCount);
        }

        private void PrintInfo(string s)
        {
            lblInfo.Text = s;
        }
        private void PrintAlert(string s)
        {
            MessageBox.Show(s);
        }
        private void Print(delPrint P, string s)
        {
            P(s);
        }
    }
}
