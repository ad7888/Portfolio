using System;

namespace _142
{
    class Program
    {
        public static string SumInWords(int a)
        {
            string str = " рублей";
            string[] ar1 = { "ноль","один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] ar2 = { "десять", "одинацать", "двенацать", "четырнацатье", "пятьнацать", "шестнацать", "семьнацать", "восемьнацать", "девятьнацать" };
            string[] ar3 = { "двацать", "трицать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто", "сто" };

            if (a < 10)
                str = ar1[a]+str;
            else if (a < 20)
                str = ar2[a-10]+str;
            else
                str = ar3[a / 10-2] + " " + ar1[a % 10] + str;
            return (str);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Число рублей :");
            string str1=SumInWords(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(str1);
        }
    }
}
