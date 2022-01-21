using System.Collections.Generic;

namespace GenericTypes
{
    class Bank<T>
    {
        private readonly List<T> people;
        public Bank()
        {
            people = new List<T>();
        }

        public void AddPerson(T p)
        {
            bool exists = people.Contains(p);
            if (!exists)
            {
                people.Add(p);
            }
        }

        public bool PersonExists(T p)
        {
            return people.Contains(p);
        }
    }
}
