using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using System.Text.Json.Serialization;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public class Order
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("admin_graphql_api_id")]
    public string? AdminGraphqlApiId { get; set; }

    [JsonPropertyName("app_id")]
    public long AppId { get; set; }

    [JsonPropertyName("browser_ip")]
    public string? BrowserIp { get; set; }

    [JsonPropertyName("buyer_accepts_marketing")]
    public bool BuyerAcceptsMarketing { get; set; }

    [JsonPropertyName("cancel_reason")]
    public object? CancelReason { get; set; }

    [JsonPropertyName("cancelled_at")]
    public object? CancelledAt { get; set; }

    [JsonPropertyName("cart_token")]
    public object? CartToken { get; set; }

    [JsonPropertyName("checkout_id")]
    public long CheckoutId { get; set; }

    [JsonPropertyName("checkout_token")]
    public string? CheckoutToken { get; set; }

    [JsonPropertyName("client_details")]
    public ClientDetails? ClientDetails { get; set; }

    [JsonPropertyName("closed_at")]
    public object? ClosedAt { get; set; }

    [JsonPropertyName("company")]
    public object? Company { get; set; }

    [JsonPropertyName("confirmed")]
    public bool Confirmed { get; set; }

    [JsonPropertyName("contact_email")]
    public string? ContactEmail { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("current_subtotal_price")]
    public decimal CurrentSubtotalPrice { get; set; }

    [JsonPropertyName("current_subtotal_price_set")]
    public Set? CurrentSubtotalPriceSet { get; set; }

    [JsonPropertyName("current_total_discounts")]
    public decimal? CurrentTotalDiscounts { get; set; }

    [JsonPropertyName("current_total_discounts_set")]
    public Set? CurrentTotalDiscountsSet { get; set; }

    [JsonPropertyName("current_total_duties_set")]
    public object? CurrentTotalDutiesSet { get; set; }

    [JsonPropertyName("current_total_price")]
    public decimal? CurrentTotalPrice { get; set; }

    [JsonPropertyName("current_total_price_set")]
    public Set? CurrentTotalPriceSet { get; set; }

    [JsonPropertyName("current_total_tax")]
    public decimal? CurrentTotalTax { get; set; }

    [JsonPropertyName("current_total_tax_set")]
    public Set? CurrentTotalTaxSet { get; set; }

    [JsonPropertyName("customer_locale")]
    public string? CustomerLocale { get; set; }

    [JsonPropertyName("device_id")]
    public object? DeviceId { get; set; }

    [JsonPropertyName("discount_codes")]
    public object?[]? DiscountCodes { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("estimated_taxes")]
    public bool EstimatedTaxes { get; set; }

    [JsonPropertyName("financial_status")]
    public string? FinancialStatus { get; set; }

    [JsonPropertyName("fulfillment_status")]
    public object? FulfillmentStatus { get; set; }

    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    [JsonPropertyName("landing_site")]
    public object? LandingSite { get; set; }

    [JsonPropertyName("landing_site_ref")]
    public object? LandingSiteRef { get; set; }

    [JsonPropertyName("location_id")]
    public object? LocationId { get; set; }

    [JsonPropertyName("merchant_of_record_app_id")]
    public object? MerchantOfRecordAppId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("note_attributes")]
    public object?[]? NoteAttributes { get; set; }

    [JsonPropertyName("number")]
    public long Number { get; set; }

    [JsonPropertyName("order_number")]
    public long OrderNumber { get; set; }

    [JsonPropertyName("order_status_url")]
    public Uri? OrderStatusUrl { get; set; }

    [JsonPropertyName("original_total_duties_set")]
    public object? OriginalTotalDutiesSet { get; set; }

    [JsonPropertyName("payment_gateway_names")]
    public string?[]? PaymentGatewayNames { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("presentment_currency")]
    public string? PresentmentCurrency { get; set; }

    [JsonPropertyName("processed_at")]
    public DateTimeOffset ProcessedAt { get; set; }

    [JsonPropertyName("processing_method")]
    public string? ProcessingMethod { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }

    [JsonPropertyName("referring_site")]
    public object? ReferringSite { get; set; }

    [JsonPropertyName("source_identifier")]
    public string? SourceIdentifier { get; set; }

    [JsonPropertyName("source_name")]
    public string? SourceName { get; set; }

    [JsonPropertyName("source_url")]
    public object? SourceUrl { get; set; }

    [JsonPropertyName("subtotal_price")]
    public decimal? SubtotalPrice { get; set; }

    [JsonPropertyName("subtotal_price_set")]
    public Set? SubtotalPriceSet { get; set; }

    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    [JsonPropertyName("tax_lines")]
    public object?[]? TaxLines { get; set; }

    [JsonPropertyName("taxes_included")]
    public bool TaxesIncluded { get; set; }

    [JsonPropertyName("test")]
    public bool Test { get; set; }

    [JsonPropertyName("token")]
    public string? Token { get; set; }

    [JsonPropertyName("total_discounts")]
    public decimal? TotalDiscounts { get; set; }

    [JsonPropertyName("total_discounts_set")]
    public Set? TotalDiscountsSet { get; set; }

    [JsonPropertyName("total_line_items_price")]
    public decimal? TotalLineItemsPrice { get; set; }

    [JsonPropertyName("total_line_items_price_set")]
    public Set? TotalLineItemsPriceSet { get; set; }

    [JsonPropertyName("total_outstanding")]
    public decimal? TotalOutstanding { get; set; }

    [JsonPropertyName("total_price")]
    public decimal? TotalPrice { get; set; }

    [JsonPropertyName("total_price_set")]
    public Set? TotalPriceSet { get; set; }

    [JsonPropertyName("total_shipping_price_set")]
    public Set? TotalShippingPriceSet { get; set; }

    [JsonPropertyName("total_tax")]
    public decimal? TotalTax { get; set; }

    [JsonPropertyName("total_tax_set")]
    public Set? TotalTaxSet { get; set; }

    [JsonPropertyName("total_tip_received")]
    public string? TotalTipReceived { get; set; }

    [JsonPropertyName("total_weight")]
    public long TotalWeight { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonPropertyName("user_id")]
    public long UserId { get; set; }

    [JsonPropertyName("billing_address")]
    public Address? BillingAddress { get; set; }

    [JsonPropertyName("customer")]
    public Customer? Customer { get; set; }

    [JsonPropertyName("discount_applications")]
    public object?[]? DiscountApplications { get; set; }

    [JsonPropertyName("fulfillments")]
    public object?[]? Fulfillments { get; set; }

    [JsonPropertyName("line_items")]
    public LineItem[]? LineItems { get; set; }

    [JsonPropertyName("payment_terms")]
    public object? PaymentTerms { get; set; }

    [JsonPropertyName("refunds")]
    public object?[]? Refunds { get; set; }

    [JsonPropertyName("shipping_address")]
    public Address? ShippingAddress { get; set; }

    [JsonPropertyName("shipping_lines")]
    public object?[]? ShippingLines { get; set; }
}
