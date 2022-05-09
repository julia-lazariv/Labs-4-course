// Program.cs
using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student: {0}", Student.GetCounter());
            Console.WriteLine("Student::Man: {0}", Student.Man.GetCounter());

            Student student = new Student("Valera", 25, "Male", 75.2, 3);
            Console.WriteLine("Student local: {0}", Student.GetCounter());
            Console.WriteLine("Student::Man local: {0}",
            Student.Man.GetCounter());
            Console.WriteLine("s2: {0}", student.ToString());
            student++;
            Console.WriteLine("s2++: {0}", student.ToString());
        }
    }
}
