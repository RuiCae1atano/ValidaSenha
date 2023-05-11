using Microsoft.AspNetCore.Mvc;
using ValidationPassword.API.Filters;
using ValidationPassword.Application.Interfaces;
using ValidationSenha.Domain.Models;

namespace ValidaSenha.API.Controllers
{
    [TypeFilter(typeof(FilterExceptions))]
    [ApiController]
    [Route("[controller]")]
    public class PasswordController : ControllerBase
    {
        private readonly IPasswordValidatorService _passwordValidatorService;

        public PasswordController(IPasswordValidatorService passwordValidatorService)
        {
            _passwordValidatorService = passwordValidatorService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public IActionResult Post([FromBody] Password password)
        {
            var result = _passwordValidatorService.ValidatePassword(password);
            return Ok(result);
        }
    }
}