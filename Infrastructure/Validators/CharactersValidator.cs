using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reg = System.Text.RegularExpressions.Regex;
using System.Threading.Tasks;
using ValidaSenha.Infrastructure.Regex;
using ValidationSenha.Domain.Exceptions;
using ValidationSenha.Domain.Interfaces;
using ValidationSenha.Domain.Models;

namespace ValidaSenha.Infrastructure.Validators
{
    public class CharactersValidator : IPasswordValidator
    {
        private readonly IRegexExpressions _regexExpressions;

        public CharactersValidator(IRegexExpressions regexExpressions)
        {
            _regexExpressions = regexExpressions;
        }

        public void Validate(Password password)
        {
            if (!Reg.IsMatch(password.Value, _regexExpressions.SpecialCharacters))
            {
                throw new PasswordValidationException("A senha deve conter ao menos 1 caractere especial.");
            }

            if (!Reg.IsMatch(password.Value, _regexExpressions.UpperCaseLetters))
            {
                throw new PasswordValidationException("A senha deve conter ao menos 1 letra maiúscula.");
            }

            if (!Reg.IsMatch(password.Value, _regexExpressions.LowerCaseLetters))
            {
                throw new PasswordValidationException("A senha deve conter ao menos 1 letra minúscula.");
            }

            if (!Reg.IsMatch(password.Value, _regexExpressions.Digits))
            {
                throw new PasswordValidationException("A senha deve conter ao menos 1 dígito.");
            }
        }
    }
}
