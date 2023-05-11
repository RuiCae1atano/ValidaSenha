using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Moq;
using ValidaSenha.Infrastructure.Regex;
using ValidationPassword.Application.Interfaces;
using ValidationSenha.Appication.Services;

//[assembly: TestFramework("Xunit.DependencyInjection.TestFramework", "Xunit.DependencyInjection")]

namespace ValidationPassword.XUnit
{
    public class UnitTest1
    {

        private readonly IPasswordValidatorService _passwordValidatorService;

        public UnitTest1(IPasswordValidatorService passwordValidatorService)
        {
            _passwordValidatorService = passwordValidatorService;
        }

        [Theory]
        [InlineData("AbTp9!fok", true)]
        [InlineData("AbTp9!fok*", true)]
        [InlineData("123456", false)]
        [InlineData("qwertyuiop", false)]
        [InlineData("", false)]
        [InlineData("aa", false)]
        [InlineData("ab", false)]
        [InlineData("AAAbbbCc", false)]
        [InlineData("AbTp9!foA", false)]
        [InlineData("AbTp9 fok", false)]
        public void TestesSenhaValidation(string password, bool expectedResult)
        {
            Assert.Equal(expectedResult,_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password(password)).IsValid);
        }

    }
}