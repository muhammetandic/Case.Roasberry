using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Products;
public class ProductImage : ShopifyObject
{
    [JsonProperty("product_id")]
    public long? ProductId { get; set; }

    [JsonProperty("position")]
    public int? Position { get; set; }

    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonProperty("src")]
    public string Src { get; set; }

    [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Filename { get; set; }

    [JsonProperty("attachment")]
    public string Attachment { get; set; }

    [JsonProperty("variant_ids")]
    public IEnumerable<long> VariantIds { get; set; }

    [JsonProperty("height")]
    public int? Height { get; set; }

    [JsonProperty("width")]
    public int? Width { get; set; }

    [JsonProperty("alt")]
    public string Alt { get; set; }

    [JsonProperty("metafields")]
    public IEnumerable<MetaField> Metafields { get; set; }
}