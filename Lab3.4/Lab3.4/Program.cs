using System;

namespace Lab3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("R = ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (x <= 0)
            {
                if (Math.Pow(R, 2) + Math.Pow(R, 2) <= 1 && R >= 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
            else
            {
                if (Math.Pow(R, 2) + Math.Pow(R, 2) <= 1 && y <= 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }

        }
    }
}