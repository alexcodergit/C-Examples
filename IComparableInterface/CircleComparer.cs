using System.Collections.Generic;
using System;

namespace IComparableInterface
{
    class CircleComparer : IComparer<Circle>
    {
        private const double eps = 0.0001;
        public int Compare(Circle x, Circle y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Can't compare null objects.");
            }
            if (x.Area() - y.Area() < -eps)
            {
                return 1; // for reverse sort
            }
            if (Math.Abs(x.Area() - y.Area()) < eps)
            {
                return 0;
            }
            return -1; // for reverse sort
        }
    }
}
