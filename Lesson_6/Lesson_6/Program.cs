using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxyClass;

namespace Lesson_6
{
    class Program
    {
        public delegate double Fun(double x, double y);

        static void Main(string[] args)
        {
            //Задание №1
            //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double(double, double).
            //Продемонстрировать работу на функции с функцией a*x ^ 2 и функцией a* sin(x).
            // Описываем делегат. В делегате описывается сигнатура методов, на которые он сможет ссылаться в дальнейшем (хранить в себе)

            Fun function = AskFunctionType();
            int[] vars = AskVars();
            ConstructTable(function, vars);

            //Задание №2
            //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
            //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
            //Использовать массив(или список) делегатов, в котором хранятся различные функции.
            //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр(с использованием модификатора out). 



            //Задание №3
            //Переделать программу Пример использования коллекций для решения следующих задач:
            //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
            //в) отсортировать список по возрасту студента;
            //г) *отсортировать список по курсу и возрасту студента;



            //Задание №4
            //**Считайте файл различными способами.Смотрите “Пример записи файла различными способами”. 
            //Создайте методы, которые возвращают массив byte(FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.


        }
        // ЛОГИКА
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFuncPow(double x, double y)
        {
            return Math.Pow(x * y, 2);
        }
        public static double MyFuncSin(double x, double y)
        {
            return x * Math.Sin(y);
        }
        public static void ConstructTable(Fun F, int[] vars)
        {
            PrintMessage($"Таблица выбранной вами функции f(x[{vars[0]},{vars[1]}],{vars[2]}):");
            Table(F, vars[0], vars[1], vars[2]);
        }
        public static int[] AskVars() // запрашиваем у пользователя три переменных для построения функции
        {
            int[] funcVars = new int[3];
            do
            {
                PrintMessage("Введите две три переменных x (принимает значения от 1.а до 2.b {a < b}) и 3.y для построения таблицы функции вида f(x[a,b],y)");
                for (int i = 0; i < 3; i++) funcVars[i] = Maxyber.Ask(0);
            } while (funcVars[1] < funcVars[0]);
            return funcVars;
        }
        public static Fun AskFunctionType()
        {
            PrintMessage("Выберите (1 или 2) тип функции для вывода таблицы:\n1) a * x ^ 2;\n2) а * sin(x)");
            string answer = AskAnswer();
            switch (answer)
            {
                case "1":
                    Fun result = new Fun(MyFuncPow);
                    return result;
                case "2":
                    result = new Fun(MyFuncPow);
                    return result;
                default:
                    PrintMessage("Ошибка ввода, будет использоваться функция степени");
                    result = new Fun(MyFuncPow);
                    return result;
            }
        }
        // ИНТЕРФЕЙС
        public static string AskAnswer()
        {
            string answer = Console.ReadLine();
            return answer;
        }
        public static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b, double y)
        {
            Console.WriteLine("- X -------- Y -------- f(x,y) ---");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", x, y, F(x, y));
                x += 1;
            }
            Console.WriteLine("---------------------");
            Maxyber.ConsolePause();
        }

    }
}
