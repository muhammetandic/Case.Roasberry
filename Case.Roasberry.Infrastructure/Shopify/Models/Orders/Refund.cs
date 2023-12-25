using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class Refund : ShopifyObject
{
    [JsonProperty("order_id")]
    public long? OrderId { get; set; }

    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonProperty("notify")]
    public bool? Notify { get; set; }

    [JsonProperty("shipping")]
    public Shipping Shipping { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("order_adjustments")]
    public IEnumerable<RefundOrderAdjustment> OrderAdjustments { get; set; }

    [JsonProperty("processed_at")]
    public DateTimeOffset? ProcessedAt { get; set; }

    [JsonProperty("note")]
    public string Note { get; set; }

    [JsonProperty("discrepancy_reason")]
    public string DiscrepancyReason { get; set; }

    [JsonProperty("refund_line_items")]
    public IEnumerable<RefundLineItem> RefundLineItems { get; set; }

    [JsonProperty("user_id")]
    public long? UserId { get; set; }

    [JsonProperty("return")]
    public Return Return { get; set; }
}

public class Shipping
{
    [JsonProperty("full_refund")]
    public bool? FullRefund { get; set; }

    [JsonProperty("amount")]
    public decimal? Amount { get; set; }

    [JsonProperty("maximum_refundable")]
    public decimal? MaximumRefundable { get; set; }
}