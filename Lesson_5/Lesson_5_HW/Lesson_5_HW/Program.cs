using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MaxyClass;
using MessageClass;
using System.IO;

namespace Lesson_5_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задача №1. Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, 
            //содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            //а) без использования регулярных выражений;
            //б) **с использованием регулярных выражений.
            
            AskCorrectLogin();

            //Задача №2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            //а) Вывести только те слова сообщения,  которые содержат не более n букв.
            //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            //в) Найти самое длинное слово сообщения.
            //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            //д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, 
            //  в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.

            MessageProgram();

            //Задача №3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            //Например:
            //badc являются перестановкой abcd.

            Exchanging();

            //Задача №4. *Задача ЕГЭ.
            //На вход программе подаются сведения о сдаче экзаменов учениками 9 - х классов некоторой средней школы. В первой строке сообщается количество учеников N, 
            //которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
            //< Фамилия > < Имя > < оценки >,
            //где < Фамилия > — строка, состоящая не более чем из 20 символов, < Имя > — строка, состоящая не более чем из 15 символов, < оценки > — 
            //через пробел три целых числа, соответствующие оценкам по пятибалльной системе. < Фамилия > и<Имя>, а также<Имя> и<оценки> разделены одним пробелом. Пример входной строки:
            //Иванов Петр 4 5 3
            //Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
            //Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.

            StudentListAnalyse();

            Maxyber.ConsolePause();
        }
        // метод задачи №2
        static public void MessageProgram()
        {
            Console.Write("Введите текстовое сообщение с любым количеством слов: ");
            // Message msg = new Message("лето солнце тесто жара чай снег осень зима");
            Message msg = new Message(Console.ReadLine()); // создаем объект Message
            Console.WriteLine("Вы ввели сообщение: " + msg.ToString());
            Console.Write("Введите максимальное количество букв из которых должно состоять слово: ");
            int count = Maxyber.Ask(0); // запрашиваем число букв
            msg.PrintWords(count);
            Console.Write("Введите символ, на который заканчиваются слова для удаления: ");
            char uChar = Maxyber.Ask(' '); // запрашиваем символ, на которое заканчивается слово
            msg.WordDeleteLC(uChar); // удаляем слова из последовательности
            msg.Print();
            Console.WriteLine($"Самое длинное слово сообщения - \"{msg.Longest()}\", его длина {msg.Longest().Length} символов");
            StringBuilder sb = new StringBuilder();
            sb = msg.SBLongest(); // формируем последовательность из самых длинных слов с помощью StrinBuilder
            Console.WriteLine("Строка StrinBuilder: " + sb.ToString());
            Maxyber.ConsolePause();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] uWords = { "солнце", "небо", "луна" }; // задаем массив слов, по которым необходимо создать частотный массив
            string uText = "Солнце взошло утром, небо было чистое, луна ушла вниз к земле, солнце никак не хотело двигаться, небо покрылось облаками, а луна была одинока, солнце - это наше все";
            dict = FreqAnalise(uWords, uText);

            foreach (KeyValuePair<string, int> key in dict)
            {
                Console.WriteLine(key.ToString());
            }
            Maxyber.ConsolePause();
        }
        // метод, запрашивающий у пользователя логин по определенным требованиям
        static public string AskCorrectLogin()
        {
            string login;
            Console.WriteLine("Введите логин. Требования к логину: от 2 до 10 символов, латинские символы от a до Z, либо цифры, причем цифра не может стоять первой.");
            do
            {
                login = Console.ReadLine();
                if (CheckLoginReg(login) == true) // CheckLogin или CheckLoginReg
                    return login;
                else
                {
                    Console.WriteLine("Неверный ввод логина, от 2 до 10 символов, принимаются только латинские символы от a до Z, либо цифры, причем цифра не может стоять первой.");
                }
            } while (CheckLoginReg(login) != true);
            return "";
        }
        static public bool CheckLogin(string login) // обычная проверка корректности ввода логиина
        {
            bool flag = true;
            if (((login[0] < 'a') || (login[0] > 'z')) && ((login[0] < 'A') || (login[0] > 'Z')))
                flag = false;
            foreach (char item in login)
            {
                if (((item < 'a') || (item > 'z')) && ((item < 'A') || (item > 'Z')) && ((item < '0') || (item > '9')))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        // задача на перестаноку
        public static void Exchanging()
        {
            bool flag = true;
            int x;
            Console.WriteLine("введите последовательно две строки");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Строки имеют разную длину и не могут быть перестановкой");
            }
            else
            {
                // создаем по одному словарю для каждой строки
                Dictionary<char, int> dict1 = new Dictionary<char, int>();
                Dictionary<char, int> dict2 = new Dictionary<char, int>();
                dict1 = MakeStrDictionary(str1);
                dict2 = MakeStrDictionary(str2);
                foreach (KeyValuePair<char, int> key in dict1)
                {
                    dict2.TryGetValue(key.Key, out x);
                    if (!dict2.ContainsKey(key.Key))
                    {
                        Console.WriteLine("В словаре 1 найден символ, которого нет в словаре 2. Строки не являются перестановкой");
                        flag = false;
                        break;
                    }
                    else if (key.Value != x)
                    {
                        Console.WriteLine($"Количество вхождений символа {key.Key} в словарях 1 и 2 различается ({key.Value} и {x})");
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine($"Строки \"{str1}\" и \"{str2}\" являются перестановкой");
                }
            }
            Maxyber.ConsolePause();
        }
        static public bool CheckLoginReg(string login) // проверка корректности ввода логина через регулярные выражения
        {
            Regex pattern = new Regex(@"^[a-zA-Z]{1}[a-zA-Z0-9]{1,9}$");
            bool flag = false;
            flag = pattern.IsMatch(login);
            return flag;
        }
        static public void StudentListAnalyse()
        {
            string path = "data/students.txt";
            string temp = Maxyber.FileToString(path);
            int count = int.Parse(temp.Split('\n')[0]);
            Students[] studentList = new Students[count];
            for (int i = 0; i < studentList.Length; i++) studentList[i] = new Students();
            studentList = Students.ReadScoreFile(path);
            double[] middles = new double[count];
            double middle1 = 10, middle2 = 10, middle3 = 10; // объявляем переменные для трех минимальных средних
            for (int i = 0; i < count; i++) // заполняем массив средних баллов студентов
            {
                double mid = double.Parse(studentList[i].Get("middle"));
                middles[i] = mid;
            }
            for (int i = 0; i < middles.Length; i++) // заполняем три минимальных средних оценки
            {
                if (middles[i] < middle1)
                {
                    middle3 = middle2;
                    middle2 = middle1;
                    middle1 = middles[i];
                    continue;
                }
                if ((middles[i] < middle2) && (middles[i] != middle1))
                {
                    middle3 = middle2;
                    middle2 = middles[i];
                    continue;
                }
                if ((middles[i] <= middle3) && (middles[i] != middle1) && (middles[i] != middle2))
                    middle3 = middles[i];
            }
            Console.WriteLine($"Минимальные средние баллы: {middle1:f3}, {middle2:f3}, {middle3:f3}");
            Console.WriteLine("");
            Console.WriteLine("Ученики, хуже всего написавшие ЕГЭ");
            StringBuilder result = new StringBuilder(); // создаем строку для вывода студентов с самыми плохими баллами
            int position = 0;
            for (int i = 0; i < studentList.Length; i++)
            {
                if (middle1 == double.Parse(studentList[i].Get("middle")))
                {
                    result.Insert(0, studentList[i].ToString() + "\r\n");
                    position = position + studentList[i].ToString().Length + 2;
                }
                if (middle2 == double.Parse(studentList[i].Get("middle"))) result.Insert(position, studentList[i].ToString() + "\r\n");
                if (middle3 == double.Parse(studentList[i].Get("middle"))) result.Append(studentList[i].ToString() + "\r\n");
            }
            Console.WriteLine(result.ToString());
        }
        // метод частотного анализа
        static public Dictionary<string, int> FreqAnalise(string[] words, string text)
        {
            int x;
            Dictionary<string, int> freqArray = new Dictionary<string, int>();
            // заполняем словарь по массиву слов
            for (int i = 0; i < words.Length; i++)
            {
                if (!freqArray.ContainsKey(words[i]))
                {
                    freqArray.Add(words[i], 0);
                }
            }
            // выполняем частотный анализ
            string[] strArr = text.Split(' ');
            for (int i = 0; i < strArr.Length; i++)
            {
                if (freqArray.ContainsKey(strArr[i]))
                {
                    freqArray.TryGetValue(strArr[i], out x);
                    freqArray[strArr[i]] = x + 1;
                }
            }
            return freqArray;
        }
        // создание частотного словаря символов для любой строки
        static public Dictionary<char, int> MakeStrDictionary(string str)
        {
            int x = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    dict.TryGetValue(str[i], out x);
                    dict[str[i]] = x + 1;
                }
                else
                {
                    dict.Add(str[i], 1);
                }
            }
            return dict;
        }
    }
    public class Students
    {
        string surname;
        string name;
        int score1;
        int score2;
        int score3;
        double middle;

        // логика
        public string Get(string str)
        {
            switch (str)
            {
                case "surname":
                    return surname;
                case "name":
                    return name;
                case "score1":
                    return score1.ToString();
                case "score2":
                    return score2.ToString();
                case "score3":
                    return score3.ToString();
                case "middle":
                    return middle.ToString();
                default:
                    return "Произошла неизвестная ошибка";
            }

        }
        // создание элемента Students на основе данных
        public void Add(string uName, string uSurname, int uScore1, int uScore2, int uScore3)
        {
            surname = uSurname;
            name = uName;
            score1 = uScore1;
            score2 = uScore2;
            score3 = uScore3;
            middle = (float)(uScore1 + uScore2 + uScore3) / 3;
        }
        public double Middle => (float)(score1 + score2 + score3) / 3;
        public override string ToString()
        {
            string res = $"Студент: {surname} {name} имеет оценки {score1}, {score2}, {score3} и средний балл {this.Middle:f3}";
            return res;
        }
        // интерфейс
        private void Print()
        {
            Console.WriteLine($"Студент: {surname} {name} имеет оценки {score1}, {score2}, {score3} и средний балл {middle:f3}");
        }

        // прочие методы
        // загрузка таблицы учащихся с баллами по ЕГЭ
        public static Students[] ReadScoreFile(string path)
        {
            string text = Maxyber.FileToString(path);
            string[] textArr = text.Split('\n');
            int.TryParse(textArr[0], out int x);
            Students[] studentList = new Students[x];

            for (int i = 0; i < studentList.Length; i++)
            {
                studentList[i] = new Students();
                string[] ta = new string[5];
                ta = textArr[i+1].Split(' ');
                studentList[i].Add(ta[0], ta[1], int.Parse(ta[2]), int.Parse(ta[3]), int.Parse(ta[4]));
                studentList[i].Print();
            }
            return studentList;
        }
    }
}
