using System;

namespace GenericTypes
{
    class Client : Person
    {
        public double Balance { get; set; }
        public Client(string n) : base(n)
        {
            Balance = 0;
        }

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

            return Id == ((Client)obj).Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
