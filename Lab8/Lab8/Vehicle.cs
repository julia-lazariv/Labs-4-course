// Vehicle.cs
using System;

namespace Lab8
{
    public class Vehicle
    {
        private string brand;
        private double capacity;
        private int power;
        public Vehicle() {
           this.brand = ""; 
           this.capacity = 0;
           this.power = 0;
        }
        ~Vehicle()
        {
            this.brand = "";
            this.capacity = 0;
            this.power = 0;
        }
        public Vehicle(string brand, double capacity, int power) 
        { 
           this.brand = brand; 
           this.capacity = capacity;
           this.power = power;
        }
        public Vehicle(Vehicle r) {
           this.brand = r.brand;
           this.capacity = r.capacity;
           this.power = r.power;
        }
        public string GetBrand() { return this.brand; }
        public double GetCapacity() { return this.capacity; }
        public int GetPower() { return this.power; }

        public void SetBrand(string value) { this.brand = value; }

        public void SetCapacity(double value) { this.capacity = value; }
        public void SetPower(int value) { this.power = value; }
        public static Vehicle operator +(Vehicle x, Vehicle y)
        { 
           return new Vehicle(x.brand, x.capacity + y.capacity, x.power + y.power); 
        }
        public static Vehicle operator -(Vehicle x, Vehicle y)
        {
           return new Vehicle(x.brand, x.capacity - y.capacity, x.power - y.power);
        }
        public static Vehicle operator *(Vehicle x, Vehicle y)
        {
            return new Vehicle(x.brand, x.capacity - y.capacity, x.power - y.power);
        }
        public static Vehicle operator *(Vehicle x, int num)
        {
           return new Vehicle(x.brand, x.capacity * num, x.power * num);
        }
        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Brand: ");
            this.brand = Console.ReadLine();
            Console.WriteLine("Capacity: ");
            this.capacity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Power: ");
            this.power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        public override string ToString()
        { 
            return "Vehicle[" + "Brand: " + this.brand + "," +
                " Capacity: " + this.capacity + "," +
                " Power: " + this.power + "]"; 
        }
    }
}
