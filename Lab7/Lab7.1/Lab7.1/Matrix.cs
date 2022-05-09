// Matrix.cs
using System;

namespace Lab7._1
{
    class Matrix
    {
        private int K;
        private int N;
        private int[,] mat;
        public Matrix()
        {
            this.K = 0;
            this.N = 0;
            this.mat = new int[K, N];
        }
        public Matrix(int k, int n)
        {
            if (k > 0 && n > 0)
            {
                this.K = k;
                this.N = n;
                this.mat = new int[K, N];
                for (int i = 0; i < K; i++)
                {
                    for (int j = 0; j < N; j++)
                    { mat[i, j] = 0; }
                }
            }
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        public static Matrix Create()
        {
            int k = 0, n = 0;
            do
            {
                Console.WriteLine("Please, input number of lines:");
                k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please, input number of rows:");
                n = Convert.ToInt32(Console.ReadLine());
            } while (!(k > 0 && n > 0));

            return new Matrix(k, n);
        }
        public void Fill()
        {
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("Input number in line {0} in row {1}", i + 1, j + 1);
                    this.mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                { Console.Write("{0} ", mat[i, j]); }
                Console.WriteLine();
            }
        }
        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.N == b.N && a.K == b.K)
            {
                for (int i = 0; i < a.K; i++)
                {
                    for (int j = 0; j < a.N; j++)
                    {
                        if (a.mat[i, j] != b.mat[i, j])
                        { return false; }
                    }
                }
                return true;
            }
            else
            { return false; }
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            if (a.N == b.N && a.K == b.K)
            {
                for (int i = 0; i < a.K; i++)
                {
                    for (int j = 0; j < a.N; j++)
                    {
                        if (a.mat[i, j] != b.mat[i, j])
                        { return true; }
                    }
                }
                return false;
            }
            else
            { return true; }
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.N == b.N && a.K == b.K)
            {
                var matrix = new Matrix(a.K, a.N);
                for (int i = 0; i < a.K; i++)
                {
                    for (int j = 0; j < a.N; j++)
                    { 
                        matrix.mat[i, j] = a.mat[i, j] + b.mat[i, j]; 
                    }
                }
                return matrix;
            }
            else
            {
                Console.WriteLine("Matrix must have same size! Returning zero matrix...");
                return new Matrix();
            }
        }
        public double Norm()
        {
            int max = 0, min = 0;
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] > max)
                        max = mat[i, j];
                    else if (mat[i, j] < max)
                        min = mat[i, j];
                }
            }
            return Math.Abs(max - min);
        }
    }
}
