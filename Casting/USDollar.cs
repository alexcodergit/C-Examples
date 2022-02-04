using System;

namespace Casting
{
    public class USDollar : Currency
    {
        private const double _unitsPerUsd = 1.0;
        public new double UnitsPerUsd
        {
            get => _unitsPerUsd;
            set { }
        }
        public USDollar() { }

        public override string GetCurrencyName()
        {
            return "USD";
        }
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            return (GetCurrencyName() == ((USDollar)obj).GetCurrencyName());
        }
        public override int GetHashCode()
        {
            return "USD".GetHashCode();
        }
    }
}
