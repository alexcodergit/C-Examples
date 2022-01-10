namespace Casting
{
    class Euro : Currency
    {
        public Euro() {}

        override public string GetCurrencyName()
        {
            return "EUR";
        }
    }
}
