using Casting;

namespace DelegatesLambdas
{
    class Program
    {
        static void Main()
        {
            BankSystem bs = new();
            Client cient1 = new() { Id = 1, Name = "A" };
            Account acc1 = new(1, new Ruble() { UnitsPerUsd = 78 }, 1000);
            Account acc2 = new(1, new Hrivna() { UnitsPerUsd = 30 }, 2000);
            bs.AddClient(cient1, acc1);
            bs.AddClient(cient1, acc2);
            // calling method and passing delegate as argument
            bs.TransferFunds(1000, cient1, acc1, acc2, Currency.ConvertCurrency);
        }
    }
}
