using System;


namespace _121
{

    class Program
    {
        class Arr
        {
            private static Random rnd = new Random();
            public static void PrintAr2(string name, int[,] A)
            {
                Console.WriteLine(name);
                for (int i = 0; i < A.GetLength(0); i++, Console.WriteLine())
                
                    
                    for (int j = 0; j < A.GetLength(0); j++)
                        Console.Write("{0,5} ", A[i, j]);
                
                Console.WriteLine();
            }
            public static void CreateOneDimArrs(int[,] A)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.GetLength(0); j++)
                        A[i,j] = rnd.Next(1, 100);
            }



        }
        
        public static void MultMatr(int[,] A, int[,] B, int[,] C)
        {
            
            if (A.GetLength(1) != B.GetLength(0))
                Console.WriteLine("MultMatr: ошибка размерности!");
            else
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        int s = 0;
                        for (int k = 0; k < A.GetLength(1); k++)
                            s += A[i, k] * B[k, j];
                        C[i, j] = s;
                    }
        }

        static void Main(string[] args)
        {
            int[,] a=new int [4,4];
            int[,] b = new int[4, 4];
            int[,] c = new int[4, 4];
            Arr.CreateOneDimArrs(a);
            Arr.CreateOneDimArrs(b);

            MultMatr(a, b, c);
            Arr.PrintAr2("a",a);
            Arr.PrintAr2("b", b);
            Arr.PrintAr2("c", c);
        }
    }
}

