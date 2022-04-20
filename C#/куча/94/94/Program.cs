using System;

namespace _94
{
    class Program
    {
        static string Factorial(int a)

        {
            int i = 1;
            double fac = 1;
            string str1="bug";
            if (a >= i)
            {
                for (; (i <= a); i++)
                {
                    fac *= i;
                }
                str1 = fac.ToString();
            }
            if (a == 0) return ("0");
            
            
            return (str1);
           

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.Read());
            Console.WriteLine("{0}", Factorial( a));
        }
    }
}
