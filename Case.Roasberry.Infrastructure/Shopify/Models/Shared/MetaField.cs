using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Shared;
public class MetaField : ShopifyObject
{
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("value")]
    public object Value { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("owner_id")]
    public long? OwnerId { get; set; }

    [JsonProperty("owner_resource")]
    public string OwnerResource { get; set; }
}