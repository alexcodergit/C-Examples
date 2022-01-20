using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using Casting;

namespace ListDictionary
{
    class Program
    {
        // driver program
        static void Main()
        {
            List<Client> clients = GenerateClients();
            // Finding client with passport number and name
            // show explicit the type of tehe returned value
            Console.WriteLine("Look up fr Cient with name 'Client1' or passport number '2':");
            IEnumerable<Client> query = FindClientUsngPassportOrName(clients, 2, "Client1");
            foreach (var c in query)
            {
                Console.WriteLine($"Cient's name: {c.FirstName}, PassportNum: {c.PassportNum}");
            }
            Console.WriteLine();

            Console.WriteLine("Look up fr Cient with name 'Client3' or passport number '100':");
            query = FindClientUsngPassportOrName(clients, 100, "Client3");
            foreach (var c in query)
            {
                Console.WriteLine($"Cient's name: {c.FirstName}, PassportNum: {c.PassportNum}");
            }
            Console.WriteLine();
            // Finding clients with balance below 200
            Console.WriteLine("Clients with balance below 200:");
            query = FindClientsWithLowerBalance(clients, 200);
            foreach (var c in query)
            {
                Console.WriteLine($"Cient's name: {c.FirstName}, Balance: {c.Balance}");
            }
            Console.WriteLine();
            Console.WriteLine("Clients with minimal balance:");
            // show explicit the return type
            List<Client> ClientsMinBalance = FindClientsWithMinBalance(clients);
            foreach (var c in ClientsMinBalance)
            {
                Console.WriteLine($"Cient's name: {c.FirstName}, Balance: {c.Balance}");
            }
            Console.WriteLine();
            Console.WriteLine("Sum of all balances:");
            double bal = FindSumOfBalances(clients);
            Console.WriteLine($"Total balance {bal}");

            Console.WriteLine();
            Console.WriteLine("Using dictionaries:");
            Dictionary<Circle, double> dict = GenerateCirclesDictionary();
            List<Circle> lst = GenerateCirclesList();
            Circle circle = new Circle(500.0);
            Console.WriteLine($"Look up for a circle with Radius {circle.Radius} in Dictionary with {dict.Count()} entries:");

            Stopwatch sw = new();
            sw.Start();
            bool df = dict.ContainsKey(circle);
            sw.Stop();
            var ts = sw.Elapsed;
            Console.WriteLine($"Lookup in Dictionary has taken {ts.Ticks} ticks");
            if (df)
            {
                Console.WriteLine("Value was found");
            }
            else
            {
                Console.WriteLine("Value was not found");
            }
            Console.WriteLine($"Look up for a circle with Radius {circle.Radius} in List with {lst.Count} elements:");
            sw = new Stopwatch();
            bool lf = lst.Contains(circle);
            sw.Stop();
            ts = sw.Elapsed;
            Console.WriteLine($"Lookup in List has taken {ts.Ticks} ticks");
            if (lf)
            {
                Console.WriteLine("Value was found");
            }
            else
            {
                Console.WriteLine("Value was not found");
            }
            Console.WriteLine();
            Console.WriteLine("Client with multiple currencies.");
            MultiCurrencyClient mcc = new("A", "B", 1);

            USDollar dollar = new();
            Euro euro = new();
            Ruble ruble = new();
            Hrivna hrivna = new();

            euro.UnitsPerUsd = 0.8842;
            ruble.UnitsPerUsd = 76.77;
            hrivna.UnitsPerUsd = 28.32;

            mcc.AddAmount(dollar, 1000);
            mcc.AddAmount(euro, 200);
            mcc.AddAmount(ruble, 1000);
            mcc.AddAmount(dollar, -800);
            mcc.AddAmount(hrivna, 999);
            mcc.OutputBalances();
            Console.WriteLine($"Total balance in US Dollars {mcc.Balance}");
            Console.WriteLine();
        }

        // private utlities methods
        private static IEnumerable<Client> FindClientUsngPassportOrName(List<Client> clients, int pn, string name)
        {
            IEnumerable<Client> query = clients.Where(Client => Client.PassportNum == pn || Client.FirstName == name);
            return query;
        }

        private static IEnumerable<Client> FindClientsWithLowerBalance(List<Client> clients, double bal)
        {
            IEnumerable<Client> query = clients.Where(Client => Client.Balance.CompareTo(bal) < 0);
            return query;
        }

        // here no LINQ used
        // custom implementation make it more readable
        private static List<Client> FindClientsWithMinBalance(List<Client> clients)
        {
            if (clients.Count() < 1)
            {
                return clients;
            }
            List<Client> retClients = new()
            {
                clients.ElementAt(0)
            };
            for (int idx = 1; idx < clients.Count; idx++)
            {
                if (clients.ElementAt(idx).Balance.CompareTo(retClients.ElementAt(0).Balance) < 0)
                {
                    retClients.Clear();
                    retClients.Add(clients.ElementAt(idx));
                }
                else if (clients.ElementAt(idx).Balance.CompareTo(retClients.ElementAt(0).Balance) == 0)
                {
                    retClients.Add(clients.ElementAt(idx));
                }
            }
            return retClients;
        }

        private static double FindSumOfBalances(List<Client> clients)
        {
            double ret = (from c in clients select c.Balance).Sum();
            return ret;
        }

        private static List<Client> GenerateClients()
        {
            List<Client> clients = new()
            {
                new Client("Client1", "Client1 Name", 1, 100.0),
                new Client("Client2", "Client2 Name", 2, 200.0),
                new Client("Client3", "Client3 Name", 3, 150.0),
                new Client("Client4", "Client4 Name", 4, 250.0),
                new Client("Client5", "Client5 Name", 5, 350.0),
                new Client("Client6", "Client6 Name", 6, 350.0),
                new Client("Client7", "Client7 Name", 7, 100.0)
            };
            return clients;
        }

        // generate List of Circles
        private static List<Circle> GenerateCirclesList()
        {
            List<Circle> circles = new();
            for (double d = 1.0; d.CompareTo(1001.0) < 0; d += 1.0)
            {
                circles.Add(new Circle(d));
            }
            return circles;
        }
        // generate dictionary with circles as keys and circle areas as values
        private static Dictionary<Circle, double> GenerateCirclesDictionary()
        {
            Dictionary<Circle, double> circles = new();
            for (double d = 1.0; d.CompareTo(1001.0) < 0; d += 1.0)
            {
                circles[new Circle(d)] = Math.PI * d * d;
            }
            return circles;
        }
    }
}
