// Complex.cs
using System;

namespace Lab9._2
{
    public class Complex : INorm
    {
        private int real;
        private int imaginary;

        public int Real
        {
            get => real;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(
                    $"{nameof(value)} must be more than 0!");
            }
        }
        public int Imaginary
        {
            get => imaginary;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(
                    $"{nameof(value)} must be more than 0!");
            }
        }
        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public double FindNorm()
        {
            return Math.Sqrt(Math.Pow(this.real, 2) + Math.Pow(this.imaginary, 2));
        }
        public double FindModule()
        {
            return Math.Pow(Math.Sqrt(Math.Pow(this.real, 2) + Math.Pow(this.imaginary, 2)), 2);
        }
    }
}