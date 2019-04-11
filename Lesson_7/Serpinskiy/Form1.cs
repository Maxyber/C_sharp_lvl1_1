using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangle;
using Rectangle;

namespace Carpet
{
    public delegate void delPrint(string s);

    public partial class frmCarpet : Form
    {
        Graphics g;
        Random r;
        int red, green, blue;

        public frmCarpet()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            r = new Random();
            Print(new delPrint(PrintInfo), "Добро пожаловать в программу рисования по методам Серпинского");
            rdbRectangle.Enabled = false;
            rdbTriangle.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbRectangle.Enabled = true;
            rdbTriangle.Enabled = true;
            rdbTriangle.Checked = true;
        }
        //
        // ЛОГИКА
        private void StartDrawing(int repeater)
        {
            int maxX = this.Width - 10;
            int maxY = this.Height - 45;
            red = r.Next(256);
            green = r.Next(256);
            blue = r.Next(256);

            if (rdbTriangle.Checked == true)
            {
                Triangle.Triangle uDraw = new Triangle.Triangle(10, maxX, 45, maxY);
                int[] point = uDraw.NewPoint();
                for (int i = 0; i < repeater; i++)
                {
                    int[] newpoint = uDraw.NewPoint(point);
                    g.FillEllipse(new SolidBrush(Color.FromArgb(255, red, green, blue)), point[0], point[1], 2, 2);
                    point = newpoint;
                }
            }
            else if (rdbRectangle.Checked == true)
            {
                Rectangle.Rectangle uDraw = new Rectangle.Rectangle(10, maxX, 45, maxY);
                int[] point = uDraw.NewPoint();
                for (int i = 0; i < repeater; i++)
                {
                    int[] newpoint = uDraw.NewPoint(point);
                    g.FillEllipse(new SolidBrush(Color.FromArgb(255, red, green, blue)), point[0], point[1], 2, 2);
                    point = newpoint;
                }
            }

            Print(new delPrint(PrintInfo), "Объект нарисован. Нажмите 'Очистить' для очистки формы и обновления точек");
        }

        private void btnStart_Click(object sender, EventArgs e) // метод обработки нажатия на кнопку Start, проверяет число повторений и по необходимости запускает рисование
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
            g.FillRectangle(new SolidBrush(Color.FromArgb(this.BackColor.ToArgb())), 10, 45, this.Width - 10, this.Height - 45);
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
