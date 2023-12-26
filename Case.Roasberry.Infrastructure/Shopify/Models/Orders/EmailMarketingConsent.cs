using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public class EmailMarketingConsent
{
    [JsonProperty("state")]
    public string? State { get; set; }

    [JsonProperty("opt_in_level")]
    public object? OptInLevel { get; set; }

    [JsonProperty("consent_updated_at")]
    public object? ConsentUpdatedAt { get; set; }
}
