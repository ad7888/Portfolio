using System;

namespace _62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите y:");
            double y = double.Parse(Console.ReadLine());
            if((y == 0 && 0.3 < x && x < 1) || (y==0&&-1<x&&x<0)||(x*x+y*y==1&&y>0)||(x*x+y*y==0.09&&x>0&&y>0)||(x==0&&y<0.3))
            {
                Console.WriteLine("Точка  находиться на области ((y == 0 && 0.3 < x && x < 1) || (y==0&&-1<x&&x<0)||(x*x+y*y==1&&y>0)||(x*x+y*y==0.09&&x>0&&y>0)||(x==0&&y<0.3))");
            }
            else if ((x * x + y * y < 1)&&((x<0&&y>0)||(x * x + y * y == 0.09&&x>0.3&&y>0.3)))
            {
                Console.WriteLine("Точка  находиться в области ((x * x + y * y < 1)||(x<0&&y>0)||(x * x + y * y == 0.09&&x>0.3&&y>0.3))");
            }
            else
            {
                Console.WriteLine("Точка не находиться в области ((x * x + y * y < 1)||(x<0&&y>0)||(x * x + y * y == 0.09&&x>0.3&&y>0.3))");
            }
        }
    }
}
