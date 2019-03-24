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
                if (nums[i] < min) { min = nums[i]; }
            }
            return min;
        }
    }
}
