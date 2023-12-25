using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class LineItem : ShopifyObject
{
    [JsonProperty("fulfillable_quantity")]
    public int? FulfillableQuantity { get; set; }

    [JsonProperty("fulfillment_service")]
    public string FulfillmentService { get; set; }

    [JsonProperty("fulfillment_status")]
    public string FulfillmentStatus { get; set; }

    [JsonProperty("grams")]
    public long? Grams { get; set; }

    [JsonProperty("price")]
    public decimal? Price { get; set; }

    [JsonProperty("product_id")]
    public long? ProductId { get; set; }

    [JsonProperty("quantity")]
    public int? Quantity { get; set; }

    [JsonProperty("requires_shipping")]
    public bool? RequiresShipping { get; set; }

    [JsonProperty("sku")]
    public string SKU { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("variant_id")]
    public long? VariantId { get; set; }

    [JsonProperty("variant_title")]
    public string VariantTitle { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("vendor")]
    public string Vendor { get; set; }

    [JsonProperty("gift_card")]
    public bool? GiftCard { get; set; }

    [JsonProperty("taxable")]
    public bool? Taxable { get; set; }

    [JsonProperty("tax_lines")]
    public IEnumerable<TaxLine> TaxLines { get; set; }

    [JsonProperty("tip_payment_gateway", NullValueHandling = NullValueHandling.Include)]
    public string TipPaymentGateway { get; set; }

    [JsonProperty("tip_payment_method")]
    public string TipPaymentMethod { get; set; }

    [JsonIgnore]
    public bool TipPaymentGatewaySpecified { get; set; }

    [JsonProperty("total_discount")]
    public decimal? TotalDiscount { get; set; }

    [JsonProperty("total_discount_set")]
    public PriceSet TotalDiscountSet { get; set; }

    [JsonProperty("discount_allocations")]
    public IEnumerable<DiscountAllocation> DiscountAllocations { get; set; }

    [JsonProperty("variant_inventory_management")]
    public string VariantInventoryManagement { get; set; }

    [JsonProperty("product_exists")]
    public bool? ProductExists { get; set; }

    [JsonProperty("price_set")]
    public PriceSet PriceSet { get; set; }

    [JsonProperty("pre_tax_price")]
    public decimal? PreTaxPrice { get; set; }

    [JsonProperty("pre_tax_price_set")]
    public PriceSet PreTaxPriceSet { get; set; }

    [JsonProperty("fulfillment_line_item_id")]
    public long? FulfillmentLineItemId { get; set; }
}