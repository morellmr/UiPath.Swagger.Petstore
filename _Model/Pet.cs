using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Swagger.Petstore.Model
{
    public class Pet
    {
        [JsonPropertyName("id")]
        public long? Id { get; set; }
        
        [JsonPropertyName("category")]
        public Category? Category { get; set; }
        
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [Required]
        [JsonPropertyName("photoUrls")]
        public List<string> PhotoUrls { get; set; }
        
        [JsonPropertyName("tags")]
        public List<Tag>? Tags { get; set; }
        
        [JsonPropertyName("status")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetStatus? Status { get; set; }
    }
}