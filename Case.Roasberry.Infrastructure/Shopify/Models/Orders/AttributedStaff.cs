using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public class AttributedStaff
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("quantity")]
    public long Quantity { get; set; }
}
