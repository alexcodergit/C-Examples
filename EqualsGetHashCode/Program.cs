using System;

namespace EqualsGetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new("P1", "P2", "city1", new DateTime(1980, 10, 10));
            person1.PassportNumber = 1;
            Person person2 = new("P1", "P2", "city1", new DateTime(1980, 10, 10));
            person2.PassportNumber = 2;
            if (person1.Equals(person2))
            {
                Console.WriteLine("Person1.Equals(Person2), even when passport numbers are not equal.");
            }
            if (person1 == person2)
            {
                Console.WriteLine("Person1 == Person2, because operator== is overloaded.");
            }
            CheckStringEquality();
            Console.ReadKey();
        }

        static void CheckStringEquality()
        {
            string a = new("abc");
            string b = new("abc");

            if (a == b)
            {
                Console.WriteLine("Method Equal for strings is properly defined");
            }
            else
            {
                Console.WriteLine("Method Equal for strings is not properly defned");
            }
        }
    }
}
