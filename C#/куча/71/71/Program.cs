using System;

namespace _71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 операнд:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите 2 операнд:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите операцию(+ - * /):");
            string c =(Console.ReadLine());
            double res = 0.0;
            bool ok = true;
            Console.WriteLine("res=");
            switch (c) 
            {
                case "+": res=a + b; break;
                case "-": res = a - b; break;
                case "*": res = a * b; break;
                case "/":
                case ":":
                    if (b != 0)
                    {
                        res = a / b; break;
                    }
                    else goto default;
                default: ok = false; break;
            }
            if (ok)
            {
                Console.Write(res);
            }
            else Console.WriteLine("Ошибка!");
                
        }
    }
}
