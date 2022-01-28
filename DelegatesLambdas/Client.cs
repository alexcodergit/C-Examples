using System;

namespace DelegatesLambdas
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Name.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            return (Id == ((Client)obj).Id) && (Name == ((Client)obj).Name);
        }
    }
}
