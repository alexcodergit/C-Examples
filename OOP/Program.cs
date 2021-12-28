using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Vehicle> vehicles = new LinkedList<Vehicle>();
            vehicles.AddFirst(new Car(200));
            vehicles.AddFirst(new Amphibia(100));
            vehicles.AddFirst(new Airplane(1000));
            vehicles.AddFirst(new Rocket(10000));
            vehicles.AddFirst(new Boat(50));
            vehicles.AddFirst(new UBoat(50));

            foreach (var veh in vehicles)
            {
                DescribeClass(veh);
            }
            Console.ReadLine();
        }

        static void DescribeClass(Vehicle veh)
        {
            Console.WriteLine("##############################");
            Console.WriteLine($"Class Name {veh.GetClassName()}");
            Console.WriteLine($"Max Speed {veh.GetMaxSpeed()}");
            Console.WriteLine("Can operate in following environments:");
            foreach (OperatingEnvironment e in veh.GetEnvironment())
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("##############################");
        }
    }
}
