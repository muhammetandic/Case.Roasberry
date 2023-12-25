using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Customers;
public class CustomerEmailMarketingConsent
{
    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("opt_in_level")]
    public string OptInLevel { get; set; }

    [JsonProperty("consent_updated_at")]
    public DateTimeOffset? ConsentUpdatedAt { get; set; }
}