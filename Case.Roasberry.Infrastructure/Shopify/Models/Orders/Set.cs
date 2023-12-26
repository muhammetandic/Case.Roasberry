using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public partial class Set
{
    [JsonPropertyName("shop_money")]
    public Money? ShopMoney { get; set; }

    [JsonPropertyName("presentment_money")]
    public Money? PresentmentMoney { get; set; }
}
