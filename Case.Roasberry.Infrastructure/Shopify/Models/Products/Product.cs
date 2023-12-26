using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Products;

public class Product : ShopifyObject
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("body_html")]
    public string? BodyHtml { get; set; }

    [JsonPropertyName("created_at")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("published_at")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTimeOffset? PublishedAt { get; set; }

    [JsonPropertyName("vendor")]
    public string? Vendor { get; set; }

    [JsonPropertyName("product_type")]
    public string? ProductType { get; set; }

    [JsonPropertyName("handle")]
    public string? Handle { get; set; }

    [JsonPropertyName("template_suffix")]
    public string? TemplateSuffix { get; set; }

    [JsonPropertyName("published_scope")]
    public string? PublishedScope { get; set; }

    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("variants")]
    public IEnumerable<ProductVariant>? Variants { get; set; }

    [JsonPropertyName("options")]
    public IEnumerable<ProductOption>? Options { get; set; }

    [JsonPropertyName("images")]
    public IEnumerable<ProductImage>? Images { get; set; }

    [JsonPropertyName("metafields")]
    public IEnumerable<MetaField>? Metafields { get; set; }
}