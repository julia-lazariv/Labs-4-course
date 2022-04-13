// Program.cs
using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction g = new Fraction();
            g.Read();
            g.Display();

            Console.WriteLine();
            Console.WriteLine("first > second: {0}", g.getFirst() > g.getSecond());
            Console.WriteLine("first < second: {0}", g.getFirst() < g.getSecond());
            Console.WriteLine("first == second: {0}", g.getFirst() == g.getSecond());
            Console.WriteLine("first / second: {0}", g.getFirst() / g.getSecond());
            Console.WriteLine();
            String pow = (g ^ 2).ToString();
            Console.WriteLine("x ^ 2:\n{0}", pow);
        }
    }
}
