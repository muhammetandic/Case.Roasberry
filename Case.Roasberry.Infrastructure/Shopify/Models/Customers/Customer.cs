using Case.Roasberry.Infrastructure.Shopify.Models.Orders;
using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Customers;
public class Customer : ShopifyObject
{
    [JsonProperty("addresses")]
    public IEnumerable<Address> Addresses { get; set; }

    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("default_address")]
    public Address DefaultAddress { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("first_name")]
    public string FirstName { get; set; }

    [JsonProperty("multipass_identifier")]
    public string MultipassIdentifier { get; set; }

    [JsonProperty("last_name")]
    public string LastName { get; set; }

    [JsonProperty("last_order_id")]
    public long? LastOrderId { get; set; }

    [JsonProperty("last_order_name")]
    public string LastOrderName { get; set; }

    [JsonProperty("note")]
    public string Note { get; set; }

    [JsonProperty("orders_count")]
    public int? OrdersCount { get; set; }

    [JsonProperty("phone")]
    public string Phone { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("tags")]
    public string Tags { get; set; }

    [JsonProperty("tax_exempt")]
    public bool? TaxExempt { get; set; }

    [JsonProperty("tax_exemptions")]
    public string[] TaxExemptions { get; set; }

    [JsonProperty("total_spent")]
    public decimal? TotalSpent { get; set; }

    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonProperty("verified_email")]
    public bool? VerifiedEmail { get; set; }

    [JsonProperty("sms_marketing_consent")]
    public CustomerSmsMarketingConsent SmsMarketingConsent { get; set; }

    [JsonProperty("metafields")]
    public IEnumerable<MetaField> Metafields { get; set; }

    [JsonProperty("email_marketing_consent")]
    public CustomerEmailMarketingConsent EmailMarketingConsent { get; set; }
}