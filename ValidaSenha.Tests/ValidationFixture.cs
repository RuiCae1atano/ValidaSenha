using Microsoft.Extensions.DependencyInjection;
using ValidationPassword.Application.Interfaces;

namespace ValidaSenha.Tests
{
    public class ValidationFixture
    {
        public ServiceProvider ServiceProvider { get; private set; }

        public ValidationFixture()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection
                .AddSingleton<IPasswordValidatorService, IPasswordValidatorService>();

            ServiceProvider = serviceCollection.BuildServiceProvider();

        }
    }
}