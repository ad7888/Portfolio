using System;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Введите c:  ");
            double c = int.Parse(Console.ReadLine());
            double x =2.5;
            Console.WriteLine("Y={0}",a*x*x+b*x-c);
        }
    }
}
