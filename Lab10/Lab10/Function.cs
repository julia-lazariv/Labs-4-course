// Function.cs
using System;

namespace Lab10
{
    public class Function
    {
        private int N;
        private int A1;
        private int An;
        private int D;
        public Function(int N, int A1, int An, int D)
        {
            this.N = N;
            this.A1 = A1;
            this.An = An;
            this.D = D;
        }
        public int E1()
        {
            int sum = (A1 + An) * N / D;
            Console.WriteLine(sum);
            if (sum < 0)
                throw new MyException("Sum can't be negative");
            return sum;
        }
    }
}