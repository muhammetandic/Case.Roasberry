using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class DiscountAllocation
{
    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("discount_application_index")]
    public long DiscountApplicationIndex { get; set; }

    [JsonProperty("amount_set")]
    public PriceSet AmountSet { get; set; }
}