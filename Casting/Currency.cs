namespace Casting
{
    abstract class Currency
    {
        private decimal _unitsPerUsd;
        public decimal UnitsPerUsd
        {
            get => _unitsPerUsd;
            set => _unitsPerUsd = value;
        }
        public Currency()
        {}
        abstract public string GetCurrencyName();
    }
}
