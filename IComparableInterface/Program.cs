using System;

namespace IComparableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrat[] arr = new Quadrat[10]
            {
                new (1),
                new (2),
                new (3),
                new (4),
                new (5),
                new (6),
                new (7),
                new (8),
                new (9),
                new (10)
        };
            // sorts ascending
            Array.Sort(arr);
            // reverse order
            Array.Reverse(arr);
            for (var i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Quadrat area: {arr[i].Area()}");
            }
            Console.WriteLine();

            Circle[] arr2 = new Circle[10]
{
                new (1),
                new (2),
                new (3),
                new (4),
                new (5),
                new (6),
                new (7),
                new (8),
                new (9),
                new (10)
};
            // sorts in reverse order
            Array.Sort(arr2, new CircleComparer());

            for (var i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"Circle area: {arr2[i].Area()}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
