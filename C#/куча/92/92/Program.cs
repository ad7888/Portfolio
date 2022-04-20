using System;

namespace _92
{
    class Program
    {
        static int[] max(int a,params int[] z )
        {
            z = new int[5];
            z[0] =a;
            for(int k=1;k<5 ;k++ )
                z[k] = a * z[k-1];
            return  z;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Число a");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] z1 = new int[5];
            z1 = max(a, z1);
            for (int k = 0; k < a; k++)
                Console.WriteLine(z1[k]);
        }
    }
}
