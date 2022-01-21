using System;

namespace Casting
{
    public abstract class Currency
    {
        private double _unitsPerUsd;
        public double UnitsPerUsd
        {
            get => _unitsPerUsd;
            set => _unitsPerUsd = value;
        }
        public Currency() { }
        abstract public string GetCurrencyName();

        public static double ConvertCurrency(Currency from, Currency to, double amount)
        {
            if (from.GetType() == to.GetType())
            {
                return amount;
            }

            double fromInUs = amount / GetUnitsPerUSD(from);
            double retAmount = fromInUs * GetUnitsPerUSD(to);
            return retAmount;
        }

        private static double GetUnitsPerUSD(Currency cur)
        {
            if (cur.GetType() == typeof(Euro))
            {
                return ((Euro)cur).UnitsPerUsd;
            }
            else if (cur.GetType() == typeof(Ruble))
            {
                return ((Ruble)cur).UnitsPerUsd;
            }
            else if (cur.GetType() == typeof(Hrivna))
            {
                return ((Hrivna)cur).UnitsPerUsd;
            }
            else if ((cur.GetType() == typeof(USDollar)))
            {
                return ((USDollar)cur).UnitsPerUsd;
            }
            else
            {
                throw new ArgumentException($"Unknown Currency {cur.GetCurrencyName()}");
            }
        }
    }
}
