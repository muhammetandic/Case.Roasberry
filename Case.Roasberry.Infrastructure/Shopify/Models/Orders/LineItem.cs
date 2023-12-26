using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public class LineItem
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("admin_graphql_api_id")]
    public string? AdminGraphqlApiId { get; set; }

    [JsonProperty("attributed_staffs")]
    public AttributedStaff[]? AttributedStaffs { get; set; }

    [JsonProperty("current_quantity")]
    public long CurrentQuantity { get; set; }

    [JsonProperty("fulfillable_quantity")]
    public long FulfillableQuantity { get; set; }

    [JsonProperty("fulfillment_service")]
    public string? FulfillmentService { get; set; }

    [JsonProperty("fulfillment_status")]
    public object? FulfillmentStatus { get; set; }

    [JsonProperty("gift_card")]
    public bool GiftCard { get; set; }

    [JsonProperty("grams")]
    public long Grams { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("price")]
    public string? Price { get; set; }

    [JsonProperty("price_set")]
    public Set? PriceSet { get; set; }

    [JsonProperty("product_exists")]
    public bool ProductExists { get; set; }

    [JsonProperty("product_id")]
    public long ProductId { get; set; }

    [JsonProperty("properties")]
    public object?[]? Properties { get; set; }

    [JsonProperty("quantity")]
    public long Quantity { get; set; }

    [JsonProperty("requires_shipping")]
    public bool RequiresShipping { get; set; }

    [JsonProperty("sku")]
    public string? Sku { get; set; }

    [JsonProperty("taxable")]
    public bool Taxable { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("total_discount")]
    public string? TotalDiscount { get; set; }

    [JsonProperty("total_discount_set")]
    public Set? TotalDiscountSet { get; set; }

    [JsonProperty("variant_id")]
    public long VariantId { get; set; }

    [JsonProperty("variant_inventory_management")]
    public string? VariantInventoryManagement { get; set; }

    [JsonProperty("variant_title")]
    public object? VariantTitle { get; set; }

    [JsonProperty("vendor")]
    public object? Vendor { get; set; }

    [JsonProperty("tax_lines")]
    public object?[]? TaxLines { get; set; }

    [JsonProperty("duties")]
    public object?[]? Duties { get; set; }

    [JsonProperty("discount_allocations")]
    public object?[]? DiscountAllocations { get; set; }
}
