using ReservationWF.Models;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace ReservationWF.Services
{
    public class ReservationService
    {
        private readonly HttpClient _httpClient;
        public ReservationService(string token)
        {
            // ignore ssl
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };
            _httpClient = new HttpClient(handler);
            _httpClient.BaseAddress = new Uri("https://localhost:7222");
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<Reservation>?> GetAll() 
        {
            using var result = await _httpClient.GetAsync("api/v1/reservations");
            if (!result.IsSuccessStatusCode) 
            {
                return new List<Reservation>();
            }

            var jsonString = await result.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Reservation>>(jsonString);
        }

        public async Task<string?> CreateReservation(ReservationInfo reservation)
        {
            var content = new StringContent(
                JsonSerializer.Serialize(new
                {
                    firstName = reservation.OwnerFirstName,
                    lastName = reservation.OwnerLastName,
                    totalPeople = reservation.TotalPeople,
                    startDate = reservation.StartDate,
                    endDate = reservation.EndDate
                }).ToString(),
                Encoding.UTF8,
                "application/json");
            using var result = await _httpClient.PostAsync("api/v1/reservations", content);
            if (!result.IsSuccessStatusCode)
            {
                return string.Empty;
            }

            var jsonString = await result.Content.ReadAsStringAsync();

            if (jsonString == null)
            {
                return string.Empty;
            }

            var jsonObj = JsonDocument.Parse(jsonString);
            return jsonObj.RootElement.GetProperty("id").GetString();
        }
    }
}
