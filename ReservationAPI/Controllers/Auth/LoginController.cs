using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Models.Dto;
using ReservationAPI.Repositories;
using ReservationAPI.Services;

namespace ReservationAPI.Controllers.Auth
{
    [ApiController]
    [Route("api/v1/login")]
    public class LoginController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        private readonly IConfiguration _configuration;
        public LoginController(UserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;

        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userRepository.GetUserByUsername(request.Username);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            if (user.Password != request.Password)
            {
                return BadRequest(new
                {
                    message="User password incorrect."
                });
            }

            return Ok(new
            {
                token = GenerateJwtToken.Generate(new JwtUserInfo
                {
                    UserId = user.Id,
                    UserName = user.Username
                }, _configuration)
            });
        }
    }
}
