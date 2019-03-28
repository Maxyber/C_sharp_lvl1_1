using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxyClass
{
    public class Maxyber
    {
        // ставит консоль на ожидание нажатия клавиши
        static public void ConsolePause()
        {
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
        // выводит сообщение str и ждет нажатия клавиши
        static public void ConsolePrint(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public int AskInteger()
        {
            int result;
            string str;
            bool flag;
            do
            {
                str = Console.ReadLine();
                flag = int.TryParse(str, out result);
            } while (flag != true);
            return result;
        }
        // ищет минимальное число среди массива чисел
        static public int minNumber(int[] nums)
        {
            int min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min) min = nums[i];
            }
            return min;
        }
        // запрашивает у пользователя ввести определенное целое число
        // в дальнейшем расширить действие метода на получение любых данных
        static public long ConsoleRequestNumber(string str)
        {
            Console.Write(str);
            long result = Convert.ToInt64(Console.ReadLine());
            return result;
        }
        // считает сумму цифр целого числа
        // в дальнейшем расширить действие метода на сумму цифр любого числа
        static public long CalcNumberChars(long number)
        {
            long result = 0;
            if (number < 0) number = 0 - number;
            while (number != 0)
            {
                result = result + number % 10;
                number = number / 10;
            }
            return result;
        }
        // метод запрашивает у пользователя любое количество целых чисел и записывает их в массив до тех пор, пока не был введет 0
        static public int[] InputIntArray()
        {
            Console.Clear();
            Console.WriteLine("Введите любое количество целых чисел массива, но не менее одного числа.");
            Console.WriteLine("Для выхода из интерфейса наберите 0. В случае ошибки повторите правильный ввод");
            int[] arr = new int[0];
            int i = 0, x;
            do
            {
                x = AskInteger();
                Console.Write("Число " + x + " принято. Следующее число: ");
                if (x != 0)
                {
                    i++;
                    Array.Resize<int>(ref arr, i);
                    arr[i - 1] = x;
                }
            } while (x != 0);
                return arr;

        }
        // метод выводит на экран целочисленный массив любой длины
        static public void ConsolePrintArray(int[] arr)
        {
            Console.Clear();
            Console.Write("Массив: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("конец массива.");
        }
        // метод считаем сумму нечетных положительных чисел массива
        static public void SummArray(int[] arr)
        {
            long sum = 0;
            foreach (int i in arr)
            {
                if ((i > 0) && (i % 2 != 0))
                {
                    sum = sum + i;
                }
            }
            ConsolePrint("Сумма положительных нечетных чисел массива: " + sum);
        }
        // метод проверяет сочетание логин/пароль и возвращает значение true или false
        static public bool UserLogPassCheck()
        {
            Console.WriteLine("Введите логин: ");
            string userLogin = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            string userPassword = Console.ReadLine();
            if (userLogin == "root" && userPassword == "GeekBrains") return true;
            else return false;
        }
        // метод ограничивает количество неверных попыток введения пароля значением i
        static public void UserLogPassTry(int i)
        {
            int count = 0;
            do
            {
                count++;
                bool passCheck = UserLogPassCheck();
                if (passCheck == true)
                {
                    ConsolePrint("Пароль принят, приятной работы.");
                    break;
                }
                else
                {
                    Console.WriteLine("Введена неверная комбинация логина и пароля, повторите попытку.");
                    if (count == i)
                    {
                        ConsolePrint($"Вы ввели неверную комбинацию логина и пароля {i} раз, доступ заблокирован.");
                    }
                }
            } while (count < i);
        }
        // метод считает индекс массы тела и, в случае необходимости, дает рекомендации по набору веса или его уменьшению
        static public double CalcIMT()
        {
            // string[] userArray = Maxyber.AskAnketa({ "Введите свой рост: ", "Введите свой вес: "}); раскомментировать функцию после доделки метода AskAnketa
            Console.Write("Введите свой рост в сантиметрах: ");
            double userHeight = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Введите свой вес в килограммах: ");
            int userWeight = Convert.ToInt32(Console.ReadLine());
            // double IMT = userArray[1] / (userArray[0] * userArray[0]); раскоментировать строку после доделки метода AskAnketa
            double userIMT = userWeight / (userHeight * userHeight);
            // добавить вызов функции проверки нормальности ИМТ
            double weightCorrection = 0;
            if (userIMT > 24.99)
            {
                weightCorrection = Math.Round(100 * (userWeight - (24.99 * userHeight * userHeight))) / 100;
                ConsolePrint("У вас избыточный вес, для приведения веса в норму необходимо похудеть не менее чем на " + weightCorrection + " килограммов");
            }
            else if (userIMT < 18.5)
            {
                weightCorrection = Math.Round(100 * ((18.5 * userHeight * userHeight) - userWeight)) / 100;
                ConsolePrint("У вас недостаток веса, для приведения этого показателя в норму необходимо набрать не менее " + weightCorrection + " килограммов");
            }
            else
            {
                ConsolePrint("Ваш вес в норме, корректировки не требуются.");
            }
            return userIMT;
        }
        // метод подсчета суммы "хороших" чисел, тех, которые делятся на сумму своих цифр без остатка
        static public int CalcGoodNumbers(long maxLine)
        {
            Console.Clear();
            DateTime dStart = DateTime.Now; // запуск таймера для засечки времени
            int count = 0; // счетчик количества "хороших" чисел
            long sumNumbers = 0; // сумма всех цифр числа
            long number = 0; // временная переменная для расчета суммы всех цифр числа
            for (long i = 1; i <= maxLine; i++)
            {
                number = i;
                sumNumbers = 0;
                
                if ((maxLine > 100000) && (i % (maxLine/1000) == 0)) // добавляем счетчик процентов выполнения программы
                {
                    Console.SetCursorPosition(0, 0);
                    double percentage = (i * 100) / maxLine;
                    Console.Write("Ход выполнения программы " + percentage + "%");
                }
                
                do // считаем сумму всех цифр числа и проверяем является ли это число "хорошим"
                {
                    sumNumbers = sumNumbers + number % 10;
                    number = number / 10;
                }
                while (number != 0);
                if (i % sumNumbers == 0)
                {
                    count = count + 1;
                }
            }
            Console.Clear();
            DateTime dFinish = DateTime.Now; // остановка таймера засечки времени
            Console.WriteLine("Время выполнения метода подсчета хороших чисел составило: " + (dFinish - dStart));
            return count;
        }
        // рекурсивный метод вывода на экран всех чисел от a до b
        static public string RecursionNumbers(int a, int b)
        {
            if (a < b) return a + " " + RecursionNumbers((a + 1), b);
            else if (a > b) return a + " " + RecursionNumbers((a - 1), b);
            else if (a == b) return a + " ";
            return a + " ";
        }
        // рекурсивный метод вывода на экран суммы всех чисел от a до b
        static public int RecursionSumNumbers(int a, int b)
        {
            if (a < b) return a + RecursionSumNumbers(a + 1, b);
            else if (a > b) return a + RecursionSumNumbers(a - 1, b);
            else if (a == b) return a;
            return a;
        }
        // метод запроса двух чисел для интервала, используемого в рекурсивной функции
        static public int[] AskRecursiveNums()
        {
            int[] arr = new int[2];
            Console.Clear();
            Console.Write("Введите первое целое число для рекурсивного метода: ");
            arr[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число для рекурсивного метода: ");
            arr[1] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return arr;
        }

        // НЕ ДОДЕЛАНО!!! метод, запрашивающий у пользователя любое количество данных с вопросами, заданными во входящем массиве arr и возвращающим массив ответов arrResult
        static public string[] AskAnketa(string[] arr)
        {
            // доделать функцию, которая запрашивает у пользователя любые данные
            // на входе функция получает из запроса массив string[i], содержащий запросы на определенные данные
            // на выходе функция выдает массив string[i], содержащий ответы пользователя на вопросы
            string[] arrResult = new string[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                arrResult[i] = Console.ReadLine();
            }

            return arrResult;
        }
    }
}
