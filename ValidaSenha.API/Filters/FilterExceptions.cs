using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ValidationSenha.Domain.Exceptions;

namespace ValidationPassword.API.Filters
{
    public class FilterExceptions : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is PasswordValidationException) 
            {
                context.Result = new ObjectResult(new { sucesso = false, context.Exception.Message })
                { 
                    StatusCode = 400 
                };
            }
        }
    }
}
