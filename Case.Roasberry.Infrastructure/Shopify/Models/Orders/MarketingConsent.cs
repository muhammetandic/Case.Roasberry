using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public partial class MarketingConsent
{
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("opt_in_level")]
    public string? OptInLevel { get; set; }

    [JsonPropertyName("consent_updated_at")]
    public object? ConsentUpdatedAt { get; set; }

    [JsonPropertyName("consent_collected_from")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ConsentCollectedFrom { get; set; }
}
