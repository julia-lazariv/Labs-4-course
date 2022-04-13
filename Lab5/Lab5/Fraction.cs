// Fraction.cs
using System;

namespace Lab5
{
    class Fraction
    {
        private int first;
        private int second;
        public Fraction()
        {
            first = 0;
            second = 0;
        }
        public Fraction(int first, int second)
        {
            this.first = first;
            this.second = second;
        }
        public Fraction(Fraction c)
        {
            this.first = c.first;
            this.second = c.second;
        }
        public int getFirst()
        {
            return this.first;
        }
        public int getSecond()
        {
            return this.second;
        }
        public void setFirst(int first)
        {
            this.first = first;
        }
        public bool setSecond(int second)
        {
            if (second > 0)
            {
                this.second = second;
                return true;
            }
            else
            {
                this.second = 0;
                return false;
            }
        }
        public override bool Equals(object o) // Equals for validate == operator
        {
            return true;
        }
        public override int GetHashCode() // GetHashCode for validate == operator
        {
            return 0;
        }
        public void Init(int first, int second)
        {
            setFirst(first);
            setSecond(second);
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
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.first + b.first, a.second + b.second);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.first - b.first, a.second - b.second);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.first * b.first - a.second * b.second, 
                a.first * b.second + a.second * b.first);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            int r1 = a.first;
            int i1 = a.second;
            int r2 = b.first;
            int i2 = b.second;
            return new Fraction((r1 * r2 - i1 * i2) / (r2 * r2 + i2 * i2), (-r1 * i2 + i1
           * r2) / (r2 * r2 + i2 * i2));
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            if (a.first == b.first || a.second == b.second)
                return true;
            else
                return false;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            if (!(a == b))
                return true;
            else
                return false;
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            if (a.first > b.first || a.second > b.second)
                return true;
            else
                return false;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            if (a.first < b.first || a.second < b.second)
                return true;
            else
                return false;
        }
        public static Fraction operator ^(Fraction a, UInt32 n)
        {
            var y = new Fraction(1, 0);
            for (UInt32 i = 1; i <= n; i++)
                y = y * a;
            return y;
        }

        public static Fraction operator ++(Fraction a)
        {
            a.first++;
            a.second++;
            return a;
        }
        public static Fraction operator --(Fraction a)
        {
            a.first--;
            a.second--;
            return a;
        }
        public override string ToString()
        {
            return "first: " + this.first + "\nsecond: " + this.second;
        }
    }
}