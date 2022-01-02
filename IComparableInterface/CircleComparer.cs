using System.Collections.Generic;


namespace IComparableInterface
{
    class CircleComparer : IComparer<Circle>
    {
        public int Compare(Circle x, Circle y)
        {
            if (x.Area() < y.Area())
            {
                return 1; // for reverse sort
            }
            if (x.Area() == y.Area())
            {
                return 0;
            }
            return -1; // for reverse sort
        }
    }
}
