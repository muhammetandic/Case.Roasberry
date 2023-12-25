using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class PaymentTerms
{
    [JsonProperty("amount")]
    public decimal? amount { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("due_in_days")]
    public int? DueInDays { get; set; }

    [JsonProperty("payment_terms_name")]
    public string PaymentTermsName { get; set; }

    [JsonProperty("payment_terms_type")]
    public string PaymentTermsType { get; set; }

    [JsonProperty("payment_schedules")]
    public PaymentSchedule[] PaymentSchedules { get; set; }
}
