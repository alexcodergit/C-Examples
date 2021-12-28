using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRefTypes
{
    class Rectangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public const int Sides = 4;
        public double Area { get; set; }
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
            Area = 0;
        }
    }
}
