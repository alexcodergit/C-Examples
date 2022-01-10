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
            List<Person> personList = new()
            {
                new("A1", new DateTime(1950, 1, 1), true),
                new("A2", new DateTime(1951, 2, 2), false),
                new("A3", new DateTime(1952, 3, 3), true),
                new("A4", new DateTime(1953, 4, 4), false),
                new("A5", new DateTime(1954, 5, 5), true),
                new("A6", new DateTime(1955, 6, 6), false),
                new("A7", new DateTime(1956, 7, 7), true),
                new("A8", new DateTime(1957, 8, 8), false),
                new("A9", new DateTime(1958, 9, 9), true),
                new("A10", new DateTime(1959, 10, 10), false),
                new("A11", new DateTime(1960, 11, 11), true),
                new("A12", new DateTime(1961, 12, 12), false),
                new("A13", new DateTime(1962, 1, 13), true),
                new("A14", new DateTime(1963, 2, 14), false),
                new("A15", new DateTime(1964, 3, 15), true),
                new("A16", new DateTime(1965, 4, 16), false),
                new("A17", new DateTime(1966, 5, 17), true),
                new("A18", new DateTime(1967, 6, 18), false),
                new("A19", new DateTime(1968, 7, 19), true),
                new("A20", new DateTime(1969, 8, 20), false),
                new("A21", new DateTime(1970, 9, 21), true),
                new("A22", new DateTime(1971, 10, 22), false),
                new("A23", new DateTime(1972, 11, 23), true),
                new("A24", new DateTime(1973, 12, 24), false),
                new("A25", new DateTime(1974, 1, 25), true),
                new("A26", new DateTime(1975, 2, 26), false),
                new("A27", new DateTime(1976, 3, 27), true),
                new("A28", new DateTime(1977, 4, 28), false),
                new("A29", new DateTime(1978, 5, 29), true),
                new("A30", new DateTime(1979, 6, 1), false),
                new("A31", new DateTime(1980, 7, 2), true),
                new("A32", new DateTime(1981, 8, 3), false),
                new("A33", new DateTime(1982, 9, 4), true),
                new("A34", new DateTime(1983, 10, 5), false),
                new("A35", new DateTime(1984, 11, 6), true),
                new("A36", new DateTime(1985, 12, 7), false),
                new("A37", new DateTime(1986, 1, 8), true),
                new("A38", new DateTime(1987, 2, 9), false),
                new("A39", new DateTime(1988, 3, 10), true),
                new("A40", new DateTime(1989, 4, 11), false),
                new("A41", new DateTime(1990, 5, 12), true),
                new("A42", new DateTime(1991, 6, 13), false),
                new("A43", new DateTime(1992, 7, 14), true),
                new("A44", new DateTime(1993, 8, 15), false),
                new("A45", new DateTime(1994, 9, 16), true),
                new("A46", new DateTime(1995, 10, 17), false),
                new("A47", new DateTime(1996, 11, 18), true),
                new("A48", new DateTime(1997, 12, 19), false),
                new("A49", new DateTime(1998, 1, 20), true),
                new("A50", new DateTime(1999, 2, 21), false),
                new("A51", new DateTime(2000, 3, 22), true),
                new("A52", new DateTime(1950, 4, 23), false),
                new("A53", new DateTime(1951, 5, 24), true),
                new("A54", new DateTime(1952, 6, 25), false),
                new("A55", new DateTime(1953, 7, 26), true),
                new("A56", new DateTime(1954, 8, 27), false),
                new("A57", new DateTime(1955, 9, 28), true),
                new("A58", new DateTime(1956, 10, 29), false),
                new("A59", new DateTime(1957, 11, 30), true),
                new("A60", new DateTime(1958, 12, 1), false),
                new("A61", new DateTime(1959, 1, 2), true),
                new("A62", new DateTime(1960, 2, 3), false),
                new("A63", new DateTime(1961, 3, 4), true),
                new("A64", new DateTime(1962, 4, 5), false),
                new("A65", new DateTime(1963, 5, 6), true),
                new("A66", new DateTime(1964, 6, 7), false),
                new("A67", new DateTime(1965, 7, 8), true),
                new("A68", new DateTime(1966, 8, 9), false),
                new("A69", new DateTime(1967, 9, 10), true),
                new("A70", new DateTime(1968, 10, 11), false),
                new("A71", new DateTime(1969, 11, 12), true),
                new("A72", new DateTime(1970, 12, 13), false),
                new("A73", new DateTime(1971, 1, 14), true),
                new("A74", new DateTime(1972, 2, 15), false),
                new("A75", new DateTime(1973, 3, 16), true),
                new("A76", new DateTime(1974, 4, 17), false),
                new("A77", new DateTime(1975, 5, 18), true),
                new("A78", new DateTime(1976, 6, 19), false),
                new("A79", new DateTime(1977, 7, 20), true),
                new("A80", new DateTime(1978, 8, 21), false),
                new("A81", new DateTime(1979, 9, 22), true),
                new("A82", new DateTime(1980, 10, 23), false),
                new("A83", new DateTime(1981, 11, 24), true),
                new("A84", new DateTime(1982, 12, 25), false),
                new("A85", new DateTime(1983, 1, 26), true),
                new("A86", new DateTime(1984, 2, 27), false),
                new("A87", new DateTime(1985, 3, 28), true),
                new("A88", new DateTime(1986, 4, 29), false),
                new("A89", new DateTime(1987, 5, 30), true),
                new("A90", new DateTime(1988, 6, 1), false),
                new("A91", new DateTime(1989, 7, 2), true),
                new("A92", new DateTime(1990, 8, 3), false),
                new("A93", new DateTime(1991, 9, 4), true),
                new("A94", new DateTime(1992, 10, 5), false),
                new("A95", new DateTime(1993, 11, 6), true),
                new("A96", new DateTime(1994, 12, 7), false),
                new("A97", new DateTime(1995, 1, 8), true),
                new("A98", new DateTime(1996, 2, 9), false),
                new("A99", new DateTime(1997, 3, 10), true),
                new("A100", new DateTime(1998, 4, 11), false)

            };

            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'where':");

            IEnumerable<Person> query = personList.Where(Person => Person.Age > 45);
            foreach (var p in query)
            {
                Console.WriteLine($"Person name: {p.Name}, Age: {p.Age}");
            }
            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'order by':");

            query = personList.OrderBy(Person => Person.Age);
            foreach (var p in query)
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
                foreach (var p in personGroup)
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
