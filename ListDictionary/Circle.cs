using System;

namespace ListDictionary
{
    class Circle
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            Radius = r;
        }
        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            return Radius.CompareTo(((Circle)obj).Radius) == 0;
        }
    }
}
