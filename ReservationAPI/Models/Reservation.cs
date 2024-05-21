namespace ReservationAPI.Models
{
    public class Reservation
    {
        public string Id { get; set; } = string.Empty;
        public string OwnerFirstName {  get; set; } = string.Empty;
        public string OwnerLastName {  get; set; } = string.Empty;
        public string OwnerId { get; set; } = string.Empty;
        public int TotalPeople { get; set; } = 0;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
