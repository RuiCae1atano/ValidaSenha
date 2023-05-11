using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidaSenha.Infrastructure.Regex;
using ValidaSenha.Infrastructure.Validators;
using ValidationPassword.Application.Interfaces;
using ValidationPassword.Domain.Models;
using ValidationSenha.Domain.Exceptions;
using ValidationSenha.Domain.Models;

namespace ValidationSenha.Appication.Services
{
    public class PasswordValidatorService : IPasswordValidatorService
    {
        private readonly CharactersValidator _charactersValidator;
        private readonly LengthValidator _lengthValidator;
        private readonly RepeatedCharactersValidator _repeatedCharactersValidator;
        

        public PasswordValidatorService(RegexExpressions regexExpressions, int minimumLength)
        {
            _charactersValidator = new CharactersValidator(regexExpressions);
            _lengthValidator = new LengthValidator(minimumLength);
            _repeatedCharactersValidator = new RepeatedCharactersValidator();
        }

        public ValidationResponse ValidatePassword(Password password)
        {
            var result = new ValidationResponse(false, "");
            try
            {
                _charactersValidator.Validate(password);
                _lengthValidator.Validate(password);
                _repeatedCharactersValidator.Validate(password);
            }
            catch (PasswordValidationException ex)
            {
                return new ValidationResponse(false, ex.Message);
            }

            result.IsValid = true;
            return result;
        }
    }
}
