using System.ComponentModel.DataAnnotations;

namespace ReservationAPI.Models.Dto
{
    public class ReservationAddRequest
    {
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public int TotalPeople { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}
