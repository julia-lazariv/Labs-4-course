using System;
using System.Text;

namespace Lab._7._2_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("rowCount =  ");
            int rowCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("colCount =  ");
            int colCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Start Matrix =  ");

            int[,] arr = new int[rowCount, colCount];
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(0, 25);
                }
            }
            Print(arr);

            Console.WriteLine();
            Console.WriteLine("Swap Matrix =  ");
            Swap(arr, rowCount, colCount);
            Print(arr);

            Console.ReadKey();
        }
        static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Swap(int[,] arr, int rowCount, int colCount)
        {
            int Imax = 0, Jmax = 0, Imin = 0, Jmin = 0;
            for (int i = 0; i < rowCount; i++)
            {
                int max = arr[i, 0];
                int min = arr[i, 0];

                if (i % 2 == 0)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                            Imax = i;
                            Jmax = j;
                        }
                        if (arr[i, j] < min)
                        {
                            min = arr[i, j];
                            Imin = i;
                            Jmin = j;
                        }
                    }

                    int z = arr[Imax, Jmax];
                    arr[Imax, Jmax] = arr[Imin, Jmin];
                    arr[Imin, Jmin] = z;

                    Jmax = 0; Jmin = 0; Imax = i + 1; Imin = i + 1;
                }
            }
        }
    }
}