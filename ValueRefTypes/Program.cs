using System;

namespace ValueRefTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating with classes, geometric figure - rectangle.");
            Rectangle rectangle = new(3.0, 4.0);
            Rectangle withArea = CalculateNewRectangleArea(rectangle);

            Console.WriteLine($"Original rectangle without area, sides: 2 x {rectangle.Side1},  2 x {rectangle.Side2}, Area: {rectangle.Area}");
            Console.WriteLine($"New rectangle with area, Sides: 2 x {withArea.Side1},  2 x {withArea.Side2}, Area: {withArea.Area}");

            CalculateRectangleArea(ref rectangle);

            Console.WriteLine($"Original rectangle with area, Sides: 2 x {withArea.Side1},  2 x {rectangle.Side2}, Area: {rectangle.Area}");
            Console.WriteLine("######################################");

            Console.WriteLine("Calculating with structs, geometric figure - quadrat.");
            Quadrat quadrat = new(5.0);
            Quadrat qarea = CalculateNewQuadratArea(quadrat);
            Console.WriteLine($"Original quadrat without area, sides: 4 x {quadrat.Side}, Area: {quadrat.Area}");
            Console.WriteLine($"Quadrat with area, sides: 4 x {qarea.Side}, Area: {qarea.Area}");

            CalculateQuadratArea(ref quadrat);

            Console.WriteLine($"Original quadrat with area, Sides: 4 x {quadrat.Side}, Area: {quadrat.Area}");

            Console.ReadLine();
        }

        // calculates area of rectangle. 
        // creates new rectangle and returns it
        // original rectangle not affected
        static Rectangle CalculateNewRectangleArea(Rectangle rec)
        {
            // allocates object on heap
            Rectangle ret = new(rec.Side1, rec.Side2);
            ret.Area = ret.Side1 * ret.Side2;
            return ret;
        }

        // calculates area of original rectangle
        static void CalculateRectangleArea(ref Rectangle rec)
        {
            rec.Area = rec.Side1 * rec.Side2;
        }

        // calculates area of quadrat and returns 
        // new quadrat with calculated area
        // orginal quadtrat not affected
        static Quadrat CalculateNewQuadratArea(Quadrat q)
        {
            // allocates object on stack
            Quadrat ret = new(q.Side);
            ret.Area = ret.Side * ret.Side;
            return ret;
        }

        // calculates area of original quadrat
        static void CalculateQuadratArea(ref Quadrat q)
        {
            q.Area = q.Side * q.Side;
        }
    }
}
