using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaSenha.Infrastructure.Regex
{
    public class RegexExpressions : IRegexExpressions
    {
        public string Digits => @"[\d]";

        public string UpperCaseLetters => @"[A-Z]";

        public string LowerCaseLetters => @"[a-z]";

        public string SpecialCharacters => @"[!@#\$%\^&\*\(\)-\+]";
    }
}
