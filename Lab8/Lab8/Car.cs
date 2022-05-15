// Car.cs
using System;

namespace Lab8
{
    public class Car : Vehicle
    {
        private string color;
        public Car()
        {
            this.SetBrand("");
            this.SetCapacity(0);
            this.SetPower(0);
            this.SetColor("");
        }
        ~Car()
        {
            this.SetBrand("");
            this.SetCapacity(0);
            this.SetPower(0);
            this.SetColor("");
        }

        public Car(string brand, double capacity, int power, string color)
        {
            SetBrand(brand);
            SetCapacity(capacity);
            SetPower(power);
            SetColor(color);
        }

        public Car(Car r)
        {
            SetBrand(r.GetBrand());
            SetCapacity(r.GetCapacity());
            SetPower(r.GetPower());
            SetColor(r.GetColor());
        }
        public string GetColor() { return this.color; }

        public void SetColor(string value) { this.color = value; }

        public static Car operator +(Car l, Car r)
        {
            Car t = new Car();
            double a = l.GetCapacity() + r.GetCapacity();
            int b = l.GetPower() + r.GetPower();
            t.SetCapacity(a);
            t.SetPower(b);
            return t;
        }
        public static Car operator *(Car l, Car r)
        {
            Car t = new Car();
            double a = l.GetCapacity() * r.GetCapacity();
            int b = l.GetPower() * r.GetPower();
            t.SetCapacity(a);
            t.SetPower(b);
            return t;
        }
        public static Car operator *(Car l, int k)
        {
            Car t = new Car();
            double a = l.GetCapacity() * k;
            int b = l.GetPower() * k;
            t.SetCapacity(a);
            t.SetPower(b);
            return t;
        }
        public static Car operator -(Car l, Car r)
        {
            Car t = new Car();
            double a = l.GetCapacity() - r.GetCapacity();
            int b = l.GetPower() - r.GetPower();
            t.SetCapacity(a);
            t.SetPower(b);
            return t;
        }
        public static double operator /(Car l, Car r)
        {
            double z1 = l.GetCapacity() / l.GetPower();
            double z2 = r.GetCapacity() / r.GetPower();
            return z1 / z2;
        }
        public void Read()
        {
            base.Read();
            Console.WriteLine("Color: ");
            this.color = Console.ReadLine();
            Console.WriteLine();
        }
        public override string ToString()
        {
            return "Vehicle[" + "Brand: " + this.GetBrand() + "," +
                " Capacity: " + this.GetCapacity() + "," +
                " Power: " + this.GetPower() + "," +
                " Color: " + this.GetColor() + "]";
        }
    }
}
