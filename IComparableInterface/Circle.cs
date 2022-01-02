using System;

namespace IComparableInterface
{
    class Circle
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Radius * Radius * Math.PI;
        }

        public Circle(double r)
        {
            Radius = r;
        }
    }
}
