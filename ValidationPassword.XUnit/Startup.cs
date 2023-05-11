using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidaSenha.Infrastructure.Regex;
using ValidationPassword.Application.Interfaces;
using ValidationPassword.Domain.Models;
using ValidationPassword.Infrastructure.Messages;
using ValidationSenha.Appication.Services;

namespace ValidationPassword.XUnit
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPasswordValidatorService, PasswordValidatorService>();
            services.AddTransient<IRegexExpressions, RegexExpressions>();
            services.AddTransient<IValidationResponse, ValidationResponse>();
            services.AddTransient<IMessageService, MessageService>();

        }
    }
}
