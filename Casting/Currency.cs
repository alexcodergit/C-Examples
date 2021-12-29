using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
