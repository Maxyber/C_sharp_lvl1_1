using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxyClass;

namespace Lesson_2
{
    class Program
    {
        // int temp = new Random().Next(5);
        static void Main(string[] args)
        {
            /*
                    // задание №1. Написать метод, возвращающий минимальное из трёх чисел.
                    int[] nums = new int[4] { 20, 30, 10, 40 };
                    int min = Maxyber.minNumber(nums);
                    Maxyber.ConsolePrint("minimum number: " + min);

                    // задание №2. Написать метод подсчета количества цифр числа.
                    Console.Clear();
                    long number = Maxyber.ConsoleRequestNumber("Введите любое число: ");
                    long result = Maxyber.CalcNumberChars(number);
                    Maxyber.ConsolePrint("сумма цифр числа: " + result);
            
            // задание №3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            Console.Clear();
            Console.WriteLine("Введите любое количество чисел, для выхода из интерфейса ввода наберите 0.");
            int[] NumArray = Maxyber.InputIntArray();

            long sum = Maxyber.SummArray(NumArray); // вызывает метод подсчета суммы положительных нечетных чисел
            Maxyber.ConsolePrint("Сумма положительных нечетных чисел массива: " + sum);
            //  Maxyber.ConsolePrintArray(NumArray); // метод вывода на экран числового массива
            
            // Задание №4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
            Console.Clear();
            Maxyber.UserLogPassTry(3);
            
            // Задание №5.  а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //              б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса. Нормой ИМТ считается интервал от 18,5 до 24,99.
            Console.Clear();
            double userIMT = Maxyber.CalcIMT(); // вызов функции рассчета индекса массы тела
            Maxyber.ConsolePrint("Индекс массы тела: " + userIMT);
            */

            // Задание №6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. 
            // Реализовать подсчет времени выполнения программы, используя структуру DateTime.

            Console.Write("Максимальная граница диапазона, в котором считать количество \"хороших\" числел: ");
            long maxGoodNumsLine = Convert.ToInt64(Console.ReadLine());
            int countGoodNums = Maxyber.CalcGoodNumbers(maxGoodNumsLine);
            Maxyber.ConsolePrint("Количество \"хороших\" чисел в интервале от 1 до " + maxGoodNumsLine + " равно - " + countGoodNums);

            // Console.ReadKey();
        }
    }
}
