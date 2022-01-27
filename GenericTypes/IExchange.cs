using Casting;

namespace GenericTypes
{
    interface IExchange<Cur> where Cur : Currency
    {
        double Convert(double amount, Cur fromCurrency, Cur toCurrency);
    }
}
