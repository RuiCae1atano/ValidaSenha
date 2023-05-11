using ValidationPassword.Application.Interfaces;
using ValidationSenha.Appication.Services;
using Xunit.Abstractions;
using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace ValidaSenha.Tests
{
    public class ValidaSenhaTests : TestBed<TestFixture>
    {
        public ValidaSenhaTests(ITestOutputHelper testOutputHelper, TestFixture fixture)
            : base(testOutputHelper, fixture)
        {
            
        }

        [Fact]
        public void TesteSenhaVazia()
        {
            var senha = new ValidationSenha.Domain.Models.Password("");
            var service = _fixture.GetService<IPasswordValidatorService>(_testOutputHelper);



            //var _passwordValidatorService = new PasswordValidatorService(,1);
            Assert.False(service.ValidatePassword(senha));
        }

        //[Fact]
        //public void TesteSenhaComDoisCaracteres()
        //{
        //    Assert.False(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("aa")));
        //}

        //[Fact]
        //public void TesteSenhaComLetrasMinusculasEMaiusculas()
        //{
        //    Assert.False(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("AAAbbbCc")));
        //}

        //[Fact]
        //public void TesteSenhaSemCaractereEspecial()
        //{
        //    Assert.False(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("AbTp9foo")));
        //}

        //[Fact]
        //public void TesteSenhaValida()
        //{
        //    Assert.True(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("AbTp9!foo")));
        //}

        //[Fact]
        //public void TesteSenhaSemLetraMaiuscula()
        //{
        //    Assert.False(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("ab")));
        //}

        //[Fact]
        //public void TesteSenhaComEspaco()
        //{
        //    Assert.False(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("AbTp9 fok")));
        //}

        //[Fact]
        //public void TesteSenhaComLetraMaiusculaFaltando()
        //{
        //    Assert.True(_passwordValidatorService.ValidatePassword(new ValidationSenha.Domain.Models.Password("AbTp9!fok")));
        //}
    }
}