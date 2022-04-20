using System;

namespace _41
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
                int k = ++(++i);
            k = !(-i);
            int a = 10, b = 3;

            bool t = (a >= b && a != 2 * b || a < 0);
            Console.WriteLine(T);

            Console.Write("Присвойте x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Присвойте x2:");
            double x2 = double.Parse(Console.ReadLine());
            
            double F1 = Math.Cos(1.5 * x1) - Math.Pow(Math.E, Math.Sin(x1 + 4 / 3)) + Math.Sqrt(x1 + 7 / 6);
            double F2 = Math.Cos(1.5 * x2) - Math.Pow(Math.E, Math.Sin(x2 + 4 / 3)) + Math.Sqrt(x2 + 7 / 6);
            Console.WriteLine("Значение функции(Math.Cos(1.5 * x1) - Math.Pow(Math.E, Math.Sin(x1 + 4 / 3)) + Math.Sqrt(x1 + 7 / 6)) при 1 значении x равно " + F1);
            Console.WriteLine("Значение функции(Math.Cos(1.5 * x1) - Math.Pow(Math.E, Math.Sin(x1 + 4 / 3)) + Math.Sqrt(x1 + 7 / 6)) при 2 значении x равно" + F2);
        }
    }
}
