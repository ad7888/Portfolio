using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _10
{
    public class Arrs
    {
        public ArrayList arrl;
        
       
        public static void CreateOneDimA(ref int[] a)
        {
            Random rnd = new Random();

            for (int i = 0; 5 > i; i++)
            {
                
            

                a[i] = rnd.Next(1, 10);
            }
            
        }
        public static void PrintArr(int[] a)
        {
            foreach (int k in a)
            {
                Console.Write("{0}, ", k);
            }
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5], B = new int[5], C = new int[5];

            
            Arrs.CreateOneDimA(ref A);
            Arrs.CreateOneDimA(ref B);
            for (int i = 0;5>i ;i++)
            {
                C[i] = A[i] + B[i];
            }
            int[] X = { 5, 5, 6, 6, 7, 7 };
            int[] U, V;
            U = new int[3] { 1, 2, 3 };
            //V ={1,2,3}

            V = new int[3];
            
            V = U;
            
            V[0] = 9;
            Arrs.PrintArr(A);
            Arrs.PrintArr(B);
            Arrs.PrintArr(C);
            Arrs.PrintArr(X);
            Arrs.PrintArr(U);
            Arrs.PrintArr(V);
        }
    }
}
