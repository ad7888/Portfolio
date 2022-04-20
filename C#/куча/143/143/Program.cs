using System;
using System.Text;

namespace _143
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str1 = new StringBuilder("String – example of StringBuilder");
            StringBuilder str2 = new StringBuilder("String – example of StringBuilder");
            str1.Append(" 44 ");
            str1.Remove(str1.Length, str1.Length-2);
            str2.Append(" 4434 ");
            str2.Replace("443", "337");
        }
    }
}
