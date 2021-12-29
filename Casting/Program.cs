using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            USDollar dollar = new();
            Euro euro = new();
            Ruble ruble = new();
            Hrivna hrivna = new();

            euro.UnitsPerUsd = 0.8842M;
            ruble.UnitsPerUsd = 73.70M;
            hrivna.UnitsPerUsd = 27.234M;

            int amount = 10;
            decimal converted = ConvertCurrency(euro, dollar, amount);
            Console.WriteLine($"{amount} {euro.GetCurrencyName()} = {converted} {dollar.GetCurrencyName()}");

            converted = ConvertCurrency(dollar, euro, amount);
            Console.WriteLine($"{amount} {dollar.GetCurrencyName()} = {converted} {euro.GetCurrencyName()}");

            converted = ConvertCurrency(euro, ruble, amount);
            Console.WriteLine($"{amount} {euro.GetCurrencyName()} = {converted} {ruble.GetCurrencyName()}");

            converted = ConvertCurrency(ruble, euro, amount);
            Console.WriteLine($"{amount} {ruble.GetCurrencyName()} = {converted} {euro.GetCurrencyName()}");

            converted = ConvertCurrency(hrivna, dollar, amount);
            Console.WriteLine($"{amount} {hrivna.GetCurrencyName()} = {converted} {dollar.GetCurrencyName()}");

            converted = ConvertCurrency(dollar, hrivna, amount);
            Console.WriteLine($"{amount} {dollar.GetCurrencyName()} = {converted} {hrivna.GetCurrencyName()}");

            Console.ReadLine();
        }

        static decimal ConvertCurrency(Currency from, Currency to, int amount)
        {
            if (from.GetType() == to.GetType())
            {
                return amount;
            }
            if (from.GetType() == typeof(Euro))
            {
                decimal fromInUs = amount / ((Euro)from).UnitsPerUsd;
                if (to.GetType() == typeof(Ruble))
                {
                    decimal retAmount = fromInUs * ((Ruble)to).UnitsPerUsd;
                    return retAmount;
                }
                else if (to.GetType() == typeof(USDollar))
                {
                    decimal retAmount = fromInUs * ((USDollar)to).UnitsPerUsd;
                    return retAmount;
                }
                else if (to.GetType() == typeof(Hrivna))
                {
                    decimal retAmount = fromInUs * ((Hrivna)to).UnitsPerUsd;
                    return retAmount;
                }
                else
                {
                    throw new ArgumentException($"Unknown Currency {to.GetCurrencyName()}");
                }
            }
            else if (from.GetType() == typeof(USDollar))
            {
                decimal fromInUs = 1.0M;
                if (to.GetType() == typeof(Ruble))
                {
                    decimal retAmount = fromInUs * ((Ruble)to).UnitsPerUsd;
                    return retAmount;
                }
                else if (to.GetType() == typeof(Euro))
                {
                    decimal retAmount = fromInUs * ((Euro)to).UnitsPerUsd;
                    return retAmount;
                }
                else if (to.GetType() == typeof(Hrivna))
                {
                    decimal retAmount = fromInUs * ((Hrivna)to).UnitsPerUsd;
                    return retAmount;
                }
                else
                {
                    throw new ArgumentException($"Unknown Currency {to.GetCurrencyName()}");
                }
            }
            else if (from.GetType() == typeof(Ruble))
            {
                decimal fromInUs = amount / ((Ruble)from).UnitsPerUsd;
                if (to.GetType() == typeof(USDollar))
                {
                    decimal retAmount = fromInUs * ((USDollar)to).UnitsPerUsd;
                    return retAmount;
                }
                else if (to.GetType() == typeof(Hrivna))
                {
                    decimal retAmount = fromInUs * ((Hrivna)to).UnitsPerUsd;
                    return retAmount;
                }
                else if (to.GetType() == typeof(Euro))
                {
                    decimal retAmount = fromInUs * ((Euro)to).UnitsPerUsd;
                    return retAmount;
                }
                else
                {
                    throw new ArgumentException($"Unknown Currency {to.GetCurrencyName()}");
                }
            }
            else if (from.GetType() == typeof(Hrivna))
            {
                decimal fromInUs = amount / ((Hrivna)from).UnitsPerUsd;
                if (to.GetType() == typeof(USDollar))
                {
                    decimal retAmount = fromInUs * ((USDollar)to).UnitsPerUsd;
                    return retAmount;
                }
                else if (to.GetType() == typeof(Euro))
                {
                    decimal retAmount = fromInUs * ((Euro)to).UnitsPerUsd;
                    return retAmount;
                }
                if (to.GetType() == typeof(Ruble))
                {
                    decimal retAmount = fromInUs * ((Ruble)to).UnitsPerUsd;
                    return retAmount;
                }
                else
                {
                    throw new ArgumentException($"Unknown Currency {to.GetCurrencyName()}");
                }
            }
            else
            {
                throw new ArgumentException($"Unknown Currency {from.GetCurrencyName()}");
            }
        }
    }
}
