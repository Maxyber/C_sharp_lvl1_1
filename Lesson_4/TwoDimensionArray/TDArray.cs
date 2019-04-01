using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionArray
{
    public class TDArray
    {
        int[,] array = new int[10, 10]; // сам двумерный массив
        private int xDim = 0, yDim = 0; // индексы матрицы х и у
        string aName = ""; // имя массива, не обязательно
        Random rnd = new Random(); // случайная переменная

        public void Set(int x, int y, int val = 0)
        {
            array[x, y] = val;
        }
        public int Get(int x, int y)
        {
            int res;
            res = array[x, y];
            return res;
        }
        public int GetXDim => xDim;
        public int GetYDim => yDim;
        // НЕ РАБОТАЕТ Подумать как сделать переинициализацию двумерного массива на большую размерность
        /* 
        public int[,] Resize(ref int[,] array, int xLength = 0, int yLength = 0)
        {
            int xLen, yLen;
            Console.Write("Матрица (" + array.GetLength(0)); // получение размерности массива X
            Console.WriteLine("," + array.GetLength(1) + ")"); // получение размерности массива Y
            if (xDim >= array.GetLength(0))
            {
                xLen = array.GetLength(0) + 10;
            }
            if (yDim >= array.GetLength(1))
            {
                yLen = array.GetLength(1) + 10;
            }
            int[,] arrayNew = new int[xLen, yLen];
            for (int i = 0; i < xLen; j++)
                for (int j = 0; j < yLen; j++)
                    arrayNew[i, j] = array[i, j];
            return ref arrayNew;
        }
        */
        public void Print()
        {
            for (int y = 0; y < yDim; y++)
            {
                for (int x = 0; x < xDim; x++)
                {
                    Console.Write($"{array[x, y],3} ");
                }
                Console.WriteLine();
            }
        }
        public void Fill(int xUser, int yUser, int start = 1, int finish = 10, int step = 1, string mode = "random", string path = "") // заполнение массива различными способами
        {
            int x, y;
            switch (mode)
            {
                case "random":
                    for (x = 0; x < xUser; x++)
                    {
                        for (y = 0; y < yUser; y++)
                        {
                            //if (x >= xDim) Resize();
                            //if (y >= yDim) Resize();
                            array[x, y] = rnd.Next(start, finish + 1);
                        }
                    }
                    xDim = xUser;
                    yDim = yUser;
                    break;
                case "manual":
                    break;
                case "file":
                    break;
            }
        }
        public string MaxValue(string mode)
        {
            int xRes = 0, yRes = 0;
            int max = array[0, 0];
            for (int x = 0; x < xDim; x++)
                for (int y = 0; y < yDim; y++)
                    if (array[x, y] > max)
                    {
                        max = array[x, y];
                        xRes = x+1;
                        yRes = y+1;
                    }
            switch(mode)
            {
                case "Value":
                    return "" + max;
                case "Coord":
                    return xRes + ", " + yRes;
                default:
                    return "Unknown error";
            }
        }
        public string MinValue(string mode)
        {
            int xRes = 0, yRes = 0;
            int min = array[0, 0];
            for (int x = 0; x < xDim; x++)
                for (int y = 0; y < yDim; y++)
                    if (array[x, y] < min)
                    {
                        min = array[x, y];
                        xRes = x+1;
                        yRes = y+1;
                    }
            switch (mode)
            {
                case "Value":
                    return "" + min;
                case "Coord":
                    return xRes + ", " + yRes;
                default:
                    return "Unknown error";
            }
        }
    }
}
