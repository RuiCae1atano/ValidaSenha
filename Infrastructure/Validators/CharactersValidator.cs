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
using ValidationPassword.Infrastructure.Messages;

namespace ValidaSenha.Infrastructure.Validators
{
    public class CharactersValidator : IPasswordValidator
    {
        private readonly IRegexExpressions _regexExpressions;
        private readonly IMessageService _messageService;

        public CharactersValidator(IRegexExpressions regexExpressions, IMessageService messageService)
        {
            _regexExpressions = regexExpressions;
            _messageService = messageService;
        }

        public void Validate(Password password)
        {
            if (!Reg.IsMatch(password.Value, _regexExpressions.SpecialCharacters))
            {
                throw new PasswordValidationException(string.Format(_messageService.GetErrorMessage("InvalidPasswordLength")));
            }

            if (!Reg.IsMatch(password.Value, _regexExpressions.UpperCaseLetters))
            {
                throw new PasswordValidationException(string.Format(_messageService.GetErrorMessage("UpperCaseLetters")));
            }

            if (!Reg.IsMatch(password.Value, _regexExpressions.LowerCaseLetters))
            {
                throw new PasswordValidationException(string.Format(_messageService.GetErrorMessage("LowerCaseLetters")));
            }

            if (!Reg.IsMatch(password.Value, _regexExpressions.Digits))
            {
                throw new PasswordValidationException(string.Format(_messageService.GetErrorMessage("Digits")));
            }
        }
    }
}
