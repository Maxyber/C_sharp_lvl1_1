using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // для ввода-вывода информации в файлы
using MaxyClass;
using Lesson_4_StaticClass;
using TwoDimensionArray;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание №1. Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
            // Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
            // В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
            
            Massive();

            // Задание №2. Реализуйте задачу 1 в виде статического класса StaticClass;
            // а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            // б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
            // в)**Добавьте обработку ситуации отсутствия файла на диске.

            // Задание №3. а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и заполняющий массив 
            //числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, 
            // метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),  
            // метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
            // б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
            // е) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)

            ClassArrayDemo();

            // Задание №4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account, содержащую Login и Password.

            Account account = new Account();
            account.ReadFile("../../data/login.txt", ref account);
            if (account.Check(account) == true) Maxyber.ConsolePrint("Пароль принят.");
            else Maxyber.ConsolePrint("Пароль введен неверно");
            Maxyber.ConsolePrint("Считали логин, пароль и название аккаунта из файла data/login.txt и предложили пользователю пройти проверку");
            Console.Clear();

            // Задание №5. а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.
            // Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, 
            // возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер 
            // максимального элемента массива(через параметры, используя модификатор ref или out).
            // **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
            // ***в) Обработать возможные исключительные ситуации при работе с файлами.

            TDArrayDemo();

            Maxyber.ConsolePrint("Домашнее задание полностью выполнено");
        }
        static public void Massive()
        {
            int[] intArray = new int[20];
            intArray = Maxyber.RandArray(-10000, 10000, 20); // создание массива случайных чисел
            Maxyber.ConsolePrintArray(intArray); // вывод массива случайных чисел на экран

            int pairCount = 0;
            for (int i = 0; i < intArray.Length - 2; i++)
            {
                if (((intArray[i] % 3 == 0) || (intArray[i + 1] % 3 == 0)) && ((intArray[i] % 3) != (intArray[i+1])))
                {
                    pairCount++;
                    Console.WriteLine("Пара чисел " + intArray[i] + " и " + intArray[i + 1] + " удовлетворяет условию.");
                }
            }
            Maxyber.ConsolePrint("Всего пар, отвечающих условию, что только одно из двух чисел делится на 3 без остатка: " + pairCount);
            Console.Clear();
        }
        static public void Dictionary(MassiveClass arr)
        {
            int x;
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i=0; i < arr.GetIndex(); i++)
            {
                try
                {
                    numbers.Add(arr.Get(i), 1);
                }
                catch (ArgumentException)
                {
                    numbers.TryGetValue(arr.Get(i), out x);
                    numbers.Remove(arr.Get(i));
                    numbers.Add(arr.Get(i), x+1);
                }
            }

            foreach (KeyValuePair<int, int> kvp in numbers)
            {
                Console.WriteLine($"Key = {kvp.Key}, Value = {kvp.Value}");
            }
        }
        static public int SumAll(TDArray array)
        {
            int sum = 0;
            for (int x = 0; x < array.GetXDim; x++)
                for (int y = 0; y < array.GetYDim; y++)
                    sum = sum + array.Get(x, y);
            return sum;
        }
        static public void ClassArrayDemo()
        {
            MassiveClass userMassive = new MassiveClass();
            userMassive.Fill(20, -10000, 10000);
            userMassive.Print();
            Maxyber.ConsolePrint("Массив заполненный случайными числами через метод класса массивов, 20 элементов от -10 000 до 10 000");
            int pairs = MassiveClass.Pair(userMassive, 2);
            Maxyber.ConsolePrint("Количество пар в массиве, одно из чисел в которых делится на 3 без остатка");
            Console.Clear();
            MassiveClass arrayFileMassive = new MassiveClass();
            arrayFileMassive = MassiveClass.ReadFile("../../data/arrayspec.txt");
            arrayFileMassive.Print();
            Maxyber.ConsolePrint("Заполнили массив из файла data/arrayspec.txt и вывели на экран консоли");
            Console.Clear();
            // Задача №3
            MassiveClass newMassive = new MassiveClass();
            newMassive.FillOrder(30, 1, 3); // заполнение массива числами в количестве 30 элементов от 1 с шагом 3
            newMassive.Print();
            Console.WriteLine("Сумма элементов массива: " + newMassive.Sum());
            Maxyber.ConsolePrint("Заполнили массив количеством 30 элементов с началом 1 и шагом 3, далее вывели его на печать и посчитали сумму элементов массива");
            MassiveClass new2Massive = new MassiveClass();
            new2Massive = newMassive.Inverse();
            new2Massive.Print();
            Console.WriteLine("Сумма элементов массива: " + new2Massive.Sum());
            Maxyber.ConsolePrint("Инвертировали предыдущий массив и вывели его на печать, посчитав сумму всех лементов");
            new2Massive.Multi(-1);
            new2Massive.Print();
            Maxyber.ConsolePrint("Умножили все элементы последнего массива на -1 и вывели его на печать");
            Console.Clear();
            MassiveClass new3Massive = new MassiveClass();
            new3Massive.Fill(50, 1, 11);
            new3Massive.Print();
            Console.WriteLine("Количество максимальных элементов массива:" + new3Massive.MaxCount());
            Maxyber.ConsolePrint("Заполнили массив количеством 50 элементов случайными числами от 1 до 10, далее вывели количество максимальных значений в нем");
            Console.Clear();
            MassiveClass userMassiveDict = new MassiveClass();
            userMassiveDict.Fill(200, 1, 10);
            userMassiveDict.Print();
            Dictionary(userMassiveDict);
            Maxyber.ConsolePrint("Заполнили массив количеством 200 элементов случайными числами от 1 до 10, после чего вывели его на экран и создали словарь<int><int>, " +
    "который содержит информацию о том, сколько раз входит в массив каждый из элементов");
            Console.Clear();
        }
        static public void TDArrayDemo()
        {
            TDArray myArray = new TDArray();
            myArray.Fill(10, 10, 1, 1000);
            myArray.Print();
            Maxyber.ConsolePrint("Заполнили двумерный массив размерностью 10 на 10 случайными числами от 1 до 999, вывели на печать.");
            int sum = SumAll(myArray);
            Console.WriteLine($"Array summ: {sum}");
            Console.WriteLine($"MinValue: {myArray.MinValue("Value")}, MinValue coordinates: {myArray.MinValue("Coord")}");
            Console.WriteLine($"MaxValue: {myArray.MaxValue("Value")}, MaxValue coordinates: {myArray.MaxValue("Coord")}");
            Maxyber.ConsolePrint("Посчитали сумму всех элементов массива, значение и координаты минимального и максимального элемента массива");
            Console.Clear();
            TDArray my2Array = new TDArray();
            string path = "../../data/tdarray.txt";
            my2Array.ReadFromFile(path);
            Maxyber.ConsolePrint("Считали двумерный массив из файла data/tdarray.txt, в случае отсутствия файла программа сообщит об этом и остановит выполнение");
            Console.Clear();
            string path2 = "../../data/tdarrayrw.txt";
            my2Array.WriteToFile(path2);
            Maxyber.ConsolePrint("Записали двумерный массив в файл data/tdarrayrw.txt, в случае, если файл уже есть предлагается его перезаписать или сразу выйти из программы");
            Console.Clear();
        }
    }
}
