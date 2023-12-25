using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class ShippingLine : ShopifyObject
{
    [JsonProperty("carrier_identifier")]
    public string CarrierIdentifier { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("phone")]
    public string Phone { get; set; }

    [JsonProperty("price")]
    public decimal? Price { get; set; }

    [JsonProperty("discounted_price")]
    public decimal? DiscountedPrice { get; set; }

    [JsonProperty("discount_allocations")]
    public IEnumerable<DiscountAllocation> DiscountAllocations { get; set; }

    [JsonProperty("source")]
    public string Source { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("tax_lines")]
    public IEnumerable<TaxLine> TaxLines { get; set; }

    [JsonProperty("price_set")]
    public PriceSet PriceSet { get; set; }

    [JsonProperty("discounted_price_set")]
    public PriceSet DiscountedPriceSet { get; set; }
}
