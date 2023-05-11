using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationSenha.Domain.Exceptions;
using ValidationSenha.Domain.Interfaces;
using ValidationSenha.Domain.Models;

namespace ValidaSenha.Infrastructure.Validators
{
    public class RepeatedCharactersValidator : IPasswordValidator
    {
        public void Validate(Password password)
        {
            if (password.Value.Distinct().Count() != password.Value.Length)
            {
                throw new PasswordValidationException("A senha não pode conter caracteres repetidos.");
            }
        }
    }
}
