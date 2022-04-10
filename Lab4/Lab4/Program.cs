// Program.cs
using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction g = new Fraction();
            g.Read();
            g.Display();
            // обчислення значення дробу
            Console.WriteLine("Fraction value: " + g.GetValue());
            Console.WriteLine();
            // скорочення дробу
            int del = g.Contraction(g.GetFirst(), g.GetSecond());
            Console.WriteLine("first = " + g.GetFirst() / del);
            Console.WriteLine("second = " + g.GetSecond() / del);
        }
    }
}
