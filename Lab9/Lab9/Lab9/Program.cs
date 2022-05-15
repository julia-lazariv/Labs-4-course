// Program.cs
using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Norm rect = new Complex(5, 6); // використання поліморфізму
            rect.FindNumberType();
            Console.WriteLine("Complex norm: {0}", rect.FindNorm());
            Console.WriteLine("Complex module: {0}", rect.FindModule());
            Console.WriteLine();


            Norm circle = new Vector3D(6, 7);
            circle.FindNumberType();
            Console.WriteLine("Vector norm: {0}", circle.FindNorm());
            Console.WriteLine("Vector module: {0}", circle.FindModule());
        }
    }
}