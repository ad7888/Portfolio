using System;

namespace _51
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=23241.2313213123214;
            Console.WriteLine("Hello \"World!\" {0:###.####}",x);
            Console.WriteLine("Hello \"World!\" {0,50}"+"  "+ x,x);
        }
    }
}
