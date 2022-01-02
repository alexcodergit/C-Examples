using System;

namespace IComparableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrat[] arr = new Quadrat[10]
            {
                new Quadrat(1),
                new Quadrat(2),
                new Quadrat(3),
                new Quadrat(4),
                new Quadrat(5),
                new Quadrat(6),
                new Quadrat(7),
                new Quadrat(8),
                new Quadrat(9),
                new Quadrat(10)
        };
            // sorts ascending
            Array.Sort(arr);
            // reverse order
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Quadrat area: {arr[i].Area()}");
            }
            Console.WriteLine();

            Circle[] arr2 = new Circle[10]
{
                new Circle(1),
                new Circle(2),
                new Circle(3),
                new Circle(4),
                new Circle(5),
                new Circle(6),
                new Circle(7),
                new Circle(8),
                new Circle(9),
                new Circle(10)
};
            // sorts in reverse order
            Array.Sort(arr2, new CircleComparer());

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"Circle area: {arr2[i].Area()}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
