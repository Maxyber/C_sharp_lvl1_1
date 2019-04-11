using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        int[,] points = new int[3, 2];
        Random r = new Random();

        public int[,] Points { get => points; set => points = value; }

        // конструктор класса
        public Triangle() // конструктор без параметров строит 3 нулевые точки
        {
            for(int i = 0;i<3;i++)
            {
                Points[i, 0] = 0;
                Points[i, 1] = 0;
            }
        }
        public Triangle(int maxX, int maxY) // конструктор параметрами int, int строит 3 случайных точки со значениями от 0 до max
        {
            for (int i = 0; i < 3; i++)
            {
                Points[i, 0] = r.Next(maxX+1);
                Points[i, 1] = r.Next(maxY+1);
            }
        }
        public Triangle(int minX, int maxX, int minY, int maxY) // конструктор параметрами int, int int, int строит 3 случайных точки со значениями от min до max
        {
            for (int i = 0; i < 3; i++)
            {
                Points[i, 0] = r.Next(minX, maxX + 1);
                Points[i, 1] = r.Next(minY, maxY + 1);
            }
        }
        public Triangle(int[,] uPoints) // конструктор с параметром int[,] принимает 3 точки массива int[3,2], либо нулевые точки, если размерность массива отличается
        {
            if (uPoints.Length == 6)
            {
                Points = uPoints;
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Points[i, 0] = 0;
                    Points[i, 1] = 0;
                }
            }
        }

        public int[] GetPoint(int index) => new int[2] { Points[index, 0], Points[index, 1] }; // возвращает массив int[2] с координатами точки index

        public int Attraction() // метод выбирает случайную точку от 0 до 2
        {
            int index = r.Next(3);
            return index;
        }
        public int[] RandomPoint() // возвращает массив int[2] с координатами случайной точки
        {
            int index = Attraction();
            int[] point = this.GetPoint(index);
            return point;
        }
        public int[] NewPoint() // возвращает массив int[2] с координатами первой точки запуска
        {
            int[] newpoint = new int[2];
            int[] point1 = RandomPoint();
            int[] point2 = RandomPoint();
            while (point1 == point2)
            {
                point2 = RandomPoint();
            }
            newpoint[0] = (point1[0] + point2[0]) / 2;
            newpoint[1] = (point1[1] + point2[1]) / 2;
            return newpoint;
        }
        public int[] NewPoint(int[] oldpoint) // возвращает массив int[2] с координатами новой точки на основании предыдущей
        {
            int[] newpoint = new int[2];
            int[] point1 = RandomPoint();
            newpoint[0] = (point1[0] + oldpoint[0]) / 2;
            newpoint[1] = (point1[1] + oldpoint[1]) / 2;
            return newpoint;
        }

    }
}
