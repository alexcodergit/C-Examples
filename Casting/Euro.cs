using System;

namespace Casting
{
    public class Euro : Currency
    {
        public Euro() { }

        public override string GetCurrencyName()
        {
            return "EUR";
        }
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            return (GetCurrencyName() == ((Euro)obj).GetCurrencyName());
        }
        public override int GetHashCode()
        {
            return "EUR".GetHashCode();
        }
    }
}
