using Microsoft.AspNetCore.Mvc;
using TaskPlanner.API.DTOs;
using TaskPlanner.API.Repositories.Interfaces;

namespace TaskPlanner.API.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IUserRepository userRepository, ILogger<AuthController> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto request)
        {
            _logger.LogInformation("Registration start...");
            var user = _userRepository.GetUserByName(request.Name);
            if (user != null)
            {
                return BadRequest();
            }

            return Ok(request);
        }
    }
}
