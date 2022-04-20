using System;

namespace _83
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, min, max;
            double sr;
            Console.Write("Введите первое число: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("введите второе число: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            z = int.Parse(Console.ReadLine());
            if (x == y || x == z || y == z)
            {
                Console.WriteLine("Ошибка!");
            }
            else
            {
                 min = x;
                 max = y;

                if (min > y) min = y;
                if (min > z) min = z;

                if (max < y) max = y;
                if (max < z) max = z;

                Console.WriteLine("Минимальное равно {0}, Максимальное {1}", min, max);

                sr = (x + y + z - min - max);

                Console.WriteLine("Число {0} находится между мин. и макс.", sr);
            }
        }
    }
}

