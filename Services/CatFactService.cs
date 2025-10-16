using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DynamicProfileAPI.Services
{
    public class CatFactService
    {
        private readonly HttpClient _httpClient;

        public CatFactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.Timeout = TimeSpan.FromSeconds(5); 
        }

        public async Task<string> GetRandomCatFactAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://catfact.ninja/fact");

                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();

                using var doc = JsonDocument.Parse(content);
                var fact = doc.RootElement.GetProperty("fact").GetString();

                return fact ?? "No cat fact available at the moment.";
            }
            catch (Exception)
            {
                return "Could not fetch a cat fact at the moment.";
            }
        }
    }
}
