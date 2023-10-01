using System.Text.Json;

namespace SocialMediaAnalyis.Entities.ErrorModel
{
    public partial class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public string? InnerException { get; set; }
        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
