using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public class Set
{
    [JsonProperty("shop_money")]
    public Money? ShopMoney { get; set; }

    [JsonProperty("presentment_money")]
    public Money? PresentmentMoney { get; set; }
}
