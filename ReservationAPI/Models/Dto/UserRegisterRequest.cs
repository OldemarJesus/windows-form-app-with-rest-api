using System.ComponentModel.DataAnnotations;

namespace ReservationAPI.Models.Dto
{
    public class UserRegisterRequest
    {
        [MaxLength(50)]
        [MinLength(3)]
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(50)]
        [MinLength(3)]
        [Required]
        public string LastName { get; set; } = string.Empty;

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
