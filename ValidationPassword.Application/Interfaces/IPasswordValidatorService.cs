using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationPassword.Domain.Models;
using ValidationSenha.Domain.Models;

namespace ValidationPassword.Application.Interfaces
{
    public interface IPasswordValidatorService
    {
        IValidationResponse ValidatePassword(Password password);
    }
}
