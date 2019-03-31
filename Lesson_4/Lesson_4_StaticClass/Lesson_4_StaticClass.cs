﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MaxyClass;

namespace Lesson_4_StaticClass
{
    public class Account
    {
        string login;
        string password;
        string accountName;

        public string Get(string str)
        {
            return str;
        }
        public void Set(string str, string data)
        {
            str = data;
            Console.WriteLine("Вы изменили поле " + str + " на значение: " + data);
        }

        public Account[] ReadFile(string path, char accSeparator = ':', char varSeparator = '|') 
            // база логинов и паролей в файле выглядит как 
            // account1|login1|password1:account2|login2|password2 и т.д.
        {
            Account[] result = new Account[0];
            string str = "";
            str = Maxyber.FileToString(path);
            string[] masStr = str.Split(accSeparator);
            Array.Resize(ref result, masStr.length);
            for (int i = 0; i < masStr.Length; i++)
            {
                string[] temp = masStr[i].Split(varSeparator);
                result[i].Set(accountName, temp[0]);
                result[i].Set(login, temp[1]);
                result[i].Set(password, temp[2]);
            }
            return result;
        }
    }
    public class MassiveClass
    {
        int[] massive = new int[10];
        int index;
        Random rnd = new Random();

        public int Get(int i)
        {
            int result = massive[i];
            return result;
        }
        public void Set(int i, string number)
        {
            bool flag = int.TryParse(number, out int x);
            if (index >= massive.Length) Resize();
            if (flag == true)
            {
                massive[i] = x;
                index++;
            }
            else Console.WriteLine("Вы пытаетесь записать в массив число '" + number + "', что неверно");
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < index; i++)
            {
                sum = sum + massive[i];
            }
            return sum;
        }
        public MassiveClass Inverse()
        {
            MassiveClass res = new MassiveClass();
            for (int i = 0; i < index; i++)
            {
                res.Set(i, -1 * massive[i] + "");
            }
            return res;
        }
        public void Multi(int x)
        {
            for (int i = 0; i < index; i++)
            {
                massive[i] = x * massive[i];
            }
        }
        public int MaxCount()
        {
            int maxCount = 1, max;
            max = massive[0];
            for(int i = 1; i < index; i++)
            {
                if (massive[i] > max)
                {
                    max = massive[i];
                    maxCount = 1;
                } else if (massive[i] == max) {
                    maxCount++;
                }
            }
            return maxCount;
        }
        public void Print()
        {
            int length = index;
            Console.WriteLine("Массив состоит из " + length + " элементов");
            for (int i = 0; i < length; i++)
            {
                Console.Write("{" + massive[i] + "}");
                if (i < length - 1) Console.Write(",");
            }
            Console.WriteLine("\nКонец массива.");
        }
        public void Resize()
        {
            Array.Resize<int>(ref massive, 2 * massive.Length);
        }
        public void Fill(int length, int minValue = 1, int maxValue = 10, int step = 1) // метод заполнения массива случайными числами от minValue до maxValue в количестве length с шагом step
        {
            if (step > 1) maxValue = maxValue / step;
            for (int i = 0; i < length; i++)
            {
                if (i >= index) Resize();
                massive[i] = rnd.Next(minValue, maxValue) * step;
                index++;
            }
        }
        public void FillOrder(int length, int minValue = 1, int step = 1)
        {
            for (int i = 0; i < length; i++)
            {
                if (i >= massive.Length) Resize();
                massive[i] = minValue;
                minValue = minValue + step;
                index++;
            }
        }
        static public int Pair(MassiveClass arr, int division = 3)
        {
            int pairCount = 0;
            for (int i = 0; i < arr.index - 2; i++)
            {
                if (((arr.Get(i) % division == 0) || (arr.Get(i + 1) % division == 0)) && ((arr.Get(i) % division) != (arr.Get(i + 1) % division)))
                {
                    pairCount++;
                    Console.WriteLine("Пара чисел " + arr.Get(i) + " и " + arr.Get(i + 1) + " удовлетворяет условию.");
                }
            }
            Console.WriteLine("Всего пар, отвечающих условию, что только одно из двух чисел делится на 3 без остатка: " + pairCount);
            return pairCount;
        }
        static public MassiveClass ReadFile(string path, char separator = ' ')
        {
            MassiveClass result = new MassiveClass();
            string str = "";
            bool flag;
            int x, resIndex = 0;
            str = Maxyber.FileToString(path);
            string[] strMas = str.Split(separator);
            for (int i = 0; i < strMas.Length; i++)
            {
                do
                {
                    flag = int.TryParse(strMas[i], out x);
                    if (flag == true)
                    {
                        result.Set(resIndex, strMas[i]);
                        resIndex++;
                    }
                    else
                    {
                        i++;
                    }
                } while (flag != true);
            }
            return result;
        }
    }
}
