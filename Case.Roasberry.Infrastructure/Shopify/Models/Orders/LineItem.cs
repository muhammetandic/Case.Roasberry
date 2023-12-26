using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public partial class LineItem
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphqlApiId { get; set; }

    [JsonPropertyName("fulfillable_quantity")]
    public long FulfillableQuantity { get; set; }

    [JsonPropertyName("fulfillment_service")]
    public string? FulfillmentService { get; set; }

    [JsonPropertyName("fulfillment_status")]
    public object? FulfillmentStatus { get; set; }

    [JsonPropertyName("gift_card")]
    public bool GiftCard { get; set; }

    [JsonPropertyName("grams")]
    public long Grams { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("price")]
    public decimal? Price { get; set; }

    [JsonPropertyName("price_set")]
    public Set? PriceSet { get; set; }

    [JsonPropertyName("product_exists")]
    public bool ProductExists { get; set; }

    [JsonPropertyName("product_id")]
    public long ProductId { get; set; }

    [JsonPropertyName("properties")]
    public object?[]? Properties { get; set; }

    [JsonPropertyName("quantity")]
    public ulong Quantity { get; set; }

    [JsonPropertyName("requires_shipping")]
    public bool RequiresShipping { get; set; }

    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    [JsonPropertyName("taxable")]
    public bool Taxable { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("total_discount")]
    public decimal? TotalDiscount { get; set; }

    [JsonPropertyName("total_discount_set")]
    public Set? TotalDiscountSet { get; set; }

    [JsonPropertyName("variant_id")]
    public long VariantId { get; set; }

    [JsonPropertyName("variant_inventory_management")]
    public string? VariantInventoryManagement { get; set; }

    [JsonPropertyName("variant_title")]
    public object? VariantTitle { get; set; }

    [JsonPropertyName("vendor")]
    public string? Vendor { get; set; }

    [JsonPropertyName("tax_lines")]
    public object?[]? TaxLines { get; set; }

    [JsonPropertyName("duties")]
    public object?[]? Duties { get; set; }

    [JsonPropertyName("discount_allocations")]
    public object?[]? DiscountAllocations { get; set; }
}
