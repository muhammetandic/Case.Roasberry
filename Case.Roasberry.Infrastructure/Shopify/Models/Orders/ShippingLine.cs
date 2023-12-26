using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public class ShippingLine
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("carrier_identifier")]
    public object? CarrierIdentifier { get; set; }

    [JsonProperty("code")]
    public object? Code { get; set; }

    [JsonProperty("discounted_price")]
    public string? DiscountedPrice { get; set; }

    [JsonProperty("discounted_price_set")]
    public Set? DiscountedPriceSet { get; set; }

    [JsonProperty("phone")]
    public object? Phone { get; set; }

    [JsonProperty("price")]
    public string? Price { get; set; }

    [JsonProperty("price_set")]
    public Set? PriceSet { get; set; }

    [JsonProperty("requested_fulfillment_service_id")]
    public object? RequestedFulfillmentServiceId { get; set; }

    [JsonProperty("source")]
    public string? Source { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("tax_lines")]
    public object?[]? TaxLines { get; set; }

    [JsonProperty("discount_allocations")]
    public object?[]? DiscountAllocations { get; set; }
}
