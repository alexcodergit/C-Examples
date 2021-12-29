using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Hrivna : Currency
    {
        private decimal _unitsPerUsd;
        public new decimal UnitsPerUsd
        {
            get => _unitsPerUsd;
            set => _unitsPerUsd = value;
        }
        public Hrivna() : base() { }

        override public string GetCurrencyName()
        {
            return "UAH";
        }
    }
}
