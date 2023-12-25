using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class RefundLineItem : ShopifyObject
{
    [JsonProperty("line_item")]
    public LineItem LineItem { get; set; }

    [JsonProperty("line_item_id")]
    public long? LineItemId { get; set; }

    [JsonProperty("quantity")]
    public int? Quantity { get; set; }

    [JsonProperty("total_tax")]
    public decimal? TotalTax { get; set; }

    [JsonProperty("subtotal")]
    public decimal? SubTotal { get; set; }

    [JsonProperty("subtotal_set")]
    public PriceSet SubTotalTaxSet { get; set; }

    [JsonProperty("total_tax_set")]
    public PriceSet TotalTaxSet { get; set; }

    [JsonProperty("restock_type")]
    public string RestockType { get; set; }

    [JsonProperty("location_id")]
    public long? LocationId { get; set; }
}