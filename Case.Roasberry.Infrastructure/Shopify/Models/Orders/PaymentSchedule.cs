using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class PaymentSchedule
{
    [JsonProperty("amount")]
    public decimal? amount { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("issued_at")]
    public DateTimeOffset? IssuedAt { get; set; }

    [JsonProperty("due_at")]
    public DateTimeOffset? DueAt { get; set; }

    [JsonProperty("completed_at")]
    public DateTimeOffset? CompletedAt { get; set; }

    [JsonProperty("expected_payment_method")]
    public string ExpectedPaymentMethod { get; set; }
}
