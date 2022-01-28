using System;
using Casting;

namespace DelegatesLambdas
{
    class Account
    {
        public int AccountNumber;
        public Currency Cur;
        public double Amount;

        public Account(int an, Currency c, double am)
        {
            AccountNumber = an;
            Cur = c;
            Amount = am;
        }
        // we cann add negatve amounts as well
        public void Add(double amount)
        {
            Amount += amount;
        }

        public override int GetHashCode()
        {
            return AccountNumber.GetHashCode() ^ Cur.GetCurrencyName().GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            return (AccountNumber == ((Account)obj).AccountNumber);
        }
    }
}
