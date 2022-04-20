using System;

namespace _93
{
    class Program
    {
        static void MyMethod(ref int a, ref int b)
        {

            int c;
            c = a;
            a = b;
            b = c;
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Число a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число b:");
            int b = Convert.ToInt32(Console.ReadLine());
            MyMethod(ref a, ref b);
            Console.WriteLine("{0},{1}",a,b);
        }
    }
}
