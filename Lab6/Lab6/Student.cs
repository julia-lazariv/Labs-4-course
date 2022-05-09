// Student.cs
using System;

namespace Lab6
{
    public class Student
    {
        private Man man;
        int year;
        static int counter;
        public class Man
        {
            private string name;
            private int age;
            private string gender;
            private double weight;
            private static int counter = 0;
            public Man()
            {
                name = "";
                age = 0;
                counter++;
            }
            public Man(String name, int age, string gender, double weight)
            {
                this.name = name;
                this.age = age;
                this.gender = gender;
                this.weight = weight;
                counter++;
            }
            public Man(Man m)
            {
                this.name = m.name;
                this.age = m.age;
                this.gender = m.gender;
                this.weight = m.weight;
                counter++;
            }
            public string GetName() { return this.name; }
            public int GetAge() { return this.age; }
            public string getGender() { return this.gender; }
            public double getWeight() { return this.weight; }
            public static int GetCounter() { return counter; }
            public void SetName(String name) { this.name = name; }
            public void SetAge(int age) { this.age = age; }
            public void SetGender(string gender) { this.gender = gender; }
            public void SetWeight(double weight) { this.weight = weight;  }

            public bool Init(string name, int age, string gender, double weight)
            {
                if (age > 0 && age < 100)
                {
                    SetName(name);
                    SetAge(age);
                    SetGender(gender);
                    SetWeight(weight);
                    return true;
                }
                return false;
            }
            public void Display()
            {
                Console.WriteLine("Name: {0}, age: {1}, gender: {2}, weight: {3}", name, age, gender, weight);
            }
            public void Read()
            {
                String n, g;
                int a;
                double w;
                do
                {
                    Console.WriteLine("Name: ");
                    n = Console.ReadLine();
                    Console.WriteLine("Age: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Gender: ");
                    g = Console.ReadLine();
                    Console.WriteLine("Weight: ");
                    w = Convert.ToDouble(Console.ReadLine());
                } while (!Init(n, a, g, w));
            }
            public static Man operator ++(Man m) { return new Man(m.name, m.age, m.gender, m.weight); }

            public static Man operator --(Man m) { return new Man(m.name, m.age, m.gender, m.weight); }
            public override string ToString()
            {
                return "Man: [name: " + this.name + ", "
              + "age: " + this.age + ", " +
              "gender: " + this.gender + ", " +
              "weight: " + this.weight +
              "]";
            }
        }
        public Student()
        {
            this.man = new Man();
            this.year = 0;
            counter++;
        }
        public Student(Man man, int year)
        {
            this.man = man;
            this.year = year;
            counter++;
        }
        public Student(Student student)
        {
            this.man = student.man;
            this.year = student.year;
            counter++;
        }
        public Student(String name, int age, String gender, double weight, int year)
        {
            this.year = year;
            this.man = new Man(name, age, gender, weight);
            counter++;
        }
        public Man GetMan() { return this.man; }
        public int GetYear() { return this.year; }
        public static int GetCounter() { return counter; }

        public void SetMan(Man man) { this.man = man; }
        public void SetYear(int year) { this.year = year; }
        public void Display()
        {
            Console.WriteLine("Year: {0}", this.year);
            this.man.Display();
        }
        public void Read()
        {
            string name, gender;
            int age, year;
            double weight;
            do
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Year: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gender: ");
                gender = Console.ReadLine();
                Console.WriteLine("Weight: ");
                weight = Convert.ToDouble(Console.ReadLine());
            } while (!this.man.Init(name, age, gender, weight));
            this.year = year;
        }
        public static Student operator ++(Student student)
        {
            return new Student(student.man, ++student.year);
        }
        public static Student operator --(Student student)
        {
            return new Student(student.man, --student.year);
        }
        public override string ToString()
        {
            return "Student: [" + this.man.ToString() + ", "
            + "year: " + this.year +
            "]";
        }
    }
}
