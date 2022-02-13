using System;

namespace Exceptions_15
{
    class Program
    {
        static void Main()
        {
            Bank bank = new();
            Client c1 = new() { Name = "C1", Age = 20, Balance = 100.0 };
            Client c2 = new() { Name = "C2", Age = 76, Balance = 200.0 };
            bank.RegisterNewClient(c1);
            bank.RegisterNewClient(c2);

            try
            {
                bank.RegisterNewClient(new Client { Name = "C3", Age = 16, Balance = 50.0 });
            }
            // catches ArgumentOutOfRangeException or any descendant (derived) exception
            catch (ArgumentOutOfRangeException aob)
            {
                Console.WriteLine(aob.Message);
            }
            // we will not get here but for the sake of generality,
            // when the first catch don't works, we catch more general exception
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(1);
            }
            double amount = 51.0;
            if (bank.TransferMoney(c1, c2, amount))
            {
                Console.WriteLine($"Transfer of {amount} from {c1.Name} to {c2.Name} succeeded.");
            }
            else
            {
                Console.WriteLine($"Transfer of {amount} from {c1.Name} to {c2.Name} not succeeded.");
            }
            try
            {
                bank.TransferMoney(c1, c2, amount);
            }
            catch (NotSufficientBalanceException nsb)
            {
                Console.WriteLine(nsb.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(1);
            }
            Console.ReadKey();
        }
    }
}
