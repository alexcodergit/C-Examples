using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public USDollar() : base()
        { }

        override public string GetCurrencyName()
        {
            return "USD";
        }
    }
}
