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
