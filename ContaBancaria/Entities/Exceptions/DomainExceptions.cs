using System;

namespace ContaBancaria.Entities.Exceptions
{
    public class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message)
            : base(message) { }
    }
}
