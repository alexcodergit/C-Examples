using System.Collections;

namespace Enumerables
{
    public class Movies : IEnumerable
    {
        private Movie[] _movies;
        public Movies(Movie[] marr)
        {
            _movies = new Movie[marr.Length];
            for (int i = 0; i < marr.Length; i++)
            {
                _movies[i] = marr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public MoviesEnum GetEnumerator()
        {
            return new MoviesEnum(_movies);
        }
    }
}
