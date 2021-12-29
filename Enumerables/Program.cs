using System;
using System.Linq;
using System.Collections.Generic;

namespace Enumerables
{
    class Program
    {
        /*
        static List<Movie> moviesList = new List<Movie>
            {
                new("Ice Road", "Action", 2021),
                new("Dune", "Adventure", 2021),
                new("The Godfather", "Crime", 1972)
            };
        */
        static void Main(string[] args)
        {
            Movie[] marr = new Movie[3]
            {
                new("Ice Road", "Action", 2021),
                new("Dune", "Adventure", 2021),
                new("The Godfather", "Crime", 1972)
            };
            Console.WriteLine("Iterating using foreach:");
            Movies mlist = new(marr);
            foreach (Movie m in mlist)
            {
                Console.WriteLine($"Movie name: {m.Title}, Genre: {m.Genre}, Appeared in {m.Year}");
            }
            Console.WriteLine();
            Console.WriteLine("Iterating using while:");
            var enumerator = mlist.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Movie m = enumerator.Current;
                Console.WriteLine($"Movie name: {m.Title}, Genre: {m.Genre}, Appeared in {m.Year}");
            }

            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'where':");

            IEnumerable<Movie> query = marr.Where(Movie => Movie.Year == 2021);
            foreach (Movie m in query)
            {
                Console.WriteLine($"Movie name: {m.Title}, Genre: {m.Genre}, Appeared in {m.Year}");
            }

            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'order by':");
            query = marr.OrderBy(Movie => Movie.Title);
            foreach (Movie m in query)
            {
                Console.WriteLine($"Movie name: {m.Title}, Genre: {m.Genre}, Appeared in {m.Year}");
            }

            List<Movie> moviesList = new List<Movie>
            {
                new("Ice Road", "Action", 2021),
                new("Dune", "Adventure", 2021),
                new("The Godfather", "Crime", 1972)
            };

            Console.WriteLine();
            Console.WriteLine("Using Linq query with 'group by':");

            var queryGroupBy = from Movie in moviesList
                               group Movie by Movie.Year into newGroup
                               orderby newGroup.Key
                               select newGroup;

            foreach (var movieGroup in queryGroupBy)
            {
                Console.WriteLine($"Year: {movieGroup.Key}");
                foreach (Movie m in movieGroup)
                {
                    Console.WriteLine($"Movie name: {m.Title}, Genre: {m.Genre}, Appeared in {m.Year}");
                }
            }

            Console.ReadLine();
        }
    }
}
