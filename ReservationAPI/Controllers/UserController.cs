using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Models.Dto;
using ReservationAPI.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ReservationAPI.Controllers
{
    [ApiController]
    [Route("api/v1/profile")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetInfo()
        {
            ClaimsIdentity? user = HttpContext.User.Identity as ClaimsIdentity;

            if (user == null)
            {
                return NotFound("User Not Found");
            }

            var id = user.FindFirst("UserId")?.Value;

            if (id == null)
            {
                return NotFound("User Not Found");
            }

            var userInDb = await _userRepository.GetUserById(id);

            if (userInDb == null)
            {
                return NotFound("User Not Found");
            }

            var profile = new UserProfileRepsonse
            {
                UserProfileId = userInDb.Id,
                FirstName = userInDb.FirstName,
                LastName = userInDb.LastName,
                Username = userInDb.Username,
            };

            return Ok(profile);
        }
    }
}
