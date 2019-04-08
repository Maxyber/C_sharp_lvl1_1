using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxyClass;
using System.IO;

namespace Lesson_6
{
    class Program
    {
        public delegate double Fun(double x, double y);

        static void Main(string[] args)
        {
            //Задание №1
            //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double(double, double).
            //Продемонстрировать работу на функции с функцией (a*x) ^ 2 и функцией a* sin(x).
            // Описываем делегат. В делегате описывается сигнатура методов, на которые он сможет ссылаться в дальнейшем (хранить в себе)
            /*
            Fun function = AskFunctionType();
            int[] vars = AskVars();
            ConstructTable(function, vars);
            
            //Задание №2
            //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
            //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
            //Использовать массив(или список) делегатов, в котором хранятся различные функции.
            //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр(с использованием модификатора out). 

            Fun[] funcArray = NewFuncArray();
            FunctionConstruct(funcArray);
            
            //Задание №3
            //Переделать программу Пример использования коллекций для решения следующих задач:
            //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
            //в) отсортировать список по возрасту студента;
            //г) *отсортировать список по курсу и возрасту студента;

            List<string[]> list = new List<string[]>();
            StudentsListCreate(ref list);
            StudentsListSort(ref list,5); // сортировка коллекции по возрастанию по указанному столбцу, применяется сравнение <>, столбец 5 - возраст
            StudentsListSort(ref list, 6); // сортировка коллекции по возрастанию по указанному столбцу, применяется сравнение <>, столбец 6 - курс
            Dictionary<string, int> freqDict = new Dictionary<string, int>();
            StudentsDictionaryPrint(ref freqDict, list);
            */
            //Задание №4
            //**Считайте файл различными способами.Смотрите “Пример записи файла различными способами”. 
            //Создайте методы, которые возвращают массив byte(FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.

            Maxyber.ConsolePause();
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
        public static double MyFuncSquare(double x, double y)
        {
            return Math.Sqrt(x) + Math.Sqrt(y);
        }
        // Метод построения таблицы с использованием значений из массива переменных
        public static void ConstructTable(Fun F, int[] vars)
        {
            PrintMessage($"Таблица выбранной вами функции f(x[{vars[0]},{vars[1]}],{vars[2]}):");
            Table(F, vars[0], vars[1], vars[2]);
        }
        // запрашиваем у пользователя три значения для построения функции и записываем в массив переменных
        public static int[] AskVars()
        {
            int[] funcVars = new int[3];
            do
            {
                PrintMessage("Введите две три переменных x (принимает значения от 1.а до 2.b {a < b}) и 3.y для построения таблицы функции вида f(x[a,b],y)");
                for (int i = 0; i < 3; i++) funcVars[i] = Maxyber.Ask(0);
            } while (funcVars[1] < funcVars[0]);
            return funcVars;
        }
        // запрашиваем у пользователя выбор одной из нескольких функций
        public static Fun AskFunctionType()
        {
            PrintMessage("Выберите (1 или 2) тип функции для вывода таблицы:\n1. (x*y)^2, \n2. Sqrt(x) + Sqrt(y), \n3.x * Sin(y)");
            string answer = AskAnswer();
            switch (answer)
            {
                case "1":
                    Fun result = new Fun(MyFuncPow);
                    return result;
                case "2":
                    result = new Fun(MyFuncSquare);
                    return result;
                case "3":
                    result = new Fun(MyFuncSin);
                    return result;
                default:
                    PrintMessage("Ошибка ввода, будет использоваться функция степени");
                    result = new Fun(MyFuncPow);
                    return result;
            }
        }
        // высчитываем минимум функции на интервале от а до b
        public static double FuncMinimum(Fun F, double a, double b, double y)
        {
            double res;
            int count = Convert.ToInt32(b - a);
            double[] array = new double[Convert.ToInt32(b - a)];
            res = F(a, y);
            a++;
            for (int i = 1; i < count; i++)
            {
                if (F(a, y) < res) res = F(a, y);
                a++;
            }
            return res;
        }
        // высчитываем максимум функции на интервале от а до b
        public static double FuncMaximum(Fun F, double a, double b, double y)
        {
            double res;
            int count = Convert.ToInt32(b - a);
            double[] array = new double[Convert.ToInt32(b - a)];
            res = F(a, y);
            a++;
            for (int i = 1; i < count; i++)
            {
                if (F(a, y) > res) res = F(a, y);
                a++;
            }
            return res;
        }
        // Создаем массив функций
        public static Fun[] NewFuncArray()
        {
            Fun[] funcArray = new Fun[3];
            funcArray[0] = new Fun(MyFuncPow);
            funcArray[1] = new Fun(MyFuncSquare);
            funcArray[2] = new Fun(MyFuncSin);
            return funcArray;
        }
        // запрашиваем у пользователя данные для построения таблицы функции
        public static void FunctionConstruct(Fun[] funcArray)
        {
            PrintMessage("Выберите функцию для определения минимума: \n1. (x*y)^2, \n2. Sqrt(x) + Sqrt(y), \n3.x * Sin(y)");
            int i = Maxyber.Ask(0);
            PrintMessage("Введите последовательно числа a, b, y, где a и b - границы интервала функции, а y - любое число");
            double a = Maxyber.Ask(0.1);
            double b = Maxyber.Ask(0.1);
            double y = Maxyber.Ask(0.1);
            double min = FuncMinimum(funcArray[i - 1], a, b, y);
            if (funcArray.Length > i - 1)
            {
                Table(funcArray[i - 1], a, b, y);
                PrintMessage($"Минимум функции на интервале от {a} до {b} составляет: {min}");
                Save("data/data.bin", funcArray[i - 1], a, b, y);
                double[][] aray = Load("data/data.bin");
            }
            else PrintMessage("Неведомая ошибка");
        }
        // записываем результат работы функции в бинарный файл
        static void Save(string fileName, Fun F, double a, double b, double y)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; a + i <= b; i++)
            {
                double res = F(a + i, y);
                bw.Write(a + i);
                bw.Write(res);
            }
            fs.Close();
            bw.Close();
        }
        // загружаем результат работы функции из бинарного файла в массив
        static double[][] Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            double[][] result = new double[fs.Length / 16][]; // double занимает 8 байт, но в файле одному элементу соответствует два числа double
            for (int i = 0; i < result.Length; i++) result[i] = new double[2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i][0] = br.ReadDouble();
                result[i][1] = br.ReadDouble();
                PrintMessage($"{result[i][0],6:0.000} {result[i][1]:0.000}");
            }
            br.Close();
            fs.Close();
            return result;
        }
        static public void StudentsListCreate(ref List<string[]> list)
        {
            int sixYearStudents = 0;
            int fiveYearStudents = 0;
            StringBuilder sb = new StringBuilder();
            // Создадим необобщенный список

            // Запомним время в начале обработки данных
            StreamReader sr = new StreamReader("data/students.csv", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    /*
                    // формирование строки и вывод на печать массива для проверки работы программы
                    for (int i = 0; i < s.Length; i++) sb.Append(s[i] + " ... ");
                    PrintMessage(sb.ToString());
                    // конец вывода на печать
                    */
                    list.Add(s);// Добавляем в список массив данных студента, имеем список list, состоящий из объектов string[]
                    if (int.Parse(s[6]) == 6) sixYearStudents++;
                    else if (int.Parse(s[6]) == 5) fiveYearStudents++;
                }
                catch
                {
                    PrintMessage("Неведомая ошибка");
                }
            }
            sr.Close();
            PrintMessage($"Всего студентов: {list.Count}");
            PrintMessage($"4 курс: {fiveYearStudents}");
            PrintMessage($"5 курс: {sixYearStudents}");
        }
        static public void StudentsListSort(ref List<string[]> list, int col)
        {
            string[] svar = new string[list[0].Length];
            for (int j = 0; j < list.Count - 2; j++)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    svar = list[i];
                    if (int.Parse(list[i + 1][col]) < int.Parse(list[i][col]))
                    {
                        list.Insert(i, list[i + 1]);
                        list.Insert(i + 1, svar);
                        list.RemoveAt(i + 2);
                        list.RemoveAt(i + 2);
                    }
                }
            }
        }
        static public void StudentsDictionaryPrint(ref Dictionary<string, int> freqDict, List<string[]> list)
        {
            //Создаем частотный массив состоящий из таблицы 3 * х, где х - количество доступных комбинаций возраст + курс
            int course, age;

            // для каждого элемента списка студентов обрабатываем вхождение в словарь
            foreach (var v in list)
            {
                int.TryParse(v[5], out age);
                int.TryParse(v[6], out course);
                if ((age >= 18) && (age <= 20))
                {
                    if (freqDict.ContainsKey(age + "|" + course)) freqDict[age + "|" + course]++;
                    else freqDict.Add(age + "|" + course, 1);
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, int> s in freqDict)
            {
                string[] sA = s.Key.Split('|');
                sb.Append($"Возраст: {sA[0]} лет. Курс: {sA[1]}. Количество студентов: {s.Value}\n");
            }
            PrintMessage(sb.ToString());
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
