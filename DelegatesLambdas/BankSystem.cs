using System.Collections.Generic;
using Casting;

namespace DelegatesLambdas
{
    class BankSystem
    {
        private readonly Dictionary<Client, List<Account>> ClientsDict = new Dictionary<Client, List<Account>>();

        public delegate double Transfer(Currency from, Currency to, double amount);

        public void AddClient(Client client, Account account)
        {
            if (ClientsDict.ContainsKey(client))
            {
                if (!ClientsDict[client].Contains(account))
                {
                    ClientsDict[client].Add(account);
                }
            }
            else
            {
                ClientsDict.Add(client, new List<Account>());
                ClientsDict[client].Add(account);
            }
        }
        public void TransferFunds(double amount, Client client, Account from, Account to, Transfer trans)
        {
            if (ClientsDict.ContainsKey(client))
            {
                if (ClientsDict[client].Contains(from) && ClientsDict[client].Contains(to))
                {
                    double converted = trans(from.Cur, to.Cur, amount);
                    int idx = ClientsDict[client].IndexOf(from);
                    ClientsDict[client][idx].Add(-1 * amount);
                    idx = ClientsDict[client].IndexOf(to);
                    ClientsDict[client][idx].Add(converted);
                }
            }
        }
    }
}
