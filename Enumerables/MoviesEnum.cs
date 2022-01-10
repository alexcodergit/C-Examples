using System;
using System.Collections;

namespace Enumerables
{
    public class MoviesEnum : IEnumerator
    {
        private Movie[] _movies;
        int pos = -1;

        public MoviesEnum(Movie[] marr)
        {
            _movies = marr;
        }

        public bool MoveNext()
        {
            pos++;
            return pos < _movies.Length;
        }

        public void Reset()
        {
            pos = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Movie Current
        {
            get
            {
                try
                {
                    return _movies[pos];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
