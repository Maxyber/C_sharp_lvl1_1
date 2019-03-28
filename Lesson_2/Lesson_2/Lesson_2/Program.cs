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
            
            // Задание №4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
            Console.Clear();
            Maxyber.UserLogPassTry(3);

            // задание №3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

            int[] NumArray = Maxyber.InputIntArray(); // вызывает мето заполнения массива числами, введенными с клавиатуры
            Maxyber.SummArray(NumArray); // вызывает метод подсчета суммы положительных нечетных чисел

            // задание №1. Написать метод, возвращающий минимальное из трёх чисел.
            // int[] nums = new int[4] { 20, 30, 10, 40 }; изначально в задании необходимо было найти минимальное число из чисел известного массива, задача была расширена после выполнения задания №3
            int min = Maxyber.minNumber(NumArray);
            Maxyber.ConsolePrint("Минимальное число в введенном ранее массиве: " + min);

            // задание №2. Написать метод подсчета количества цифр числа.
            Console.Clear();
            long number = Maxyber.ConsoleRequestNumber("Введите любое целое число: ");
            long result = Maxyber.CalcNumberChars(number);
            Maxyber.ConsolePrint("сумма цифр числа: " + result);

            // Задание №5.  а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //              б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса. Нормой ИМТ считается интервал от 18,5 до 24,99.
            Console.Clear();
            double userIMT = Maxyber.CalcIMT(); // вызов функции рассчета индекса массы тела
            Maxyber.ConsolePrint("Индекс массы тела: " + userIMT);

            // Задание №6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. 
            // Реализовать подсчет времени выполнения программы, используя структуру DateTime.
            Console.Clear();
            Console.WriteLine("Максимальная граница диапазона, в котором считать количество \"хороших\" числел: ");
            long maxGoodNumsLine = Convert.ToInt64(Console.ReadLine());
            int countGoodNums = Maxyber.CalcGoodNumbers(maxGoodNumsLine);
            Maxyber.ConsolePrint("Количество \"хороших\" чисел в интервале от 1 до " + maxGoodNumsLine + " равно - " + countGoodNums);
            
            // Задание №7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
            // б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            int[] userNums = new int[2];
            userNums = Maxyber.AskRecursiveNums();
            Console.WriteLine("Числовой ряд от " + userNums[0] + " до " + userNums[1]);
            Console.WriteLine(Maxyber.RecursionNumbers(userNums[0], userNums[1]));
            Console.WriteLine("Сумма чисел от " + userNums[0] + " до " + userNums[1]);
            Console.WriteLine(Maxyber.RecursionSumNumbers(userNums[0], userNums[1]));
            Maxyber.ConsolePause();
        }
    }
}
