using System;

namespace _61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            double b = double.Parse(Console.ReadLine());
            double c = a * b;
            Console.Write("Введите ответ a*b:");
            if (c == double.Parse(Console.ReadLine()))
            {
                Console.WriteLine("Правильно!");
            }
            else
            {
                Console.WriteLine("Неправильно!");
            }

            }
    }
}
