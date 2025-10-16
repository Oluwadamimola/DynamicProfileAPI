namespace DynamicProfileAPI.Models
{
    public class ProfileResponse
    {
        public string? Status { get; set; }
        public User? User { get; set; }
        public string? Timestamp { get; set; }
        public string? Fact { get; set; }
    }
}