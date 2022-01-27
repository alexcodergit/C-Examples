using Casting;
using static System.Console;
using System;

namespace GenericTypes
{
    class Program
    {
        static void Main()
        {
            WriteLine("Working with generic objects.");
            Bank<Client> clientBank = new();
            var c1 = new Client("C1") { Id = 1 };
            var c2 = new Client("C2") { Id = 2 };
            clientBank.AddPerson(c1);
            clientBank.AddPerson(c2);
            // this will not work, parameter of wrong type
            //clientBank.AddPerson(new Employee("B") { Id = 2});

            WriteLine("Lookup for person in Client Bank template");
            if (clientBank.PersonExists(c2))
            {
                WriteLine($"Person {c2.Name} found");
            }
            else
            {
                WriteLine($"Person {c2.Name} not found");
            }
            var e1 = new Employee("E1") { Id = 1 };
            var e2 = new Employee("E2") { Id = 3 };
            Bank<Employee> employeeBank = new();
            employeeBank.AddPerson(e1);
            employeeBank.AddPerson(e2);
            // this will not work, parameter of wrong type
            //employeeBank.AddPerson(c1);
            WriteLine("Lookup for person in Employee Bank template");
            if (employeeBank.PersonExists(e2))
            {
                WriteLine($"Person {e2.Name} found");
            }
            else
            {
                WriteLine($"Person {e2.Name} not found");
            }
            WriteLine();

            // Converting currencies
            Ruble rub = new();
            rub.UnitsPerUsd = 78;
            Hrivna hrivna = new();
            hrivna.UnitsPerUsd = 29;
            // generc exchange
            Exchange<Currency> exchange = new();
            double amount = 1000;
            double amountOfHrivnas = exchange.Convert(amount, rub, hrivna);
            WriteLine($"{amount} of {rub.GetCurrencyName()} equal to {hrivna.GetCurrencyName()} of {amountOfHrivnas}");

            // star tasks
            // properties of Contravariant generic objects
            IContravariant<object> contraObj = new ContravariantClass<object>();
            IContravariant<Dummy> dummyContraObj = new ContravariantClass<Dummy>();
            // implicit conversion, works
            dummyContraObj = contraObj;
            // this will not work, because contravariant
            //myObj = anotherObj;
            if (dummyContraObj != contraObj)
            {
                throw new Exception("Objects must be equal");
            }
            // properties of Covariant generic objects
            ICovariant<object> covariantObj = new CovariantClass<object>();
            ICovariant<Dummy> dummyCovariantObj = new CovariantClass<Dummy>();
            // this will work, because covariant
            covariantObj = dummyCovariantObj;
            // this will not work
            //dummyCovariantObj = covariantObj;
            if (covariantObj != dummyCovariantObj)
            {
                throw new Exception("Objects must be equal");
            }
        }
    }
}
