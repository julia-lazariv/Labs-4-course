using System;
using System.Text;

namespace Lab9._2_2_
{
    class Program
    {
        enum Cpes { KOMP, INFORM, MATANEKONOM, FIZIKA, TRUDOVE };
        static string[] posadaStr = { "КН", "Інформатикa", "Математика економіка", "Фізикa", "Трудове навчання" };
        struct Student
        {
            public string prizv;
            public uint rik_nar;
            public uint kurs;
            public int fizik, matem;
            public int prog, chiselniMetod, pedagogic;
            public Cpes spec;
            public int serbal;
            public double func;
        };
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default; // Коректне відображення української мови при виведенні

            Console.Write("Введіть N: ");
            int N = Convert.ToInt32(Console.ReadLine()); // вхідний параметр

            Student p = new Student();
            int menuItem;
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Виберіть дію:");
                Console.WriteLine();
                Console.WriteLine("[1] - введення даних з клавіатури");
                Console.WriteLine("[2] - вивід даних на екран");
                Console.WriteLine("[3] - індексне впорядкування та вивід даних");
                Console.WriteLine();
                Console.WriteLine("[0] - вихід та завершення роботи програми");
                Console.Write("Введіть значення: ");
                menuItem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                switch (menuItem)
                {
                    case 1:
                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine("студент № " + i + ":");
                            Console.Write("прізвище: ");
                            p.prizv = Console.ReadLine();
                            Console.Write("рік народження: ");
                            p.rik_nar = Convert.ToUInt32(Console.ReadLine());
                            Console.Write("курс: ");
                            p.kurs = Convert.ToUInt32(Console.ReadLine());
                            Console.Write("спеціальність (0 - математика, 1 - інформатика, 2 - трудове навчання, 3 - комп'ютерні науки): ");
                            p.spec = (Cpes)Convert.ToInt32(Console.ReadLine());
                            switch (p.spec.ToString())
                            {
                                case "KOMP":
                                    Console.Write("програмування: ");
                                    p.prog = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case "INFORM":
                                    Console.Write("інформатика: ");
                                    p.chiselniMetod = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case "MATANEKONOM":
                                    break;
                                case "FIZIKA":
                                    break;
                                case "TRUDOVE":
                                    Console.Write("педагогіка: ");
                                    p.pedagogic = Convert.ToInt32(Console.ReadLine());
                                    break;
                            }
                            Console.Write("фізика: ");
                            p.fizik = Convert.ToInt32(Console.ReadLine());
                            Console.Write("математика: ");
                            p.matem = Convert.ToInt32(Console.ReadLine());
                            p.serbal = serbal1(p);
                            p.func = func(p);
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Print(p, N);
                        break;
                    case 3:
                        // PrintIndexSorted(p, IndexSort(p, N), N);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Ви ввели помилкове значення! " +
                            "Слід ввести число - номер вибраного пункту меню");
                        break;
                }
            } while (menuItem != 0);
        }
        static void Print(Student p, int N)
        {
            Console.WriteLine("====================================================================================================================");
            Console.WriteLine("| № | Прізвище студента |  Курс |   Спеціальність  | Оцінка з фізики | Оцінка з математики | Оцінка з предмету | ");
            for (int i = 0; i < N; i++)
            {
                Console.Write("| " + " " + i + " ");
                Console.Write("| " + " " + p.prizv + " ");
                Console.Write("| " + " " + p.rik_nar + " ");
                Console.Write("| " + " " + p.kurs + " ");
                Console.Write("| " + " " + p.spec + " ");
                switch (p.spec.ToString())
                {
                    case "KOMP":
                        Console.Write("| " + " " + p.prog + " ");
                        break;
                    case "INFORM":
                        Console.Write("| " + " " + p.chiselniMetod + " ");
                        break;
                    case "MATANEKONOM":
                        Console.Write("| " + " " + p.pedagogic + " ");
                        break;
                    case "FIZIKA":
                        break;
                    case "TRUDOVE":
                        Console.Write("| " + " " + p.pedagogic + " ");
                        break;
                }
                Console.Write("| " + " " + p.fizik + "| ");
                Console.Write("| " + " " + p.matem + "| ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("====================================================================================================================");
            Console.WriteLine();
        }
        static int serbal1(Student p)
        {
            int k = 0;
            k = p.fizik + p.matem;
            if (p.spec.ToString() == "KOMP")
            {
                k = k + p.prog;
            }
            if (p.spec.ToString() == "INFORM")
            {
                k = k + p.chiselniMetod;
            }
            if (p.spec.ToString() == "MATANEKONOM" || 
                p.spec.ToString() == "FIZIKA" || 
                p.spec.ToString() == "TRUDOVE")
            {
                k = k + p.pedagogic;
            }
            return k / 3;
        }
        static double func(Student p)
        {
            if (p.spec.ToString() == "KOMP")
            {
                return p.prog;
            }
            if (p.spec.ToString() == "INFORM")
            {
                return p.chiselniMetod;

            }
            if (p.spec.ToString() == "MATANEKONOM" ||
                p.spec.ToString() == "FIZIKA" ||
                p.spec.ToString() == "TRUDOVE")
            {
                return p.pedagogic;
            }
            return 0;
        }
    }
}
