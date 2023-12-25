using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Products;
public class ProductVariant : ShopifyObject
{
    [JsonProperty("product_id")]
    public long? ProductId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("sku")]
    public string SKU { get; set; }

    [JsonProperty("position")]
    public int? Position { get; set; }

    [JsonProperty("grams")]
    public long? Grams { get; set; }

    [JsonProperty("inventory_policy")]
    public string InventoryPolicy { get; set; }

    [JsonProperty("fulfillment_service")]
    public string FulfillmentService { get; set; }

    [JsonProperty("inventory_item_id")]
    public long? InventoryItemId { get; set; }

    [JsonProperty("inventory_management")]
    public string InventoryManagement { get; set; }

    [JsonProperty("price")]
    public decimal? Price { get; set; }

    [JsonProperty("compare_at_price", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
    public decimal? CompareAtPrice { get; set; }

    [JsonProperty("option1")]
    public string Option1 { get; set; }

    [JsonProperty("option2")]
    public string Option2 { get; set; }

    [JsonProperty("option3")]
    public string Option3 { get; set; }

    [JsonProperty("created_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonProperty("updated_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonProperty("taxable")]
    public bool? Taxable { get; set; }

    [JsonProperty("tax_code")]
    public string TaxCode { get; set; }

    [JsonProperty("requires_shipping")]
    public bool? RequiresShipping { get; set; }

    [JsonProperty("barcode")]
    public string Barcode { get; set; }

    [JsonProperty("inventory_quantity")]
    public long? InventoryQuantity { get; set; }

    [JsonProperty("image_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public long? ImageId { get; set; }

    [JsonProperty("weight")]
    public decimal? Weight { get; set; }

    [JsonProperty("weight_unit")]
    public string WeightUnit { get; set; }

    [JsonProperty("metafields")]
    public IEnumerable<MetaField> Metafields { get; set; }

    //[JsonProperty("presentment_prices")]
    //public IEnumerable<PresentmentPrice> PresentmentPrices { get; set; }
}
