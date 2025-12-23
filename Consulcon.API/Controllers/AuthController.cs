using System.Threading.Tasks;
using Consulcon.Application.DTOs;
using Consulcon.Application.Interfaces;
using Consulcon.Domain.Common;
using Microsoft.AspNetCore.Mvc;

namespace Consulcon.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var result = await _authService.LoginAsync(request.Username, request.Password);

            if (result.IsFailure)
            {
                return Unauthorized(new { Message = result.Error });
            }

            return Ok(new 
            { 
                Message = "Login exitoso", 
                Data = result.Value
            });
        }
    }
}
