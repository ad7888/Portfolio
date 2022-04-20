using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;




namespace Homework_06
{
    class Program
    {
        static void PrintAr3(int[][] A)
        {

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == null) goto NextPrintArr;
                else
                {
                    for (int j = 0; (j < A[i].Length); j++)
                        Console.Write(" {0}", A[i][j]);
                }
                NextPrintArr:
                Console.WriteLine();
            }

        }
        static public void AddElemInAr(ref int[][] A, int ad,int ArrStroka)
        {
            if (A[ArrStroka] == null) A[ArrStroka] = new int[1] { ad };
            else {
                int LenArrStroka = 1 + A[ArrStroka].Length;
                int[] B = new int[LenArrStroka];
                for (var i = 0; i < A[ArrStroka].Length; i++)
                {
                    B[i] = A[ArrStroka][i];
                }
                B[LenArrStroka-1] = ad;
                A[ArrStroka] = new int[B.Length];
                for (var i = 0; i < B.Length; i++)
                {
                    A[ArrStroka][i]= B[i];
                }
                
            }
        




        }


        static void Main(string[] args)
        {
            
            static void MArr(ref int[][]ArrM,int N,int M)
            {
                int CountF = 0;
                bool Tool = true;
                int last = 0;
                for (int i = 1; i <= N; i++) 
                {
                    CountF = 0;
                    Tool = true;
                    
                    //определение строки добавления
                    while (Tool != false)
                    {

                        for(var ii=0;ii<M;ii++)
                        {
                            //пустой ли массив
                            if (ArrM[ii] == null)
                            {
                                Tool = false;
                                last = i;
                                AddElemInAr(ref ArrM, i, CountF);
                                break;
                            }
                            //делиться по остатку
                            for (var ji = 0; ji < ArrM[ii].Length; ji++) {
                                if (i % ArrM[ii][ji] == 0)
                                //если не делиться то переход на след массив
                                {
                                    CountF = CountF + 1;
                                    break;
                                }
                                else if (ji == ArrM[ii].Length-1)
                                {
                                    Tool = false;
                                    last = i;
                                    AddElemInAr(ref ArrM, i, CountF);
                                    goto NextI;
                                }
                            }
                            
                        }
                    
                        
                    }
                NextI:
                    PrintAr3(ArrM);
                    //Console.WriteLine("{0} CountF", CountF.ToString());
                    //добавление элемента
                    
                }
            }

            var N = Convert.ToInt32(Console.ReadLine());
            int M = 0;
            M = Convert.ToInt32(Math.Log2(N))+1;
            //Console.WriteLine(M);
            //int[][] test;
            //test = new int[3][];
            //test[0] = new int[2];
            //test[0][0] = 1;
            //test[1] = new int[5];
            //test[1][1] = 2;
            //test[1][0] = 1;
            //test[1][2] = 3;
            //test[1][3] = 4;
            //test[1][4] = 5;
            //PrintAr3(test); Console.ReadKey();
            //AddElemInAr(ref test, 9,1);
            //AddElemInAr(ref test, 9, 1);
            //AddElemInAr(ref test, 8, 1);
            //AddElemInAr(ref test, 9, 2);
            //PrintAr3(test);
            //Console.ReadKey();
            int[][] matrisa4;
            matrisa4 = new int[M][];
            
            
            
            MArr(ref matrisa4, N, M);
            //Console.WriteLine(M);
            //Console.WriteLine(matrisa4[0][0]);
            //Console.WriteLine(matrisa4[2][0]);
            PrintAr3(matrisa4);
            Console.ReadKey();



            /// Домашнее задание
            ///
            /// Группа начинающих программистов решила поучаствовать в хакатоне с целью демонстрации
            /// своих навыков. 
            /// 
            /// Немного подумав они вспомнили, что не так давно на занятиях по математике
            /// они проходили тему "свойства делимости целых чисел". На этом занятии преподаватель показывал
            /// пример с использованием фактов делимости. 
            /// Пример заключался в следующем: 
            /// Написав на доске все числа от 1 до N, N = 50, преподаватель разделил числа на несколько групп
            /// так, что если одно число делится на другое, то эти числа попадают в разные руппы. 
            /// В результате этого разбиения получилось M групп, для N = 50, M = 6
            /// 
            /// N = 50
            /// Группы получились такими: 
            /// 
            /// Группа 1: 1
            /// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
            /// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
            /// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
            /// Группа 5: 16 24 36 40
            /// Группа 6: 32 48
            /// 
            /// M = 6
            /// 
            /// ===========
            /// 
            /// N = 10
            /// Группы получились такими: 
            /// 
            /// Группа 1: 1
            /// Группа 2: 2 7 9
            /// Группа 3: 3 4 10
            /// Группа 4: 5 6 8
            /// 
            /// M = 4
            /// 
        }
    }
}
