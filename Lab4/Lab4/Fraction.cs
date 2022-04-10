// Fraction.cs
using System;

namespace Lab4
{
    class Fraction
    {
        private int first;
        private int second;

        public int GetFirst() { return first; }
        public int GetSecond() { return second; }
        public void setFirst(int first) { this.first = first; }

        public bool SetSecond(int s)
        {
            if (s > 0)
            {
                second = s;
                return true;
            }
            else
            {
                second = 0;
                return false;
            }
        }
        public void Init(int first, int second)
        {
            setFirst(first);
            SetSecond(second);
        }
        public void Read()
        {
            Console.Write("first: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("second: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Init(first, second);
        }
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("First: " + first);
            Console.WriteLine("Second: " + second);
            Console.WriteLine();
        }
        // обчислення значення дробу
        public double GetValue() { return first / second; }
        // скорочення дробу
        public int Contraction(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }
    }
}