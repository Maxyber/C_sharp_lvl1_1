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
    class Fractions
    {
        public int no; // nominator = числитель
        public int deno; // denominator = знаменатель

        public Fractions AskNumber() // метод ввода дроби с клавиатуры посредством ввода двух целых чисел числителя и знаменателя
        {
            Fractions result = new Fractions();
            Console.Write("Введите числитель: ");
            result.no = Maxyber.AskInteger();
            Console.Write("Введите знаменатель: ");
            do
            {
                result.deno = Maxyber.AskInteger();
                if (result.deno == 0) Console.WriteLine("Знаменатель дроби не может быть равным нулю, повторите ввод.");
            } while (result.deno == 0);
            result = result.Contraction();
            return result;
        }
        public new string ToString() // приведение дроби к строке для вывода
        {
            if ((no >= 0) && (deno > 0) || ((no < 0) && (deno > 0)))
                return no + "/" + deno;
            else if ((no < 0) && (deno < 0))
                return -1*no + "/" + -1*deno;
            else
                return "-" + no + "/" + -1 * deno;
        }
        public double ToDouble => (float)no / deno; // приведение дроби к десятичной
        public int getNominator => no; // вывод числителя дроби
        public int getDenominator => deno; // вывод знаменателя дроби
        public void setNoDeno(string target) // изменение числителя или знаменателя дроби
        {
            Fractions frac = new Fractions();
            frac = this;
            Console.Write("Введите новое число: ");
            int x = Maxyber.AskInteger();
            if (target == "no") frac.no = x;
            else frac.deno = x;
            frac = frac.Contraction();
            this.no = frac.no;
            this.deno = frac.deno;
            Maxyber.ConsolePrint("Вы изменили дробь на " + this.ToString());
        }
        public Fractions Plus(Fractions x2) // сложение чисел a/b + c/d = (ad + cb) / bd
        {
            Fractions x3 = new Fractions();
            x3.deno = x2.deno * this.deno;
            x3.no = (this.no * x2.deno) + (x2.no * this.deno);
            x3 = x3.Contraction();
            return x3;
        }
        public Fractions Minus(Fractions x2) // вычитание чисел a/b - c/d = (ad - cb) / bd 
        {
            Fractions x3 = new Fractions();
            x3.no = (this.no * x2.deno) - (x2.no * this.deno);
            x3.deno = this.deno * x2.deno;
            x3 = x3.Contraction();
            return x3;
        }
        public Fractions Multi(Fractions x2) // умножение чисел a/b * c/d = ac/bd
        {
            Fractions x3 = new Fractions();
            x3.no = (x2.no) * (this.no);
            x3.deno = (x2.deno) * (this.deno);
            x3 = x3.Contraction();
            return x3;
        }
        public Fractions Division(Fractions x2) // умножение чисел a/b / c/d = ad/bc
        {
            Fractions x3 = new Fractions();
            x3.no = (x2.deno) * (this.no);
            x3.deno = (x2.no) * (this.deno);
            x3 = x3.Contraction();
            return x3;
        }

        public Fractions Contraction() // метод сокращения дробей
        {
            int nod = 1;
            int a, b, temp;
            if (this.no >= this.deno)
            {
                a = this.no;
                b = this.deno;
            }
            else
            {
                a = this.deno;
                b = this.no;
            }
            while (a != 0 && b != 0)
            {
                if (a % b == 0)
                {
                    nod = Convert.ToInt32(b);
                    break;
                }
                else
                {
                    temp = a % b;
                    a = b;
                    b = temp;
                }
            }
            this.no = this.no / nod;
            this.deno = this.deno / nod;
            return this;
        }
    }
    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.

        public double im;
        public double re;

        public Complex AskNumber() // метод ввода комплексного числа с клавиатуры посредством ввода двух целых чисел действительного и мнимого
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
            x3.re = (x2.re) * (this.re) - (x2.im) * (this.im);
            x3.im = (x2.im) * (this.re) + (x2.re) * (this.im);
            return x3;
        }
        public new string ToString() // приведение комплексного числа к строке для последующего вывода на экран
        {
            if (im >= 0)
                return re + "+" + im + "i";
            else
                return re + "-" + -1 * im + "i";
        } 

    }

    class Program
    {
        static void Main(string[] args)
        {

            // Задание №1 а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
            //  б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
            //  в) Добавить диалог с использованием switch демонстрирующий работу класса.
            Complex[] complexArr = new Complex[2];
            complexArr = AskComplexNumbers(2); // метод формирования массива комплексных чисел, разобраться!!!
            ComplexCalc(complexArr[0], complexArr[1]);

            // Задание №2 а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. 
            // Сами числа и сумму вывести на экран, используя tryParse.
            int[] arr;
            arr = Maxyber.InputIntArray();
            Maxyber.ConsolePrintArray(arr);
            Maxyber.SummArray(arr);
            
            // Задание №3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
            // Написать программу, демонстрирующую все разработанные элементы класса.
            // *Добавить свойства типа int для доступа к числителю и знаменателю;
            // *Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
            // **Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
            // ***Добавить упрощение дробей.
            
            Fractions frac1 = new Fractions();
            frac1 = frac1.AskNumber();
            Maxyber.ConsolePrint("Вы ввели дробь " + frac1.ToString());
            Fractions frac2 = new Fractions();
            frac2 = frac2.AskNumber();
            Maxyber.ConsolePrint("Вы ввели дробь " + frac2.ToString());

            FractionsCalc(frac1, frac2);

        }

        public static Complex[] AskComplexNumbers(int a) // метод формирования массива комплесных чисел любой длины, разобраться.
        {
            Complex complexTemp = new Complex();
            Complex[] complexArray = new Complex[a];
            for (int i = 0; i < a; i++)
            {
                complexTemp = complexTemp.AskNumber();
                complexArray[i] = complexTemp;
            }
            return complexArray;
        }
        public static void ComplexCalc(Complex number1, Complex number2) // метод, выполняющий выбранную операцию с двумя комплексными числами
        {
            string userProcedure = "";
            do
            {
                Console.WriteLine("Введите необходимы тип операции с комплексными числами (+/сложение, -/вычитание, */умножение или произведение), введите \"exit\" для выхода");
                userProcedure = Console.ReadLine();
                Complex newResult = new Complex();

                switch (userProcedure)
                {
                    case "+":
                    case "сложение":
                        newResult = number1.Plus(number2);
                        Maxyber.ConsolePrint(number1.ToString() + " + " + number2.ToString() + " = " + newResult.ToString());
                        break;
                    case "-":
                    case "вычитание":
                        newResult = number1.Minus(number2);
                        Maxyber.ConsolePrint(number1.ToString() + " - " + number2.ToString() + " = " + newResult.ToString());
                        break;
                    case "*":
                    case "умножение":
                    case "произведение":
                        newResult = number1.Multi(number2);
                        Maxyber.ConsolePrint(number1.ToString() + " * " + number2.ToString() + " = " + newResult.ToString());
                        break;
                    case "exit":
                        Maxyber.ConsolePrint("Спасибо за пользование калькулятором комплексных чисел. Всего доброго.");
                        return;
                    default:
                        Maxyber.ConsolePrint("Тип операции выбран неверно");
                        break;
                }
            } while (userProcedure != "exit");
        }
        public static void FractionsCalc(Fractions number1, Fractions number2) // метод, выполняющий выбранную операцию с двумя дробями
        {
            string userProcedure = "";
            do
            {
                Console.WriteLine("Введите необходимы тип операции с дробями");
                Console.WriteLine("Списко команд: +, -, *, /, deci, ч1, ч2, з1, з2, help, exit");
                userProcedure = Console.ReadLine();
                Fractions newResult = new Fractions();

                switch (userProcedure)
                {
                    case "help":
                        Console.WriteLine("Команды:\n  + / сложение - сложение дробей\n  - / вычитание - вычитание дробей\n  * / умножение - перемножение дробей\n  / или деление - деление дробей\n  deci / десятичное - десятичное представление дробей\n  ч1/2 или числитель1/2 - изменение числителя первой или второй дроби\n  з1/2 или знаменатель1/2 - изменение знаменателя первой или второй дроби\n  exit - выход из калькулятора\n  help - вывод этого сообщения.\n\n");
                        break;
                    case "+":
                    case "сложение":
                        newResult = number1.Plus(number2);
                        Maxyber.ConsolePrint(number1.ToString() + " + " + number2.ToString() + " = " + newResult.ToString());
                        break;
                    case "-":
                    case "вычитание":
                        newResult = number1.Minus(number2);
                        Maxyber.ConsolePrint(number1.ToString() + " - " + number2.ToString() + " = " + newResult.ToString());
                        break;
                    case "*":
                    case "умножение":
                    case "произведение":
                        newResult = number1.Multi(number2);
                        Maxyber.ConsolePrint(number1.ToString() + " * " + number2.ToString() + " = " + newResult.ToString());
                        break;
                    case "/":
                    case "деление":
                        newResult = number1.Division(number2);
                        Maxyber.ConsolePrint(number1.ToString() + " / " + number2.ToString() + " = " + newResult.ToString());
                        break;
                    case "deci":
                    case "десятичное":
                        Maxyber.ConsolePrint($"Первая дробь: {number1.ToDouble}, вторая дробь: {number2.ToDouble}");
                        break;
                    case "ч1":
                    case "числитель1":
                        number1.setNoDeno("no");
                        break;
                    case "ч2":
                    case "числитель2":
                        number2.setNoDeno("no");
                        break;
                    case "з1":
                    case "знаменатель1":
                        number1.setNoDeno("deno");
                        break;
                    case "з2":
                    case "знаменатель2":
                        number2.setNoDeno("deno");
                        break;
                    case "exit":
                        Maxyber.ConsolePrint("Спасибо за пользование калькулятором дробей. Всего доброго.");
                        return;
                    default:
                        Maxyber.ConsolePrint("Тип операции выбран неверно, попробуйте заново.");
                        break;
                }
            } while (userProcedure != "exit");
        }
    }
}

