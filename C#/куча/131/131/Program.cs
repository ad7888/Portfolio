using System;

namespace _131
{
    class Program
    {
        class Arr
        {
            private static Random rnd = new Random();
            public static void PrintAr3(int[][] A)
            {
                
                for (int i = 0; i < A.Length; i++)
                {
                    
                    for (int j = 0; j < A[i].Length; j++)
                        Console.Write("\t {0}",A[i][j]);
                    Console.WriteLine();
                }
                
            }
            public static void CreateOneDimArrs(int[][] A)
            {
                for (int i = 0; i < A.Length; i++)
                {

                    for (int j = 0; j < A[i].Length; j++)
                        A[i][j] = rnd.Next(1, 100);
                }
            }



        }
        static void Main(string[] args)
        {
            int[][] nums = new int[3][];
            nums[0] = new int[2] { 1, 2 };          
            nums[1] = new int[3] { 1, 2, 3 };       
            nums[2] = new int[5] { 1, 2, 3, 4, 5 }; 
            Arr.PrintAr3(nums);
            Arr.CreateOneDimArrs(nums);
            Arr.PrintAr3(nums);
        }
    }
}
