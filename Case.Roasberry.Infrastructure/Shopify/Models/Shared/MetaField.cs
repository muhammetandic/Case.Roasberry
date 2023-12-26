using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Shared;
public class MetaField : ShopifyObject
{
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public object? Value { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("owner_id")]
    public long? OwnerId { get; set; }

    [JsonPropertyName("owner_resource")]
    public string? OwnerResource { get; set; }
}