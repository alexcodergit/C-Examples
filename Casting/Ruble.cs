using System;

namespace Casting
{
    public class Ruble : Currency
    {
        public Ruble() { }

        public override string GetCurrencyName()
        {
            return "RUB";
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            return (GetCurrencyName() == ((Ruble)obj).GetCurrencyName());
        }
        public override int GetHashCode()
        {
            return "RUB".GetHashCode();
        }
    }
}
