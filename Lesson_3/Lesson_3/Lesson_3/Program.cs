using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxyClass;

namespace Lesson_3
{
    /*
    struct Complex
    {
        public double im;
        public double re;
        //  в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    */
    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.

        public double im;
        public double re;

        public Complex AskNumber()
        {
            Complex result = new Complex();
            Console.Write("Введите действительную часть комплексного числа: ");
            result.re = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа без \"i\": ");
            result.im = Convert.ToInt32(Console.ReadLine());
            Maxyber.ConsolePrint("Вы ввели число: " + result.ToString());
            return result;
        }
        public Complex Plus(Complex x2) // сложение чисел a + bi , c + di
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }
        // Задание №1 а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
        //  б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
        //  в) Добавить диалог с использованием switch демонстрирующий работу класса.
        public Complex Minus(Complex x2) // вычитание чисел
        {
            Complex x3 = new Complex();
            x3.re = this.re - x2.re;
            x3.im = this.im - x2.im;
            return x3;
        }
        public Complex Multi(Complex x2) // умножение чисел
        {
            Complex x3 = new Complex();
            x3.re = (x2.re)*(this.re) - (x2.im)*(this.im);
            x3.im = (x2.im)*(this.re) + (x2.re)*(this.im);
            return x3;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            complex1 = complex1.AskNumber();

            Complex complex2 = new Complex();
            complex2 = complex1.AskNumber();

            Complex result = complex1.Plus(complex2);
            Maxyber.ConsolePrint(complex1.ToString() + " + " + complex2.ToString() + " = " + result.ToString());
            result = complex1.Minus(complex2);
            Maxyber.ConsolePrint(complex1.ToString() + " - " + complex2.ToString() + " = " + result.ToString());
            result = complex1.Multi(complex2);
            Maxyber.ConsolePrint(complex1.ToString() + " * " + complex2.ToString() + " = " + result.ToString());
        }

    }
}

