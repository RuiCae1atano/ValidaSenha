using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSenha.Domain.Models
{
    public class Password
    {
        public string Value { get; set; }
        public Password(string value)
        {
            Value = value;
        }
    }
}
