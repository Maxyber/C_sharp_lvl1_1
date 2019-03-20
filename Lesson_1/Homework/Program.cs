using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        /*
        Вопросы по заданию:
        1) можно ли вводимое с клавиатуры значение сразу записывать в переменную типа int или double? как это сделать?


        Бухтияров  
         
        Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.
             
             
        */
        // метод расчета расстояния между точками
        static double PointsDistanceMethod(int x1, int y1, int x2, int y2)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }
        // метод вывода строки по требуемым координатам консоли
        static void PrintMsg (int x, int y, string pmsg)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(pmsg);
        }

        static void Main(string[] args)
        {
            string Family = "";
            string Name = "";
            int Age;
            double Height;
            int Weight;

            //  программа Анкета
            Console.WriteLine("Введите вашу фамилию");
            Family = Console.ReadLine();

            Console.WriteLine("Введите ваше имя");
            Name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст в годах");
            Age = Convert.ToInt32(Console.ReadLine());          // перевод в численное строкового значения возраста

            Console.WriteLine("Введите ваш рост в сантиметрах");
            Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ваш вес в килограммах");
            Weight = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(Family + " " + Name + ", возраст " + Age + " лет, вес " + Weight + " килограмм при росте " + Height + " сантиметров."); // способ вывода на экран склеиванием
            Console.WriteLine("{0} {1}, возраст {2} лет, вес {3} килограмм при росте {4} сантиметров.", Family, Name, Age, Weight, Height); // форматированный вывод на экран
            Console.WriteLine($"{Family} {Name}, возраст {Age} лет, вес {Weight} килограмм при росте {Height} сантиметров."); // форматированный вывод через знак $
            Console.ReadKey();

            /*
            Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
            */
            // программа рассчета индекса массы тела
            Height = Height / 100; // приводим рост человека к значению в метрах для расчета показателя
            double IMT;
            IMT = (Weight) / (Math.Pow(Height, 2));
            Console.WriteLine("Ваш индекс массы тела: {0:F2}", IMT);
            Console.ReadKey();

            /*
            а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)). 
            Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            */
            int x1, x2, y1, y2;
            Console.WriteLine("введите последовательно координаты двух точек, x1, y1, x2, y2, нажимая Enter после ввода каждой координаты");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x1 - {x1}, y1 = {y1}, x2 - {x2}, y2 - {y2}");

            Console.WriteLine($"Расстояние между точкам: {PointsDistanceMethod(x1, y1, x2, y2):f2}");

            /*
            Написать программу обмена значениями двух переменных:
            а) с использованием третьей переменной;
	        б) *без использования третьей переменной.
            */

            string strX, strY; // переменные для которых требуется обмен значениями
            int XX, YY;

            Console.WriteLine("Введите значение первой переменной x");
            strX = Console.ReadLine();
            Console.WriteLine("Введите значение второй переменной y");
            strY = Console.ReadLine();
            // обмен значениями переменных с использованием третьей любой тип
            /*
            strTemp = strY;
            strY = strX;
            strX = strTemp;
            */
            // обмен значениями переменных без использования третьей числовой тип
            XX = Convert.ToInt32(strX);
            YY = Convert.ToInt32(strY);
            XX = XX + YY;
            YY = XX - YY;
            XX = XX - YY;
            Console.WriteLine($"X = {XX}, Y = {YY}");


            /*
            а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) *Сделать задание, только вывод организовать в центре экрана.
            в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
            */
            Console.Clear();
            string City = "Балашиха", FIO;
            int consoleWidth, consoleHeight;
            double xStart, yStart;

            consoleHeight = Console.WindowHeight;
            consoleWidth = Console.WindowWidth;
            Console.WriteLine("Введите название города в котором живете");
            City = Console.ReadLine();
            Console.WriteLine("Введите ФИО, которое хотите отобразить");
            FIO = Console.ReadLine();

            // рассчет стартовых координат вывода первой строки сообщения
            xStart = (consoleWidth - FIO.Length) / 2;
            yStart = consoleHeight / 2;
            consoleWidth = Convert.ToInt32(Math.Floor(xStart));
            consoleHeight = Convert.ToInt32(yStart) - 1;
            
            PrintMsg(consoleWidth, consoleHeight, FIO); // вывод первой строки сообщения

            // рассчет стартовых координат вывода второй строчки сообщения
            consoleWidth = Console.WindowWidth;
            xStart = (consoleWidth - City.Length) / 2;
            consoleWidth = Convert.ToInt32(Math.Floor(xStart));
            consoleHeight = consoleHeight + 1;

            PrintMsg(consoleWidth, consoleHeight, City); // вывод второй строки сообщения

            /*
            *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
            */



            Console.ReadKey();
        }
    }
}
