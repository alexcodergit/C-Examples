using System;

namespace GenericTypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Working with generic objects.");
            Bank<Client> clientBank = new();
            var c1 = new Client("C1") { Id = 1 };
            var c2 = new Client("C2") { Id = 2 };
            clientBank.AddPerson(c1);
            clientBank.AddPerson(c2);
            // this will not work, parameter of wrong type
            //clientBank.AddPerson(new Employee("B") { Id = 2});

            Console.WriteLine("Lookup for person in Client Bank template");
            if (clientBank.PersonExists(c2))
            {
                Console.WriteLine($"Person {c2.Name} found");
            }
            else
            {
                Console.WriteLine($"Person {c2.Name} not found");
            }
            var e1 = new Employee("E1") { Id = 1 };
            var e2 = new Employee("E2") { Id = 3 };
            Bank<Employee> employeeBank = new();
            employeeBank.AddPerson(e1);
            employeeBank.AddPerson(e2);
            // this will not work, parameter of wrong type
            //employeeBank.AddPerson(c1);
            Console.WriteLine("Lookup for person in Employee Bank template");
            if (employeeBank.PersonExists(e2))
            {
                Console.WriteLine($"Person {e2.Name} found");
            }
            else
            {
                Console.WriteLine($"Person {e2.Name} not found");
            }
            Console.WriteLine();
        }
    }
}
