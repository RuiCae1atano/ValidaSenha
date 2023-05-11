using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationPassword.Application.Interfaces
{
    public interface IValidationResponse
    {
        bool IsValid { get; set; }
        string Message { get; set; }
    }
}
