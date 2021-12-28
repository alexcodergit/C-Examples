using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRefTypes
{
    struct Quadrat
    {
        public double Side { get; set; }
        public const int Sides = 4;
        public double Area { get; set; }

        public Quadrat(double side)
        {
            Side = side;
            Area = 0;
        }
    }
}
