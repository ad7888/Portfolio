using System;

namespace _111
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] Z = new double[n+1];
                for (int j=1;j<=n ;j++) 
            {
                double fxa = 0;
                double fxb = 1;
                int k;
                
                for (k = j; k <= j+5; k++)
                    fxa = fxa+Math.Cos(Math.Abs(2 * k)) / 1.12 - Math.Cos(3 * k - 2) + 6.15;
                for (k = j; k <= j+3; k++)
                    fxb = fxb*Math.Cos(Math.Abs(2 * k)) / 1.12 - Math.Cos(3 * k - 2) + 6.15;
                Z[j] = 5 * fxa * fxb - 4;
            }
            for(int i = 1;i<=n ; i++)
            {
                Console.WriteLine(Z[i]);
            }
        }
    }
}
