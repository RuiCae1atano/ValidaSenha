using Microsoft.AspNetCore.Mvc;
using ValidationPassword.Application.Interfaces;
using ValidationSenha.Domain.Models;

namespace ValidaSenha.API.Controllers
{
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
            _passwordValidatorService.ValidatePassword(password);
            return Ok("Sua password foi validada com sucesso");
        }
    }
}