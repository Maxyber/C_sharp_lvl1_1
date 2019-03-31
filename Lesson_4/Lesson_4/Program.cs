using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // для ввода-вывода информации в файлы
using MaxyClass;
using Lesson_4_StaticClass;

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

            MassiveClass userMassive = new MassiveClass();
            userMassive.Fill(20, -10000, 10000);
            userMassive.Print();
            int pairs = MassiveClass.Pair(userMassive, 2);
            MassiveClass fileMassive = new MassiveClass();
            fileMassive = MassiveClass.ReadFile("data/arrayspec.txt");
            fileMassive.Print();
            
            // Задание №3. а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и заполняющий массив 
            //числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, 
            // метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),  
            // метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
            // б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
            // е) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)

            MassiveClass newMassive = new MassiveClass();
            newMassive.FillOrder(30, 1, 3); // заполнение массива числами в количестве 30 элементов от 1 с шагом 3
            newMassive.Print();
            Console.WriteLine("Сумма элементов массива: " + newMassive.Sum());
            MassiveClass new2Massive = new MassiveClass();
            new2Massive = newMassive.Inverse();
            new2Massive.Print();
            Console.WriteLine("Сумма элементов массива: " + new2Massive.Sum());
            new2Massive.Multi(-1);
            new2Massive.Print();
            Console.WriteLine("Количество максимальных элементов массива new2Massive:" + new2Massive.MaxCount());
            MassiveClass fileMassive = new MassiveClass();
            fileMassive = MassiveClass.ReadFile("data/arrayspec.txt");
            Console.WriteLine("Количество максимальных элементов массива fileMassive:" + fileMassive.MaxCount());
            
            MassiveClass userMassive = new MassiveClass();
            userMassive.Fill(200, 1, 10);
            userMassive.Print();
            Dictionary(userMassive);

            // Задание №4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account, содержащую Login и Password.



            // Задание №5. а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.
            // Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, 
            // возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер 
            // максимального элемента массива(через параметры, используя модификатор ref или out).
            // **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
            // ***в) Обработать возможные исключительные ситуации при работе с файлами.


            Maxyber.ConsolePause();
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
            Console.WriteLine("Всего пар, отвечающих условию, что только одно из двух чисел делится на 3 без остатка: ");
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
    }
}
