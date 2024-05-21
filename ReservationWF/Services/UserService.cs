using ReservationWF.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ReservationWF.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;

        public UserService(string token)
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

        public async Task<UserProfile?> GetProfileInfo()
        {
            var result = await _httpClient.GetAsync("api/v1/profile");
            if (!result.IsSuccessStatusCode)
            {
                return null;
            }

            var jsonString = await result.Content.ReadAsStringAsync();

            if (jsonString == null)
            {
                return null;
            }

            var jsonObj = JsonDocument.Parse(jsonString);
            var userProfileId = jsonObj.RootElement.GetProperty("userProfileId").GetString();
            var firstName = jsonObj.RootElement.GetProperty("firstName").GetString();
            var lastName = jsonObj.RootElement.GetProperty("lastName").GetString();
            var username = jsonObj.RootElement.GetProperty("username").GetString();

            if (userProfileId== null ||
                firstName== null ||
                lastName== null ||
                username== null)
            {
                return null;
            }

            var user = new UserProfile
            {
                Id = userProfileId,
                FirstName = firstName,
                LastName = lastName,
                Username = username
            };

            return user;
        }
    }
}
