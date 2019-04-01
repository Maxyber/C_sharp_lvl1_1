using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionArray
{
    public class TDArray
    {
        int[][] array; // сам двумерный массив
        int x = 0, y = 0; // индексы матрицы х и у
        string aName = ""; // имя массива, не обязательно
        Random rnd = new Random(); // случайная переменная

        public void Set(int x, int y, int val = 0)
        {
            array[x][y] = val;
        }
        public int Get(int x, int y)
        {
            int res;
            res = array[x][y];
            return res;
        }
        public void Resize(int xLength = 0, int yLength = 0)
        {
            if (x == 0)
            {
                if (xLength <= 0)
                {
                    Array.Resize(ref array, 10);
                }
                else
                {
                    Array.Resize(ref array, array.Length + 10);
                } 
            }
            if (y == 0)
            {
                if (yLength <= 0)
                {
                    Array.Resize(ref array[], 10);
                }
                else
                {
                    Array.Resize(ref array[], array[].Length + 10);
                }
            }
        }
        public void Fill(int xDim, int yDim, int start = 1, int finish = 10, int step, string mode = "random", string path = "") // заполнение массива различными способами
        {
            int x, y;
            switch (mode)
            {
                case "random":
                    for (x = 0; x < xDim; x++)
                    {
                        for (y = 0; y < yDim; y++)
                        {
                            array.Set(x, y, rnd.Next());
                        }
                    }
                    break;
                case "manual":
                    break;
                case "file":
                    break;
            }
        }
    }
}
