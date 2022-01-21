using System;
using System.Collections.Generic;
using Casting;

namespace ListDictionary
{
    class Client
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int PassportNum { get; set; }
        virtual public double Balance { get; set; }

        public Client(string fn, string sn, int pn, double bal)
        {
            FirstName = fn;
            SecondName = sn;
            PassportNum = pn;
            Balance = bal;
        }
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^
                SecondName.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }

            return (FirstName == ((Client)obj).FirstName) &&
                (SecondName == ((Client)obj).SecondName);
        }
    }


    class MultiCurrencyClient : Client
    {
        private readonly Dictionary<Currency, double> balances;

        public MultiCurrencyClient(string fn, string sn, int pn) : base(fn, sn, pn, 0)
        {
            balances = new Dictionary<Currency, double>();
        }
        public void AddAmount(Currency cur, double amount)
        {
            if (balances.ContainsKey(cur))
            {
                balances[cur] += amount;
            }
            else
            {
                balances[cur] = amount;
            }
        }

        public override double Balance
        {
            get
            {
                double usdAmount = 0;
                USDollar convertTo = new();
                foreach (var entry in balances)
                {
                    usdAmount += Currency.ConvertCurrency(entry.Key, convertTo, entry.Value);
                }
                return usdAmount;
            }
            set { }
        }

        public double GetAmount(Currency cur)
        {
            if (balances.ContainsKey(cur))
            {
                return balances[cur];
            }
            else
            {
                throw new ArgumentException($"Non existing currency {cur}");
            }
        }

        public void OutputBalances()
        {
            foreach (var entry in balances)
            {
                Console.WriteLine($"Currency {entry.Key.GetCurrencyName()}, amount {entry.Value}");
            }
        }
    }
}
