using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class TaxLine
{
    [JsonProperty("price")]
    public decimal? Price { get; set; }

    [JsonProperty("rate")]
    public decimal? Rate { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("price_set")]
    public PriceSet PriceSet { get; set; }
}