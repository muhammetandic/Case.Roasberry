using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class RefundOrderAdjustment : ShopifyObject
{
    [JsonProperty("order_id")]
    public long? OrderId { get; set; }

    [JsonProperty("refund_id")]
    public long? RefundId { get; set; }

    [JsonProperty("amount")]
    public decimal? Amount { get; set; }

    [JsonProperty("tax_amount")]
    public decimal? TaxAmount { get; set; }

    [JsonProperty("kind")]
    public string Kind { get; set; }

    public string Reason { get; set; }

    [JsonProperty("amount_set")]
    public PriceSet AmountSet { get; set; }

    [JsonProperty("tax_amount_set")]
    public PriceSet TaxAmountSet { get; set; }
}
