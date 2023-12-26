using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public class Customer
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("email")]
    public string? Email { get; set; }

    [JsonProperty("created_at")]
    public object? CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public object? UpdatedAt { get; set; }

    [JsonProperty("first_name")]
    public string? FirstName { get; set; }

    [JsonProperty("last_name")]
    public string? LastName { get; set; }

    [JsonProperty("state")]
    public string? State { get; set; }

    [JsonProperty("note")]
    public object? Note { get; set; }

    [JsonProperty("verified_email")]
    public bool VerifiedEmail { get; set; }

    [JsonProperty("multipass_identifier")]
    public object? MultipassIdentifier { get; set; }

    [JsonProperty("tax_exempt")]
    public bool TaxExempt { get; set; }

    [JsonProperty("phone")]
    public object? Phone { get; set; }

    [JsonProperty("email_marketing_consent")]
    public EmailMarketingConsent? EmailMarketingConsent { get; set; }

    [JsonProperty("sms_marketing_consent")]
    public object? SmsMarketingConsent { get; set; }

    [JsonProperty("tags")]
    public string? Tags { get; set; }

    [JsonProperty("currency")]
    public string? Currency { get; set; }

    [JsonProperty("tax_exemptions")]
    public object?[]? TaxExemptions { get; set; }

    [JsonProperty("admin_graphql_api_id")]
    public string? AdminGraphqlApiId { get; set; }

    [JsonProperty("default_address")]
    public Address? DefaultAddress { get; set; }
}
