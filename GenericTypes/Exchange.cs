using Casting;

namespace GenericTypes
{
    class Exchange<Cur> : IExchange<Cur> where Cur : Currency
    {
        public double Convert(double amount, Cur fromCurrency, Cur toCurrency)
        {
            double fromInUs = amount / fromCurrency.UnitsPerUsd;
            double retAmount = fromInUs * toCurrency.UnitsPerUsd;
            return retAmount;
        }
    }
}
