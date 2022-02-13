using System;

namespace Exceptions_15
{
    class UnderAgeException : ArgumentOutOfRangeException
    {
        public UnderAgeException(string message) : base(message)
        { }
    }

    class NotSufficientBalanceException : ArgumentException
    {
        public NotSufficientBalanceException(string message) : base(message)
        { }
    }
}
