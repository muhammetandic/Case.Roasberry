using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Shared;


public abstract class ShopifyObject
{
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphQLAPIId { get; set; }
}

