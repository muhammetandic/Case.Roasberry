using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class Transaction : ShopifyObject
{
    [JsonProperty("amount")]
    public decimal? Amount { get; set; }

    [JsonProperty("authorization")]
    public string Authorization { get; set; }

    [JsonProperty("authorization_expires_at")]
    public DateTimeOffset? AuthorizationExpiresAt { get; set; }

    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonProperty("device_id")]
    public long? DeviceId { get; set; }

    [JsonProperty("gateway")]
    public string Gateway { get; set; }

    [JsonProperty("source_name")]
    public string SourceName { get; set; }

    [JsonProperty("source")]
    public string Source { get; set; }

    [JsonProperty("payment_details")]
    public PaymentDetails PaymentDetails { get; set; }

    [JsonProperty("kind")]
    public string Kind { get; set; }

    [JsonProperty("order_id")]
    public long? OrderId { get; set; }

    [JsonProperty("receipt")]
    public object Receipt { get; set; }

    [JsonProperty("error_code")]
    public string ErrorCode { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("test")]
    public bool? Test { get; set; }

    [JsonProperty("user_id")]
    public long? UserId { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("location_id")]
    public long? LocationId { get; set; }

    [JsonProperty("parent_id")]
    public long? ParentId { get; set; }

    [JsonProperty("processed_at")]
    public DateTimeOffset? ProcessedAt { get; set; }

    [JsonProperty("maximum_refundable")]
    public decimal? MaximumRefundable { get; set; }

    [JsonProperty("payment_id")]
    public string PaymentId { get; set; }

    [JsonProperty("total_unsettled_set")]
    public PriceSet TotalUnsettledSet { get; set; }
}