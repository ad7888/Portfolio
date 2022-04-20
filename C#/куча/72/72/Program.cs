using System;

namespace _72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N:");
            int x = int.Parse(Console.ReadLine());
            int i = 1;
            while (i!= x)
            {
                Console.Write("{0},",x);
                --x;
            }
            Console.Write("{0}.", i);
        }
    }
}
