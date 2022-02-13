using System;
using System.Collections.Generic;

namespace Exceptions_15
{
    class Client
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Balance { get; set; }
    }

    class Bank
    {
        private readonly List<Client> Clients = new();

        public void RegisterNewClient(Client client)
        {
            if (!Clients.Contains(client))
            {
                if (client.Age < 18)
                {
                    throw new UnderAgeException($"Client's age {client.Age} below 18");
                }
                Clients.Add(client);
            }
        }

        public bool TransferMoney(Client fromClient, Client toClient, double amount)
        {
            if (Clients.Contains(fromClient) && Clients.Contains(toClient))
            {
                if (fromClient.Balance >= amount)
                {
                    fromClient.Balance -= amount;
                    toClient.Balance += amount;
                    return true;
                }
                else
                {
                    throw new NotSufficientBalanceException($"The client {fromClient.Name} has not sufficient balance to accomplish transaction of {amount}");
                }
            }
            else
            {
                return false;
            }
        }
    }
}
