using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Products;
public class ProductVariant : ShopifyObject
{
    [JsonPropertyName("product_id")]
    public long? ProductId { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("sku")]
    public string? SKU { get; set; }

    [JsonPropertyName("position")]
    public int? Position { get; set; }

    [JsonPropertyName("grams")]
    public long? Grams { get; set; }

    [JsonPropertyName("inventory_policy")]
    public string? InventoryPolicy { get; set; }

    [JsonPropertyName("fulfillment_service")]
    public string? FulfillmentService { get; set; }

    [JsonPropertyName("inventory_item_id")]
    public long? InventoryItemId { get; set; }

    [JsonPropertyName("inventory_management")]
    public string? InventoryManagement { get; set; }

    [JsonPropertyName("price")]
    public decimal? Price { get; set; }

    [JsonPropertyName("compare_at_price")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? CompareAtPrice { get; set; }

    [JsonPropertyName("option1")]
    public string? Option1 { get; set; }

    [JsonPropertyName("option2")]
    public string? Option2 { get; set; }

    [JsonPropertyName("option3")]
    public string? Option3 { get; set; }

    [JsonPropertyName("created_at")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("taxable")]
    public bool? Taxable { get; set; }

    [JsonPropertyName("tax_code")]
    public string? TaxCode { get; set; }

    [JsonPropertyName("requires_shipping")]
    public bool? RequiresShipping { get; set; }

    [JsonPropertyName("barcode")]
    public string? Barcode { get; set; }

    [JsonPropertyName("inventory_quantity")]
    public long? InventoryQuantity { get; set; }

    [JsonPropertyName("image_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? ImageId { get; set; }

    [JsonPropertyName("weight")]
    public decimal? Weight { get; set; }

    [JsonPropertyName("weight_unit")]
    public string? WeightUnit { get; set; }

    [JsonPropertyName("metafields")]
    public IEnumerable<MetaField>? Metafields { get; set; }

    //[JsonPropertyName("presentment_prices")]
    //public IEnumerable<PresentmentPrice> PresentmentPrices { get; set; }
}
