using System.Text.Json.Serialization;

namespace Swagger.Petstore.Model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PetStatus
    {
        Available,
        Pending,
        Sold
    }
}