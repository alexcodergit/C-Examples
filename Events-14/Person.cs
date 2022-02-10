using System;

namespace Events_14
{
    public class BalanceChangedEventArgs : EventArgs
    {
        public double OldAmount { get; set; }
        public double NewAmount { get; set; }
    }

    class Person : INotifyPropertyChanged
    {
        public string Name { get; init; }
        private double _balance;

        public event INotifyPropertyChanged.PropertyChangedEventHandler Handler;

        public Person(string n)
        {
            Name = n;
            _balance = 0;
        }

        public void TransferAmount(double amount)
        {
            BalanceChangedEventArgs args = new();
            args.OldAmount = _balance;
            _balance += amount;
            args.NewAmount = _balance;
            Handler?.Invoke(this, args);
        }
    }
}
