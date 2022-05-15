// Vector3D.cs
using System;

namespace Lab9
{
    public class Vector3D : Norm
    {
        private int x;
        private int y;
        public int X
        {
            get => x;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(
                    $"{nameof(value)} must be more than 0!");
            }
        }
        public int Y
        {
            get => y;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(
                    $"{nameof(value)} must be more than 0!");
            }
        }
        public Vector3D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override double FindNorm()
        {
            if (this.x > this.y)
                return Math.Sqrt(this.x);
            else
                return Math.Sqrt(this.y);
        }
        public override double FindModule()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
        }
    }
}