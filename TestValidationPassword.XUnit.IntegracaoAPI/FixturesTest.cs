using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Net.Http.Json;
using ValidationPassword.Application;
using ValidationPassword.Domain.Models;
using ValidationSenha.Domain.Models;

namespace TestValidationPassword.XUnit.IntegracaoAPI
{
    public class FixturesTest
    {
        [Theory]
        [InlineData("AbTp9!fok", true)]
        public async void TestIntegradoValidadoComSucesso(string password, bool expectedResult)
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            var httpClient = webAppFactory.CreateDefaultClient();
            var request = new Password(password);

            var response = await httpClient.PostAsJsonAsync($"/Password/",request);
            var stringResult = await response.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<ValidationResponse>(stringResult);

            Assert.Contains("Senha validada com sucesso", jsonObject.Message);
            Assert.Equal(expectedResult,jsonObject.IsValid);
        }
    }
}