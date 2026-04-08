using System.Text.Json.Serialization;

namespace Swagger.Petstore.Model
{
    public class Category
    {
        [JsonPropertyName("id")]
        public long? Id { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}