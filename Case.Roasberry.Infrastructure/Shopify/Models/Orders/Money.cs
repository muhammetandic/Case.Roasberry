using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public partial class Money
{
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    [JsonPropertyName("currency_code")]
    public string? CurrencyCode { get; set; }
}
