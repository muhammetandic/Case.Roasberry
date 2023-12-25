using Case.Roasberry.Infrastructure.Shopify.Models.Orders;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.ApiResponses;
public class GetOrdersResponse
{
    [JsonProperty("orders")]
    public List<Order> Orders { get; set; }
}
