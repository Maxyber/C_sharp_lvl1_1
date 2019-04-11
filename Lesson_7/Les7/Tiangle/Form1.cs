using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Graphics g;
        Random r;
        SolidBrush brush;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            x = x1;
            y = y1;
            r = new Random();
            brush = new SolidBrush(Color.Black);
        }

        int x1 = 300, y1 = 10;
        int x2 = 10, y2 = 300;
        int x3 = 700, y3 = 400;
        int x, y;


        void MovePrint(int GetX, int GetY, ref int X, ref int Y )
        {
            X = (X + GetX) / 2;
            Y = (Y + GetY) / 2;
        }




        int red = 1, green=1, blue = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {

                switch (r.Next(3))
                {

                    case 0: MovePrint(x1, y1, ref x, ref y); break;
                    case 1: MovePrint(x2, y2, ref x, ref y); break;
                    default: MovePrint(x3, y3, ref x, ref y); break;

                }

                g.FillEllipse(new SolidBrush(Color.FromArgb(255, red, green, blue)), x, y, 5, 5);
                red+=2; red %= 256;
                green *= red; green %= 256;
                // blue += 2; blue %= 256;
            }


        }
    }
}
