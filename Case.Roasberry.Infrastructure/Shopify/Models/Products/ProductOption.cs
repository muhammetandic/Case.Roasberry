using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Products;
public class ProductOption : ShopifyObject
{
    [JsonPropertyName("product_id")]
    public long? ProductId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("position")]
    public int? Position { get; set; }

    [JsonPropertyName("values")]
    public IEnumerable<string>? Values { get; set; }
}