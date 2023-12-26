using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Products;
public class ProductImage : ShopifyObject
{
    [JsonPropertyName("product_id")]
    public long? ProductId { get; set; }

    [JsonPropertyName("position")]
    public int? Position { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("src")]
    public string? Src { get; set; }

    [JsonPropertyName("filename")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Filename { get; set; }

    [JsonPropertyName("attachment")]
    public string? Attachment { get; set; }

    [JsonPropertyName("variant_ids")]
    public IEnumerable<long>? VariantIds { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("alt")]
    public string? Alt { get; set; }

    [JsonPropertyName("metafields")]
    public IEnumerable<MetaField>? Metafields { get; set; }
}