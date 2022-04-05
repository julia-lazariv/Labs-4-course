using System;

namespace Lab6._1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n =  ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 25);
            }
            Print(array, n);

            int sum = RecSum(array, 0, array.Length - 1);
            Console.WriteLine("Sum = " + sum);

            int count = RecCount(array, 0, array.Length - 1, 0);
            Console.WriteLine("Count = " + count);

            Console.WriteLine();
            Console.WriteLine("To Zero");
            ToZero(array, 0, array.Length - 1);
            Print(array, n);
        }
        static void Print(int[] array, int count)
        {
            Console.Write("b[] = { ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.Write(" }");
            Console.WriteLine();
        }
        static int RecSum(int[] array, int low, int high)
        {
            if (low == high)
                return array[low];
            int mid = low + (high - low) / 2;

            return RecSum(array, low, mid) + RecSum(array, mid + 1, high);
        }
        static int RecCount(int[] array, int low, int high, int first)
        {
            if (low > high) return 0;
            else
            {
                if (array[low] > first)
                    return 1 + RecCount(array, low + 1, high, first);
                else
                    return RecCount(array, low + 1, high, first);
            }
        }
        static int ToZero(int[] array, int low, int high)
        {
            if (low > high) return 0;
            else
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] = 0;

                if (array[low] > 0)
                    return 1 + ToZero(array, low + 1, high);
                else
                    return ToZero(array, low + 1, high);
            }
        }
    }
}
