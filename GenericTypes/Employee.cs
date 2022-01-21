using System;

namespace GenericTypes
{
    class Employee : Person
    {
        public Employee(string n) : base(n) { }
        public int Id
        {
            get;
            init;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }

            return Id == ((Employee)obj).Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
