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
        int[,] aPoints;
        int red, green, blue;

        public frmCarpet()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            r = new Random();
            aPoints = CreatePoints(); // создает массив точек-аттракторов
            Print(new delPrint(PrintInfo), "Добро пожаловать в программу рисования ковра Серпинского");
            rdbRectangle.Enabled = false;
            rdbTriangle.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ЛОГИКА
        private void StartDrawing(int repeater)
        {
            int rndx, rndy, x, y, attr;

            rndx = r.Next(aPoints[0,0]+1,aPoints[1,0]); // задаем случайную точку внутри квадрата
            rndy = r.Next(aPoints[0,1]+1,aPoints[1,1]); 
            attr = r.Next(0, 8); // выбираем точку-аттрактор для расчета Pi

            x = (rndx + 2 * aPoints[attr, 0]) / 3;
            y = (rndy + 2 * aPoints[attr, 1]) / 3;

            red = r.Next(256);
            green = r.Next(256);
            blue = r.Next(256);

            for (int i = 0; i < repeater; i++)
            {
                g.FillEllipse(new SolidBrush(Color.FromArgb(255, red, green, blue)),x,y,2,2);
                attr = r.Next(0, 8);
                x = (x + 2 * aPoints[attr, 0]) / 3;
                y = (y + 2 * aPoints[attr, 1]) / 3;

            }
            Print(new delPrint(PrintInfo), "Объект нарисован. Нажмите 'Очистить' для очистки формы и обновления точек");
        }
        private int[,] CreatePoints() // создаем 8 аттрактных точек прямоугольника на основании двух случайных противоположных точек
        {
            int[,] result = new int[8, 2];
            for (int i = 0; i < 2; i++)
            {
                result[i, 0] = r.Next(10, this.Width-10);
                result[i, 1] = r.Next(45, this.Height-45);
            }
            if (result[0,0] > result[1,0])
            {
                int i = result[1, 0];
                result[1, 0] = result[0, 0];
                result[0, 0] = i;
            }
            if (result[0,1] > result[1,1])
            {
                int i = result[0, 1];
                result[0, 1] = result[1, 1];
                result[1, 1] = i;
            }
            int vx1 = result[0, 0];
            int vx2 = result[1, 0];
            int vy1 = result[0, 1];
            int vy2 = result[1, 1];

            result[2, 0] = (vx1 + vx2) / 2;
            result[2, 1] = vy1;
            result[3, 0] = vx2;
            result[3, 1] = vy1;
            result[4, 0] = vx2;
            result[4, 1] = (vy1 + vy2) / 2;
            result[5, 0] = (vx1 + vx2) / 2;
            result[5, 1] = vy2;
            result[6, 0] = vx1;
            result[6, 1] = vy2;
            result[7, 0] = vx1;
            result[7, 1] = (vy1 + vy2) / 2;
            return result;
        }

        private void txtRepeater_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRepeater.Text, out int x) && (x <= 500000) && (x >= 10000))
            {
                Print(new delPrint(PrintInfo), "");
                StartDrawing(x);
            }
            else Print(new delPrint(PrintAlert), "Введите, пожалуйста, число повторений не меньше 10 000 и не больше 500 000!");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(this.BackColor.ToArgb())),10,45,this.Width - 10, this.Height - 45);
            aPoints = CreatePoints();
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
