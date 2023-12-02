using System;
using System.Collections.Generic;
using System.Text;

namespace Aula155ExFixExceptions.Entities.Exceptions
{
    internal class DomainException : ApplicationException //Definindo que a Classe DomainException é subclasse da ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
