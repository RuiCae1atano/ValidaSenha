using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Microsoft.DependencyInjection.Abstracts;
using Xunit.Microsoft.DependencyInjection;
using ValidationPassword.Application.Interfaces;
using ValidationSenha.Appication.Services;
using ValidaSenha.Tests.ValidaSenha.Api.Tests;

namespace ValidaSenha.Tests
{
    public class TestFixture : TestBedFixture
    {
        protected override void AddServices(IServiceCollection services, IConfiguration? configuration)
            => services
                .AddTransient<IPasswordValidatorService, PasswordValidatorService>()
                .Configure<Options>(config => configuration?.GetSection("Options").Bind(config));

        protected override ValueTask DisposeAsyncCore()
            => new();

        protected override IEnumerable<TestAppSettings> GetTestAppSettings()
        {
            yield return new() { Filename = "appsettings.json", IsOptional = false };
        }
    }
}
