using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Models;
using ReservationAPI.Models.Dto;
using ReservationAPI.Repositories;
using System.Security.Claims;

namespace ReservationAPI.Controllers
{
    [ApiController]
    [Route("api/v1/reservations")]
    [Authorize]
    public class ReservationController : ControllerBase
    {
        private readonly ReservationRepostitory _repository;
        public ReservationController(ReservationRepostitory repostitory)
        {
            _repository = repostitory;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var reservations = await _repository.GetAll();
            return Ok(reservations);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ReservationAddRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = HttpContext.User.Identity as ClaimsIdentity;

            if (user == null)
            {
                return Unauthorized();
            }
            var id = user.FindFirst("UserId")?.Value;

            if(id == null)
            {
                return Unauthorized();
            }

            var reservation = new Reservation
            {
                Id = Guid.NewGuid().ToString(),
                OwnerFirstName = request.FirstName,
                OwnerLastName = request.LastName,
                OwnerId = id,
                TotalPeople = request.TotalPeople,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                CreatedAt = DateTime.UtcNow,
            };
            var result = await _repository.CreateReservation(reservation);

            if(result)
            {
                return Ok(reservation);
            }

            return BadRequest();
        }
    }
}
