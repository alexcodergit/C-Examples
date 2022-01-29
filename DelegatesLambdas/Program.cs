using System;
using System.Collections.Generic;
using Casting;

namespace DelegatesLambdas
{
    class Program
    {
        static void Main()
        {
            BankSystem bs = new();
            Client cient1 = new() { Id = 1, Name = "A" };
            Account acc1 = new(1, new Ruble() { UnitsPerUsd = 78 });
            acc1.Add(1000);
            Account acc2 = new(2, new Hrivna() { UnitsPerUsd = 30 });
            acc2.Add(2000);
            bs.AddClient(cient1, acc1);
            bs.AddClient(cient1, acc2);
            Console.WriteLine($"Amounts before transfer: account1: {acc1.Amount}, account2: {acc2.Amount}");
            // calling method and passing delegate as argument
            bs.TransferFunds(500, cient1, acc1, acc2, Currency.ConvertCurrency);
            Console.WriteLine($"Amounts after transfer: account1: {acc1.Amount}, account2: {acc2.Amount}");

            Console.WriteLine("Lambda example");
            List<int> numbers = new() { 1, 2, 3 };
            numbers.ForEach(delegate (int x) { Console.WriteLine(x * x); });
            Console.WriteLine("");
        }
    }
}
