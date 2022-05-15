// Car.cs
using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle veh = new Vehicle();
            veh.Read();
            Console.WriteLine(veh);

            Truck truck = new Truck();
            truck.Read();
            Console.WriteLine(truck);

            Car car = new Car();
            car.Read();
            Console.WriteLine(car);
        }
    }
}