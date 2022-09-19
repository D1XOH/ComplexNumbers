using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KomplChisla
{
    class Complex
    {
        public double re, im; // действительная и мнимая части
        public Complex Sum(Complex a, Complex b) //Сумма
        {
            Complex res = new Complex();
            res.re = a.re + b.re;
            res.im = a.im + b.im;
            return res;
        }

        public Complex Umnoz(Complex a, Complex b) //Умножение
        {
            Complex res = new Complex();
            res.re = a.re * b.re;
            res.im = a.im * b.im;
            return res;
        }

        public Complex razn(Complex a, Complex b) //Вычитание
        {
            Complex res = new Complex();
            res.re = a.re - b.re;
            res.im = a.im - b.im;
            return res;
        }

        public void Print(Complex a)
        {
            Console.Write("{0} + i{1}", a.re, a.im);
        }

        public void PrintLine(Complex a)
        {
            Console.WriteLine("{0} + i{1}", a.re, a.im);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целую часть первого комплексного числа: ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double i1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целую часть второго комплексного числа: ");
            double r2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            double i2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            c1.re = r1;
            c1.im = i1;
            c2.re = r2;
            c2.im = i2;
            Console.WriteLine("Введенные комплексные числа: ");
            c1.PrintLine(c1);
            c2.PrintLine(c2);
            Console.WriteLine("\nДля продолжения нажмите [Enter]");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Сложение комплексных чисел:       {0} + {1}i", c1.Sum(c1, c2).re, c1.Sum(c1, c2).im);
            Console.WriteLine("Умножение комплексных чисел:      {0} + {1}i", c1.Umnoz(c1, c2).re, c1.Umnoz(c1, c2).im);
            Console.WriteLine("Вычитание комплексных чисел:      {0} + {1}i", c1.razn(c1, c2).re, c1.razn(c1, c2).im);
            Console.WriteLine("\nДля выхода из программы нажмите [Enter]");
            Console.ReadLine();
        }
    }
}
