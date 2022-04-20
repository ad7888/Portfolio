using System;

namespace _82
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2, arg1, arg2;
            Console.Write("Введите координату Х для 1 точки: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату Y для 1 точки: ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату Х для 2 точки: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату Y для 2 точки: ");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Заданные точки: А({0},{1}), B({2},{3})", x1, y1, x2, y2);
            if (x2 - x1 == 0)
            {
                Console.WriteLine("Ошибка! Деление на 0");
            }
            else
            {
                arg1 = (y2 - y1) / (x2 - x1);
                arg2 = -(x1 * y2 - x2 * y1) / (x2 - x1);
                if (arg2 >= 0)
                {
                    Console.WriteLine("Уравнение через заданные точки имеет вид: y = {0}x + {1}", arg1, arg2);
                }
                else
                {
                    arg2 *= -1;
                    Console.WriteLine("Уравнение через заданные точки имеет вид: y = {0}x - {1}", arg1, arg2);
                }
            }
        }
    }
    }
}
