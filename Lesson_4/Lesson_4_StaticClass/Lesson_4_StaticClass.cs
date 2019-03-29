using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_StaticClass
{
    public class MassiveClass
    {
        int[] massive = new int[];
        int index;
        Random rnd = new Random();

        public void Print()
        {
            int length = massive.Length;
            Console.WriteLine("Массив состоит из " + length + " элементов");
            for (int i=0; i<length; i++)
            {
                Console.Write("{" + massive[i] +"}");
                if (i < length - 1) Console.Write(",");
            }
            Console.WriteLine("\nКонец массива.");
        }
        public void Fill(int length, int minValue = 0, int maxValue = 10)
        {
            
            for (int i = 0; i < length; i++)
            {
                massive[i] = rnd.Next(minValue,maxValue);
            }
        }
        public int Pair(int division=3)
        {
            int pairCount = 0;
            for (int i = 0; i < massive.Length - 2; i++)
            {
                if ((massive[i] % division == 0) || (massive[i + 1] % division == 0))
                {
                    pairCount++;
                    Console.WriteLine("Пара чисел " + massive[i] + " и " + massive[i + 1] + " удовлетворяет условию.");
                }
            }
            Console.WriteLine("Всего пар, отвечающих условию, что только одно из двух чисел делится на 3 без остатка: ");
            return pairCount;
        }
    }
}
