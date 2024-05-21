using System.Text.Json.Serialization;

namespace ReservationWF.Models
{
    public class Reservation
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        [JsonPropertyName("ownerFirstName")]
        public string OwnerFirstName { get; set; } = string.Empty;
        [JsonPropertyName("ownerLastName")]
        public string OwnerLastName { get; set; } = string.Empty;
        [JsonPropertyName("ownerId")]
        public string OwnerId { get; set; } = string.Empty;
        [JsonPropertyName("totalPeople")]
        public int TotalPeople { get; set; } = 0;
        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }
        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}
