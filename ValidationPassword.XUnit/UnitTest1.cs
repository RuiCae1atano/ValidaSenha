using Microsoft.AspNetCore.Identity;
using Moq;
using ValidaSenha.Infrastructure.Regex;
using ValidationPassword.Application.Interfaces;
using ValidationSenha.Appication.Services;

namespace ValidationPassword.XUnit
{
    public class UnitTest1
    {

        private readonly PasswordValidatorService _passwordValidatorService;

        public UnitTest1(PasswordValidatorService passwordValidatorService)
        {
            _passwordValidatorService = passwordValidatorService;
        }

        [Fact]
        public void TesteSenhaSemNenhumCaracter()
        {
            Assert.False(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("")).IsValid);
        }

        [Fact]
        public void TesteSenhaComDoisCaracteres()
        {
            Assert.False(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("aa")).IsValid);
        }

        [Fact]
        public void TesteSenhaComLetrasMinusculasEMaiusculas()
        {
            Assert.False(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("AAAbbbCc")));
        }

        [Fact]
        public void TesteSenhaSemCaractereEspecial()
        {
            Assert.False(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("AbTp9foo")));
        }

        [Fact]
        public void TesteSenhaValida()
        {
            Assert.True(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("AbTp9!foo")));
        }

        [Fact]
        public void TesteSenhaSemLetraMaiuscula()
        {
            Assert.False(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("ab")));
        }

        [Fact]
        public void TesteSenhaComEspaco()
        {
            Assert.False(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("AbTp9 fok")));
        }

        [Fact]
        public void TesteSenhaComLetraMaiusculaFaltando()
        {
            Assert.True(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("AbTp9!fok")));
        }
    }
}