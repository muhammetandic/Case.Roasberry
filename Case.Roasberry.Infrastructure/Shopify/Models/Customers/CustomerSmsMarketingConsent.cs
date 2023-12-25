using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Customers;
public class CustomerSmsMarketingConsent
{
    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("opt_in_level")]
    public string OptInLevel { get; set; }

    [JsonProperty("consent_updated_at")]
    public DateTimeOffset? ConsentUpdatedAt { get; set; }

    [JsonProperty("consent_collected_from")]
    public string ConsentCollectedFrom { get; set; }
}
