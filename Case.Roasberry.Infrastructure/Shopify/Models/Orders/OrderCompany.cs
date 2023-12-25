using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class OrderCompany
{
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonProperty("location_id")]
    public long? LocationId { get; set; }
}
