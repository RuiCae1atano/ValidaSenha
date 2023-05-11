using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationPassword.Domain.Models
{
    public class ValidationResponse
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }

        public ValidationResponse(bool isValid, string message) 
        {
            IsValid = isValid;
            Message = message;
        }
    }
}
