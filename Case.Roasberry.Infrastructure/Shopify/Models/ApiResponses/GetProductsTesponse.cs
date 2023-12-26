using Case.Roasberry.Infrastructure.Shopify.Models.Products;
using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.ApiResponses;
public class GetProductsTesponse
{
    [JsonPropertyName("products")]
    public List<Product>? Products { get; set; }
}
