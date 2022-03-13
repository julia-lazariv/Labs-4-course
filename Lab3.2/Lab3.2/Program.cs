using System;

namespace Lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
			double F = 1; // результат обчислення виразу
			Console.Write("a = "); 
			double a = Convert.ToDouble(Console.ReadLine()); // вхідний параметр
			Console.Write("b = ");
			double b = Convert.ToDouble(Console.ReadLine()); // вхідний параметр
			Console.Write("a = ");
			double c = Convert.ToDouble(Console.ReadLine()); // вхідний параметр
			Console.Write("x = ");
			double x = Convert.ToDouble(Console.ReadLine()); // вхідний параметр
			// спосіб 1: розгалуження в скороченій формі
			if (x < 0 && b != 0)
				F = -(a * x * x) + b;
			if (x > 0 && b == 0)
				F = x / x - c + 5.5;
			if (!(x < 0 && b != 0) && !(x > 0 && b == 0))
				F = x / (-c);
			Console.WriteLine();
			Console.WriteLine("F = " + F);
			// спосіб 2: розгалуження в повній формі
			if (x < 0 && b != 0)
				F = -(a * x * x) + b;
			else
				if (x > 0 && b == 0)
				F = x / x - c + 5.5;
			else
				F = x / (-c);
			Console.WriteLine("F = " + F);
		}
	}
}
