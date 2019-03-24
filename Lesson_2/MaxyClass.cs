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
            Console.ReadKey();
        }
        // выводит сообщение str и ждет нажатия клавиши
        static public void ConsolePrint(string str)
        {
            Console.WriteLine(str);
            Console.ReadKey();
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
        static public long ConsoleRequestNumber(string str)
        {
            Console.Write(str);
            long result = Convert.ToInt64(Console.ReadLine());
            return result;
        }
        static public long CalcNumberChars(long number)
        {
            long result = 0;
            while ((number % 10) > 0)
            {
                result = result + number % 10;
                number = number / 10;
            }
            return result;
        }
        static public int[] InputIntArray()
        {
            int[] arr = new int[0];
            int i = 0;
            int str = Convert.ToInt32(Console.ReadLine());
            while (str != 0)
            {
                i++;
                Array.Resize<int>(ref arr, i);
                arr[i - 1] = str;
                str = Convert.ToInt32(Console.ReadLine());
            }
            return arr;

        }
        static public void ConsolePrintArray(int[] arr)
        {
            Console.Write("Массив: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("конец массива.");
        }
        static public long SummArray(int[] arr)
        {
            long sum = 0;
            foreach (int i in arr)
            {
                if ((i > 0) && (i % 2 != 0))
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        static public bool UserLogPassCheck()
        {
            Console.WriteLine("Введите логин: ");
            string userLogin = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            string userPassword = Console.ReadLine();
            if (userLogin == "root" && userPassword == "GeekBrains") return true;
            else return false;
        }
        static public void UserLogPassTry(int i)
        {
            int count = 0;
            do
            {
                count++;
                bool passCheck = Maxyber.UserLogPassCheck();
                if (passCheck == true)
                {
                    Maxyber.ConsolePrint("Пароль принят, приятной работы.");
                    break;
                }
                else
                {
                    Console.WriteLine("Введена неверная комбинация логина и пароля, повторите попытку.");
                    if (count == i)
                    {
                        Maxyber.ConsolePrint($"Вы ввели неверную комбинацию логина и пароля {i} раз, доступ заблокирован.");
                    }
                }
            } while (count < i);
        }
        static public double calcIMT()
        {
            int[] userArray = Maxyber.AskAnketa({"Введите свой рост: ", "Введите свой вес: "});
            double IMT = int[1] / (int[0] * int[0]);
            return IMT;
        }
        static public void AskAnketa(string[] arr)
        {

        }
    }
}
