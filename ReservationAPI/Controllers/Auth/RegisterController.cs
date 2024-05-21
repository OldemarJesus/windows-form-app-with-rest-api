using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Models;
using ReservationAPI.Models.Dto;
using ReservationAPI.Repositories;
using ReservationAPI.Services;

namespace ReservationAPI.Controllers.Auth
{
    [ApiController]
    [Route("api/v1/register")]
    public class RegisterController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public RegisterController(UserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;

        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserRegisterRequest request)
        {
            // validate if fields were fullfilled
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            User user = new User
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                Username = request.Username,
                Password = request.Password,
                CreatedAt = DateTime.UtcNow,
            };

            var result = await _userRepository.CreateUser(user);

            if (!result)
            {
                return BadRequest("Failed to create the user!");
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
