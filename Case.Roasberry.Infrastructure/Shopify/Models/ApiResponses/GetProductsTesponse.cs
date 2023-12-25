using Case.Roasberry.Infrastructure.Shopify.Models.Products;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.ApiResponses;
public class GetProductsTesponse
{
    [JsonProperty("products")]
    public List<Product> Products { get; set; }
}
