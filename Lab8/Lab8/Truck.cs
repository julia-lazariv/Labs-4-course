// Truck.cs
using System;

namespace Lab8
{
    public class Truck : Vehicle
    {
        private double load_capacity;
        public Truck() { 
           this.SetBrand(""); 
           this.SetCapacity(0);
           this.SetPower(0);
           this.SetLoadCapacity(0);
        }
        ~Truck()
        {
            this.SetBrand("");
            this.SetCapacity(0);
            this.SetPower(0);
            this.SetLoadCapacity(0);
        }

        public Truck(string brand, double capacity, int power, double load_capacity)
        {
            SetBrand(brand);
            SetCapacity(capacity);
            SetPower(power);
            SetLoadCapacity(load_capacity);
        }

        public Truck(Truck r)
        {
            SetBrand(r.GetBrand());
            SetCapacity(r.GetCapacity());
            SetPower(r.GetPower());
            SetLoadCapacity(r.GetLoadCapacity());
        }
        public double GetLoadCapacity() { return this.load_capacity; }

        public void SetLoadCapacity(double value) { this.load_capacity = value; }
        public static Truck operator +(Truck l, Truck r)
        {
            Truck t = new Truck();
            double a = l.GetCapacity() + r.GetCapacity();
            int b = l.GetPower() + r.GetPower();
            double c = l.GetLoadCapacity() + r.GetLoadCapacity();
            t.SetCapacity(a);
            t.SetPower(b);
            t.SetLoadCapacity(c);
            return t;
        }
        public static Truck operator *(Truck l, Truck r)
        {
            Truck t = new Truck();
            double a = l.GetCapacity() * r.GetCapacity();
            int b = l.GetPower() * r.GetPower();
            double c = l.GetLoadCapacity() * r.GetLoadCapacity();
            t.SetCapacity(a);
            t.SetPower(b);
            t.SetLoadCapacity(c);
            return t;
        }
        public static Truck operator *(Truck l, int k)
        {
            Truck t = new Truck();
            double a = l.GetCapacity() * k;
            int b = l.GetPower() * k;
            double c = l.GetLoadCapacity() * k; 
            while (b > 99)
            {
                b -= 100;
                a++;
            }
            t.SetCapacity(a);
            t.SetPower(b);
            t.SetLoadCapacity(c);
            return t;
        }
        public static Truck operator -(Truck l, Truck r)
        {
            Truck t = new Truck();
            double a = l.GetCapacity() - r.GetCapacity();
            int b = l.GetPower() - r.GetPower();
            double c = l.GetLoadCapacity() - r.GetLoadCapacity();
            t.SetCapacity(a);
            t.SetPower(b);
            t.SetLoadCapacity(c);
            return t;
        }
        public static double operator /(Truck l, Truck r)
        {
            double z1 = l.GetCapacity() / l.GetPower();
            double z2 = r.GetCapacity() / r.GetLoadCapacity();
            return z1 / z2;
        }
        public void Read()
        {
            base.Read();
            Console.WriteLine("Load capacity: ");
            this.load_capacity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }
        public override string ToString()
        {
            return "Vehicle[" + "Brand: " + this.GetBrand() + "," +
                " Capacity: " + this.GetCapacity() + "," +
                " Power: " + this.GetPower() + "," +
                " Load capacity: " + this.GetLoadCapacity() + "]";
        }
    }
}
