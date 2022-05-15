// Program.cs
using System;

namespace Lab9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            INorm rect = new Complex(5, 6); // використання поліморфізму
            Console.WriteLine("Complex norm: {0}", rect.FindNorm());
            Console.WriteLine("Complex module: {0}", rect.FindModule());
            Console.WriteLine();


            INorm circle = new Vector3D(6, 7);
            Console.WriteLine("Vector norm: {0}", circle.FindNorm());
            Console.WriteLine("Vector module: {0}", circle.FindModule());
        }
    }
}
