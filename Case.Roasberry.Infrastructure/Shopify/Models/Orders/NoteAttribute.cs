using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class NoteAttribute
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("value")]
    public object Value { get; set; }
}