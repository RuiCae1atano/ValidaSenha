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
    public class LengthValidator : IPasswordValidator
    {
        private readonly int _minimumLength;

        public LengthValidator(int minimumLength)
        {
            _minimumLength = minimumLength;
        }
        public void Validate(Password password)
        {
            if (password.Value.Length < _minimumLength)
            {
                throw new PasswordValidationException($"A senha deve ter no mínimo {_minimumLength} caracteres.");
            }
        }
    }
}
