using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationSenha.Domain.Models;

namespace ValidationSenha.Domain.Interfaces
{
    public interface IPasswordValidator
    {
        void Validate(Password password);
    }
}
