using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public class Money
{
    [JsonProperty("amount")]
    public string? Amount { get; set; }

    [JsonProperty("currency_code")]
    public string? CurrencyCode { get; set; }
}
