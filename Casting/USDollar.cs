namespace Casting
{
    class USDollar : Currency
    {
        private const decimal _unitsPerUsd = 1.0M;
        public new decimal UnitsPerUsd
        {
            get => _unitsPerUsd;
            set { }
        }
        public USDollar() { }

        override public string GetCurrencyName()
        {
            return "USD";
        }
    }
}
