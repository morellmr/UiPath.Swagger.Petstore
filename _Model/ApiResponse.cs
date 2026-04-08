using System.Text.Json.Serialization;

namespace Swagger.Petstore.Model
{
    public class ApiResponse
    {
        [JsonPropertyName("code")]
        public int? Code { get; set; }
        
        [JsonPropertyName("type")]
        public string? type { get; set; }
        
        [JsonPropertyName("message")]
        public string? message { get; set; }
    }
}