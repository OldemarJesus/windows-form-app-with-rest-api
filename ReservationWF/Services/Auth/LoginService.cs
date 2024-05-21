using System.Text;
using System.Text.Json;

namespace ReservationWF.Services.Auth
{
    public class LoginService
    {
        private readonly HttpClient _httpClient;
        public LoginService()
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
        }
        public async Task<string?> GetToken(string username, string password)
        {
            var content = new StringContent(
                JsonSerializer.Serialize(new { username, password }).ToString(),
                Encoding.UTF8,
                "application/json");
            using var result = await _httpClient.PostAsync("api/v1/login", content);

            if(!result.IsSuccessStatusCode)
            {
                return string.Empty;
            }

            var jsonString = await result.Content.ReadAsStringAsync();

            if (jsonString == null)
            {
                return string.Empty;
            }

            var jsonObj = JsonDocument.Parse(jsonString);
            return jsonObj.RootElement.GetProperty("token").GetString();
        }
    }
}
