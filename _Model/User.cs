using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Swagger.Petstore.Model
{
    public class User
    {
        [JsonPropertyName("id")]
        public long? Id { get; set; }
        
        [JsonPropertyName("username")]
        public string? Username { get; set; }
        
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }
        
        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }
        
        [EmailAddress]
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        
        [Phone]
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }
        
        [JsonPropertyName("userStatus")]
        public int? UserStatus { get; set; }
    }
}