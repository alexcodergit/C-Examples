using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Person
    {
        public string Name { get; }
        public int Age { get => (int)(DateTime.Now - DoB).TotalDays / 365; }
        public DateTime DoB { get; }
        public bool Smoker { get; }
        public Person(string n, DateTime dob, bool sm)
        {
            Name = n;
            DoB = dob;
            Smoker = sm;
        }
    }
}
