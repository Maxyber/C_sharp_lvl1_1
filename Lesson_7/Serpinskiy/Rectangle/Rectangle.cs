using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle
    {
        int[,] points = new int[8, 2];
        Random r = new Random();

        public int[,] Points { get => points; set => points = value; }

        // конструктор класса
        public Rectangle() // конструктор без параметров строит 8 нулевых точек
        {
            for (int i = 0; i < 8; i++)
            {
                Points[i, 0] = 0;
                Points[i, 1] = 0;
            }
        }
        public Rectangle(int maxX, int maxY) // конструктор параметрами int, int строит 2 случайных точки со значениями от 0 до max и по ним строит оставшиеся 6 точек
        {
            for (int i = 0; i < 2; i++)
            {
                Points[i, 0] = r.Next(maxX + 1);
                Points[i, 1] = r.Next(maxY + 1);
            }
            for (int i = 0; i < 2; i++)
            {
                if (Points[0, i] > Points[1, i])
                {
                    int j = Points[0, i];
                    Points[0, i] = Points[1, i];
                    Points[1, i] = j;
                }
            }
            FillPoints(Points[0, 0], Points[1, 0], Points[0, 1], Points[1, 1]);
        }
        public Rectangle(int minX, int maxX, int minY, int maxY) // конструктор параметрами int, int, int, int строит 2 случайных точки со значениями от min до max и по ним строит оставшиеся 6 точек
        {
            for (int i = 0; i < 2; i++)
            {
                //Points[i, 0] = r.Next(minX, maxX + 1);
                //Points[i, 1] = r.Next(minY, maxY + 1);
                Points[i, 0] = 100*(i+1);
                Points[i, 1] = 100*(i+1);
            }
            for (int i = 0; i < 2; i++)
            {
                if (Points[0, i] > Points[1, i])
                {
                    int j = Points[0, i];
                    Points[0, i] = Points[1, i];
                    Points[1, i] = j;
                }
            }
            FillPoints(Points[0, 0], Points[0, 1], Points[1, 0], Points[1, 1]);
        }
        public Rectangle(int[,] uPoints) // конструктор с параметром int[,] принимает 8 точек массива int[8,2], либо нулевые точки, если размерность массива отличается
        {
            if (uPoints.Length == 16)
            {
                Points = uPoints;
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    Points[i, 0] = 0;
                    Points[i, 1] = 0;
                }
            }
        }
        public int[] GetPoint(int index) => new int[2] { points[index, 0], points[index, 1] }; // возвращает массив int[2] с координатами точки index

        private void FillPoints(int vx1, int vy1, int vx2, int vy2)
        {
            Points[2, 0] = (vx1 + vx2) / 2;
            Points[2, 1] = vy1;
            Points[3, 0] = vx2;
            Points[3, 1] = vy1;
            Points[4, 0] = vx2;
            Points[4, 1] = (vy1 + vy2) / 2;
            Points[5, 0] = (vx1 + vx2) / 2;
            Points[5, 1] = vy2;
            Points[6, 0] = vx1;
            Points[6, 1] = vy2;
            Points[7, 0] = vx1;
            Points[7, 1] = (vy1 + vy2) / 2;
        }
        public int Attraction() // метод выбирает случайную точку от 0 до 7
        {
            int index = r.Next(8);
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
            int[] point2 = new int[2] { r.Next(Points[0, 0], Points[1, 0]), r.Next(Points[0, 1], Points[1, 1]) };
            while (point1 == point2)
            {
                point2 = new int[2] { r.Next(Points[0, 0], Points[1, 0]), r.Next(Points[0, 1], Points[1, 1]) };
            }
            newpoint[0] = (point2[0] + 2 * point1[0]) / 3;
            newpoint[1] = (point2[1] + 2 * point1[1]) / 3;
            return newpoint;
        }
        public int[] NewPoint(int[] oldpoint) // возвращает массив int[2] с координатами новой точки на основании предыдущей
        {
            int[] newpoint = new int[2];
            int[] point1 = RandomPoint();
            newpoint[0] = (oldpoint[0] + 2 * point1[0]) / 3;
            newpoint[1] = (oldpoint[1] + 2 * point1[1]) / 3;
            return newpoint;
        }
    }
}
