using System;

namespace _81
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, disk, x1, x2;
            Console.Write("Введите а = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите с = ");
            c = double.Parse(Console.ReadLine());
            disk = (b * b) - (4 * a * c);
            if (disk < 0)
            {
                Console.WriteLine("Уравнение не имеет корней");
            }
            else
            {
                if (disk == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine("Существует только один корень x = ", x1);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(disk)) / 2 * a;
                    x2 = (-b - Math.Sqrt(disk)) / 2 * a;
                    Console.WriteLine("Существует два корня x1 = " + x1 + ", x2 = " + x2);
                }
            }
        }
    }
    }
}
