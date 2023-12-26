using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Customers;
public class CustomerEmailMarketingConsent
{
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("opt_in_level")]
    public string? OptInLevel { get; set; }

    [JsonPropertyName("consent_updated_at")]
    public DateTimeOffset? ConsentUpdatedAt { get; set; }
}