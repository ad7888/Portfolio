using System;

namespace _73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N:");
            int x = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {

                Console.Write("{0},", i);
                i++;
            }
            while (i != x);

            Console.Write("{0}.", i);
        }
    }
}
