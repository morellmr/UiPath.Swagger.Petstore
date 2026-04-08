using System;
using System.Text.Json.Serialization;

namespace Swagger.Petstore.Model
{
    public class Order
    {
        [JsonPropertyName("id")]
        public long? Id { get; set; }
        
        [JsonPropertyName("petId")]
        public long? PetId { get; set; }
        
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
        
        [JsonPropertyName("shipDate")]
        public DateTime? ShipDate { get; set; }
        
        [JsonPropertyName("status")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public OrderStatus? status { get; set; }
        
        [JsonPropertyName("complete")]
        public bool? Complete { get; set; }
    }
}