using System;

namespace _141
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Строка1";

            string str2 = new string('s', 5); //объяснить синтаксис и назначение этого конструктора

            char[] charray = {'t','e','s','t'};

            string str3 = new string(charray);
            string str4 = str2;
            Console.WriteLine(str4);
            if (str4==str2) Console.WriteLine(str3);
            Console.WriteLine(str3[1]);
            Console.WriteLine(str1+str2);

        }
    }
}
