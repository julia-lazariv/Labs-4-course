// Program.cs
using System;

namespace Lab7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = Matrix.Create();
            a.Fill();
            a.Display();
            Console.WriteLine();
            Matrix b = Matrix.Create();
            b.Fill();
            b.Display();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("a + b: ");
            var z = a + b;
            z.Display();

            Console.WriteLine("\na == b: {0}\n", a == b);
            Console.WriteLine("\na != b: {0}\n", a != b);
            Console.WriteLine("Matrix norm from matrix a: {0}", a.Norm());
            Console.ReadKey();
        }
    }
}
