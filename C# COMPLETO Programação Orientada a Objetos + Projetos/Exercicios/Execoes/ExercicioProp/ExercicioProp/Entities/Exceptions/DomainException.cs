using System;

namespace ExercicioProp.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message)
        {
        }
    }
}
