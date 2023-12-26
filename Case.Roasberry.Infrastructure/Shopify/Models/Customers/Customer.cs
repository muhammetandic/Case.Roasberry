using Case.Roasberry.Infrastructure.Shopify.Models.Orders;
using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Customers;
public class Customer : ShopifyObject
{
    [JsonPropertyName("addresses")]
    public IEnumerable<Address>? Addresses { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("default_address")]
    public Address? DefaultAddress { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("multipass_identifier")]
    public string? MultipassIdentifier { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("last_order_id")]
    public long? LastOrderId { get; set; }

    [JsonPropertyName("last_order_name")]
    public string? LastOrderName { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("orders_count")]
    public int? OrdersCount { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    [JsonPropertyName("tax_exempt")]
    public bool? TaxExempt { get; set; }

    [JsonPropertyName("tax_exemptions")]
    public string[]? TaxExemptions { get; set; }

    [JsonPropertyName("total_spent")]
    public decimal? TotalSpent { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("verified_email")]
    public bool? VerifiedEmail { get; set; }

    [JsonPropertyName("sms_marketing_consent")]
    public CustomerSmsMarketingConsent? SmsMarketingConsent { get; set; }

    [JsonPropertyName("metafields")]
    public IEnumerable<MetaField>? Metafields { get; set; }

    [JsonPropertyName("email_marketing_consent")]
    public CustomerEmailMarketingConsent? EmailMarketingConsent { get; set; }
}