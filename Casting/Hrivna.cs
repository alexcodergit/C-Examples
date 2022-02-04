using System;
namespace Casting
{
    public class Hrivna : Currency
    {
        public Hrivna() { }

        public override string GetCurrencyName()
        {
            return "UAH";
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            return (GetCurrencyName() == ((Hrivna)obj).GetCurrencyName());
        }
        public override int GetHashCode()
        {
            return "Hrivna".GetHashCode();
        }
    }
}
