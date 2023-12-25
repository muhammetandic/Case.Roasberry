using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Products;
public class ProductOption : ShopifyObject
{
    [JsonProperty("product_id")]
    public long? ProductId { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("position")]
    public int? Position { get; set; }

    [JsonProperty("values")]
    public IEnumerable<string> Values { get; set; }
}