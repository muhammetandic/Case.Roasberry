using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Shared;


public abstract class ShopifyObject
{
    [JsonProperty("id")]
    public long? Id { get; set; }

    [JsonProperty("admin_graphql_api_id")]
    public string AdminGraphQLAPIId { get; set; }
}

