using System.ComponentModel.DataAnnotations;

namespace ReservationAPI.Models.Dto
{
    public class UserLoginRequest
    {
        [MaxLength(50)]
        [MinLength(3)]
        [Required]
        public string Username { get; set; } = string.Empty;

        [MaxLength(255)]
        [MinLength(8)]
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
