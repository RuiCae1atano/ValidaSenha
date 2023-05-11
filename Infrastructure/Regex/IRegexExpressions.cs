using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaSenha.Infrastructure.Regex
{
    public interface IRegexExpressions
    {
        string Digits { get; }
        string UpperCaseLetters { get; }
        string LowerCaseLetters { get; }
        string SpecialCharacters { get; }
    }
}
