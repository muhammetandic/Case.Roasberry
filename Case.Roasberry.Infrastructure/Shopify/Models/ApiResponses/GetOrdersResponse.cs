using Case.Roasberry.Infrastructure.Shopify.Models.Orders;
using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.ApiResponses;
public class GetOrdersResponse
{
    [JsonPropertyName("orders")]
    public List<Order>? Orders { get; set; }
}
