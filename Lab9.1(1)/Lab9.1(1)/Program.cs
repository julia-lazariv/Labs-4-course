using System;
using System.Text;

namespace Lab9._1_1_
{
    class Program
    {
        enum Spec { MM, IH, TT, KH };
        static string[] specStr = { "математика", "інформатика", "трудове навчання", "комп'ютерні науки" };
        struct Student
        {
            public string prizv;
            public uint kyrs;
            public int mark1,
                mark2,
                mark3;
            public int spec;
        };
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default; // Коректне відображення української мови при виведенні

			Console.Write("Введіть N: ");
			int N = Convert.ToInt32(Console.ReadLine()); // вхідний параметр

            Student p = Create(N);
            Print(p, N);
       

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Середній бал для " + i + " студента: " + AverageMark(p, N, i));
            }
            Console.WriteLine();
            Console.WriteLine("Найбільший середній бал: " + MaxAverageMark(p, N));
            Console.WriteLine("Процент студентів, які отримали з фізики оцінки 4 або 5: " + Proc(p, N) + "%");
            Console.WriteLine();
        }
        static Student Create(int N)
        {
            Student p = new Student();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Студент № " + i + ":");
                Console.Write("Прізвище студента: ");
                p.prizv = Console.ReadLine();
                Console.Write("Курс: ");
                p.kyrs = Convert.ToUInt32(Console.ReadLine());
                Console.Write("спеціальність (0 - математика, 1 - інформатика, 2 - трудове навчання, 3 - комп'ютерні науки): ");
                p.spec = Convert.ToInt32(Console.ReadLine());
                Console.Write("Оцінки з фізики: ");
                p.mark1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Оцінки з математики: ");
                p.mark2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Оцінки з інформатики: ");
                p.mark3 = Convert.ToInt32(Console.ReadLine());
            }
            return p;
        }
        static void Print(Student p, int N)
        {
            Console.WriteLine("====================================================================================================================");
            Console.WriteLine("| № | Прізвище студента |  Курс |   Спеціальність  | Оцінка з фізики | Оцінка з математики | Оцінка з інформатики |");
            for (int i = 0; i < N; i++)
            {
                Console.Write("| " + " " + i + " ");
                Console.Write("| " + " " + p.prizv + " ");
                Console.Write("| " + " " + p.kyrs + " ");
                Console.Write("| " + " " + specStr[p.spec] + " ");
                Console.Write("| " + " " + p.mark1 + " ");
                Console.Write("| " + " " + p.mark2 + " ");
                Console.Write("| " + " " + p.mark3 + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("====================================================================================================================");
            Console.WriteLine();
        }
        static int AverageMark(Student p, int N, int i)
        {
            int sum = p.mark1 + p.mark2 + p.mark3;
            return sum / 3;
        }
        static int MaxAverageMark(Student p, int N)
        {
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                int sum = p.mark1 + p.mark2 + p.mark3;
                int average = sum / 3;

                if (average > max)
                    max = average;
            }
            return max;
        }
        static int Proc(Student p, int N)
        {
            int kilk = 0;
            for (int i = 0; i < N; i++)
            {
                if (p.mark1 == 4 || p.mark1 == 5)
                    kilk++;
            }
            kilk = (kilk * 100) / N;
            return kilk;
        }
    }
}
