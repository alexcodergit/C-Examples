using System;

namespace Casting
{
    public class Program
    {
        static void Main()
        {
            USDollar dollar = new();
            Euro euro = new();
            Ruble ruble = new();
            Hrivna hrivna = new();

            euro.UnitsPerUsd = 0.8842;
            ruble.UnitsPerUsd = 73.70;
            hrivna.UnitsPerUsd = 27.234;

            int amount = 10;
            double converted = Currency.ConvertCurrency(euro, dollar, amount);
            Console.WriteLine($"{amount} {euro.GetCurrencyName()} = {converted} {dollar.GetCurrencyName()}");

            converted = Currency.ConvertCurrency(dollar, euro, amount);
            Console.WriteLine($"{amount} {dollar.GetCurrencyName()} = {converted} {euro.GetCurrencyName()}");

            converted = Currency.ConvertCurrency(euro, ruble, amount);
            Console.WriteLine($"{amount} {euro.GetCurrencyName()} = {converted} {ruble.GetCurrencyName()}");

            converted = Currency.ConvertCurrency(ruble, euro, amount);
            Console.WriteLine($"{amount} {ruble.GetCurrencyName()} = {converted} {euro.GetCurrencyName()}");

            converted = Currency.ConvertCurrency(hrivna, dollar, amount);
            Console.WriteLine($"{amount} {hrivna.GetCurrencyName()} = {converted} {dollar.GetCurrencyName()}");

            converted = Currency.ConvertCurrency(dollar, hrivna, amount);
            Console.WriteLine($"{amount} {dollar.GetCurrencyName()} = {converted} {hrivna.GetCurrencyName()}");

            Console.ReadLine();
        }
    }
}
