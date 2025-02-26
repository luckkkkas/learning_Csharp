using System;

namespace Excecoes.Entities.Excepion {
    internal class DomainException : ApplicationException{
        public DomainException(string message) : base(message) { }
    }
}
