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
        private int minimumLength = 1;
        private readonly IValidationResponse _validationResponse;

        public PasswordValidatorService(IRegexExpressions regexExpressions, IValidationResponse validationResponse)
        {
            _charactersValidator = new CharactersValidator(regexExpressions);
            _lengthValidator = new LengthValidator(minimumLength);
            _repeatedCharactersValidator = new RepeatedCharactersValidator();
            _validationResponse = validationResponse;
        }

        public IValidationResponse ValidatePassword(Password password)
        {
            try
            {
                _charactersValidator.Validate(password);
                _lengthValidator.Validate(password);
                _repeatedCharactersValidator.Validate(password);
            }
            catch (PasswordValidationException ex)
            {
                _validationResponse.IsValid = false;
                _validationResponse.Message = ex.Message;
                return _validationResponse;
            }

            _validationResponse.IsValid = true;
            _validationResponse.Message = "Senha validada com sucesso";
            return _validationResponse;
        }
    }
}
