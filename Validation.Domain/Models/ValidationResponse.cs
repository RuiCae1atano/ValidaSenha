using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationPassword.Application.Interfaces;

namespace ValidationPassword.Domain.Models
{
    public class ValidationResponse : IValidationResponse
    {
        public bool IsValid { get; set; }
        public string? Message { get; set; }

    }
}
