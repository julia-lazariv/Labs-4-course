using System;

namespace Lab8._1_Recursion
{
    class Program
    {
        static bool Search(string str, int i)
        {
            if (str.Length < 3)
                return false;
            if (i >= str.Length)
                return false;
            if (str.Substring(i, 1) == "*" &&
                str.Substring(i + 1, 1) == "*" &&
                str.Substring(i + 2, 1) == "*")
                return true;
            return Search(str, i + 1);
        }
        static String Change(string s)
        {
            String t = s.Replace("***", "!!");
            return t;
        }

        static void Main(string[] args)
        {
            Console.Write("str = ");
            string str = Console.ReadLine();
            Console.WriteLine("String contained groups of '***' - " + Search(str, 1));
            Console.WriteLine("Modified string  = " + Change(str));
        }
    }
}