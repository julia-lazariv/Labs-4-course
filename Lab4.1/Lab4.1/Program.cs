using System;

namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double P = 0.0;
            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            while (k <= N)
            {
                P = (k * k / N * N) * Math.Cos(N * N / k * k);
                Console.WriteLine("P = " + P);
                return;
            }
            do
            {
                P = (k * k / N * N) * Math.Cos(N * N / k * k);
                Console.WriteLine("P = " + P);
            } while (k <= N);
            for (k = 1; k <= N; k++)
            {
                P = (k * k / N * N) * Math.Cos(N * N / k * k);
                Console.WriteLine("P = " + P);
            }
            for (k = 1; k >= N; k--)
            {
                P = (k * k / N * N) * Math.Cos(N * N / k * k);
                Console.WriteLine("P = " + P);
            }
        }
    }
}
