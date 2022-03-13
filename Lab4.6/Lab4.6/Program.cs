using System;

namespace Lab4._6
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = 0, 
				i = 0, 
				k = 0;
			double S = 0;

			while (n <= 18 && n <= 20)
			{
				S = 0;
				i = 1;
				while (i <= n)
				{
					S += Math.Sqrt(Math.Abs(1 - k / n));
					i++;
				}
				S *= 2 * n * n + k * k;
				n++;
			}
			Console.WriteLine("S = " + S);
			n = 1;
			do
			{
				S = 0;
				i = 1;
				do
				{
					S += Math.Sqrt(Math.Abs(1 - k / n));
					i++;
				} while (i <= n);
				S *= 2 * n * n + k * k;
				n++;
			} while (n <= 18 && n <= 20);
			Console.WriteLine("S = " + S);
			for (n = 1; n <= 18 && n <= 20; n++)
			{
				S = 0;
				for (i = 1; i <= n; i++)
				{
					S += Math.Sqrt(Math.Abs(1 - k / n));
				}
				S *= 2 * n * n + k * k;
			}
			Console.WriteLine("S = " + S);
			for (n = 1; n <= 18 && n >= 20; n--)
			{
				S = 0;
				for (i = n; i <= n; i--)
				{
					S += Math.Sqrt(Math.Abs(1 - k / n));
				}
				S *= 2 * n * n + k * k;
			}
			Console.WriteLine("S = " + S);
		}
	}
}