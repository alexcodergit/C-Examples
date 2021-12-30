using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            List<Person> personList = new List<Person>
            {
                new("A", new DateTime(1975,12,2), true),
                new("B", new DateTime(1976,11,4), false),
                new("C", new DateTime(1977,8,31), true),
                new("D", new DateTime(1974,1,29), true),
                new("E", new DateTime(1973,2,28), false),
                new("F", new DateTime(1978,4,1), false),
                new("G", new DateTime(1980,7,20), false),
                new("H", new DateTime(1982,9,15), false),
            };

            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'where':");

            IEnumerable<Person> query = personList.Where(Person => Person.Age > 45);
            foreach (Person p in query)
            {
                Console.WriteLine($"Person name: {p.Name}, Age: {p.Age}");
            }
            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'order by':");

            query = personList.OrderBy(Person => Person.Age);
            foreach (Person p in query)
            {
                Console.WriteLine($"Person name: {p.Name}, Age: {p.Age}");
            }

            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'group by':");

            var groupQuery = from Person in personList
                             group Person by Person.Smoker into newGroup
                             orderby newGroup.Key
                             select newGroup;

            foreach (var personGroup in groupQuery)
            {
                Console.WriteLine($"Smoker: {personGroup.Key}");
                foreach (Person p in personGroup)
                {
                    Console.WriteLine($"Person name: {p.Name}, Age: {p.Age}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'any':");

            if (personList.Any(p => p.Age == 50))
            {
                Console.WriteLine("There is Person(s) 50 years old.");
            }
            else
            {
                Console.WriteLine("Mo Persons are 50 years old.");
            }

            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'all':");

            if (personList.All(p => p.Age < 50))
            {
                Console.WriteLine("All Persons younger than 50 years.");
            }
            else
            {
                Console.WriteLine("Some persons are 50 years or older.");
            }

            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'sum':");

            int age = (from p in personList select p.Age).Sum();
            Console.WriteLine($"Sum of Person's age is {age}");

            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'min':");

            age = (from p in personList select p.Age).Min();
            Console.WriteLine($"The youngest Person is {age} years old.");

            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'max':");

            age = (from p in personList select p.Age).Max();
            Console.WriteLine($"The oldest Person is {age} years old.");

            Console.ReadKey();
        }
    }
}
