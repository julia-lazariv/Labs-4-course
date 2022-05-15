// Norm.cs
using System;

namespace Lab9
{
    public abstract class Norm
    {
        public abstract double FindNorm();
        public abstract double FindModule();
        public void FindNumberType()
        {
            Console.WriteLine("This number type is: " + this.GetType().Name);
        }
    }
}