using System;

namespace IComparableInterface
{
    class Quadrat : IComparable<Quadrat>
    {
        public double Side { get; set; }
        public Quadrat(double side)
        {
            Side = side;
        }

        public double Area()
        {
            return Side * Side;
        }

        public int CompareTo(Quadrat other)
        {
            if (other == null)
            {
                return 1;
            }
            return Area().CompareTo(other.Area());
        }
    }
}
