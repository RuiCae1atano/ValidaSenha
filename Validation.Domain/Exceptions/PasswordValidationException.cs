using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSenha.Domain.Exceptions
{
    public class PasswordValidationException : Exception
    {
        public PasswordValidationException(string message) : base(message) { }
    }
}
