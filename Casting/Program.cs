using System;

namespace Casting
{
    public class Program
    {
        static void Main(string[] args)
        {
            USDollar dollar = new();
            Euro euro = new();
            Ruble ruble = new();
            Hrivna hrivna = new();

            euro.UnitsPerUsd = 0.8842;
            ruble.UnitsPerUsd = 73.70;
            hrivna.UnitsPerUsd = 27.234;

            int amount = 10;
            double converted = ConvertCurrency(euro, dollar, amount);
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
        static double GetUnitsPerUSD(Currency cur)
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
