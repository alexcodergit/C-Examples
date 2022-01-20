namespace Casting
{
    public abstract class Currency
    {
        private double _unitsPerUsd;
        public double UnitsPerUsd
        {
            get => _unitsPerUsd;
            set => _unitsPerUsd = value;
        }
        public Currency() { }
        abstract public string GetCurrencyName();
    }
}
