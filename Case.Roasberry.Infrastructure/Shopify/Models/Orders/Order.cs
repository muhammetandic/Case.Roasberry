using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public class Order
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("admin_graphql_api_id")]
    public string? AdminGraphqlApiId { get; set; }

    [JsonProperty("app_id")]
    public object? AppId { get; set; }

    [JsonProperty("browser_ip")]
    public object? BrowserIp { get; set; }

    [JsonProperty("buyer_accepts_marketing")]
    public bool BuyerAcceptsMarketing { get; set; }

    [JsonProperty("cancel_reason")]
    public string? CancelReason { get; set; }

    [JsonProperty("cancelled_at")]
    public DateTimeOffset CancelledAt { get; set; }

    [JsonProperty("cart_token")]
    public object? CartToken { get; set; }

    [JsonProperty("checkout_id")]
    public object? CheckoutId { get; set; }

    [JsonProperty("checkout_token")]
    public object? CheckoutToken { get; set; }

    [JsonProperty("client_details")]
    public object? ClientDetails { get; set; }

    [JsonProperty("closed_at")]
    public object? ClosedAt { get; set; }

    [JsonProperty("company")]
    public object? Company { get; set; }

    [JsonProperty("confirmation_number")]
    public object? ConfirmationNumber { get; set; }

    [JsonProperty("confirmed")]
    public bool Confirmed { get; set; }

    [JsonProperty("contact_email")]
    public string? ContactEmail { get; set; }

    [JsonProperty("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonProperty("currency")]
    public string? Currency { get; set; }

    [JsonProperty("current_subtotal_price")]
    public string? CurrentSubtotalPrice { get; set; }

    [JsonProperty("current_subtotal_price_set")]
    public Set? CurrentSubtotalPriceSet { get; set; }

    [JsonProperty("current_total_additional_fees_set")]
    public object? CurrentTotalAdditionalFeesSet { get; set; }

    [JsonProperty("current_total_discounts")]
    public string? CurrentTotalDiscounts { get; set; }

    [JsonProperty("current_total_discounts_set")]
    public Set? CurrentTotalDiscountsSet { get; set; }

    [JsonProperty("current_total_duties_set")]
    public object? CurrentTotalDutiesSet { get; set; }

    [JsonProperty("current_total_price")]
    public string? CurrentTotalPrice { get; set; }

    [JsonProperty("current_total_price_set")]
    public Set? CurrentTotalPriceSet { get; set; }

    [JsonProperty("current_total_tax")]
    public string? CurrentTotalTax { get; set; }

    [JsonProperty("current_total_tax_set")]
    public Set? CurrentTotalTaxSet { get; set; }

    [JsonProperty("customer_locale")]
    public string? CustomerLocale { get; set; }

    [JsonProperty("device_id")]
    public object? DeviceId { get; set; }

    [JsonProperty("discount_codes")]
    public object?[]? DiscountCodes { get; set; }

    [JsonProperty("email")]
    public string? Email { get; set; }

    [JsonProperty("estimated_taxes")]
    public bool EstimatedTaxes { get; set; }

    [JsonProperty("financial_status")]
    public string? FinancialStatus { get; set; }

    [JsonProperty("fulfillment_status")]
    public string? FulfillmentStatus { get; set; }

    [JsonProperty("landing_site")]
    public object? LandingSite { get; set; }

    [JsonProperty("landing_site_ref")]
    public object? LandingSiteRef { get; set; }

    [JsonProperty("location_id")]
    public object? LocationId { get; set; }

    [JsonProperty("merchant_of_record_app_id")]
    public object? MerchantOfRecordAppId { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("note")]
    public object? Note { get; set; }

    [JsonProperty("note_attributes")]
    public object?[]? NoteAttributes { get; set; }

    [JsonProperty("number")]
    public long Number { get; set; }

    [JsonProperty("order_number")]
    public long OrderNumber { get; set; }

    [JsonProperty("order_status_url")]
    public Uri? OrderStatusUrl { get; set; }

    [JsonProperty("original_total_additional_fees_set")]
    public object? OriginalTotalAdditionalFeesSet { get; set; }

    [JsonProperty("original_total_duties_set")]
    public object? OriginalTotalDutiesSet { get; set; }

    [JsonProperty("payment_gateway_names")]
    public string?[]? PaymentGatewayNames { get; set; }

    [JsonProperty("phone")]
    public object? Phone { get; set; }

    [JsonProperty("po_number")]
    public object? PoNumber { get; set; }

    [JsonProperty("presentment_currency")]
    public string? PresentmentCurrency { get; set; }

    [JsonProperty("processed_at")]
    public object? ProcessedAt { get; set; }

    [JsonProperty("reference")]
    public object? Reference { get; set; }

    [JsonProperty("referring_site")]
    public object? ReferringSite { get; set; }

    [JsonProperty("source_identifier")]
    public object? SourceIdentifier { get; set; }

    [JsonProperty("source_name")]
    public string? SourceName { get; set; }

    [JsonProperty("source_url")]
    public object? SourceUrl { get; set; }

    [JsonProperty("subtotal_price")]
    public string? SubtotalPrice { get; set; }

    [JsonProperty("subtotal_price_set")]
    public Set? SubtotalPriceSet { get; set; }

    [JsonProperty("tags")]
    public string? Tags { get; set; }

    [JsonProperty("tax_exempt")]
    public bool TaxExempt { get; set; }

    [JsonProperty("tax_lines")]
    public object?[]? TaxLines { get; set; }

    [JsonProperty("taxes_included")]
    public bool TaxesIncluded { get; set; }

    [JsonProperty("test")]
    public bool Test { get; set; }

    [JsonProperty("token")]
    public string? Token { get; set; }

    [JsonProperty("total_discounts")]
    public string? TotalDiscounts { get; set; }

    [JsonProperty("total_discounts_set")]
    public Set? TotalDiscountsSet { get; set; }

    [JsonProperty("total_line_items_price")]
    public string? TotalLineItemsPrice { get; set; }

    [JsonProperty("total_line_items_price_set")]
    public Set? TotalLineItemsPriceSet { get; set; }

    [JsonProperty("total_outstanding")]
    public string? TotalOutstanding { get; set; }

    [JsonProperty("total_price")]
    public string? TotalPrice { get; set; }

    [JsonProperty("total_price_set")]
    public Set? TotalPriceSet { get; set; }

    [JsonProperty("total_shipping_price_set")]
    public Set? TotalShippingPriceSet { get; set; }

    [JsonProperty("total_tax")]
    public string? TotalTax { get; set; }

    [JsonProperty("total_tax_set")]
    public Set? TotalTaxSet { get; set; }

    [JsonProperty("total_tip_received")]
    public string? TotalTipReceived { get; set; }

    [JsonProperty("total_weight")]
    public long TotalWeight { get; set; }

    [JsonProperty("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonProperty("user_id")]
    public object? UserId { get; set; }

    [JsonProperty("billing_address")]
    public Address? BillingAddress { get; set; }

    [JsonProperty("customer")]
    public Customer? Customer { get; set; }

    [JsonProperty("discount_applications")]
    public object?[]? DiscountApplications { get; set; }

    [JsonProperty("fulfillments")]
    public object?[]? Fulfillments { get; set; }

    [JsonProperty("line_items")]
    public LineItem[]? LineItems { get; set; }

    [JsonProperty("payment_terms")]
    public object? PaymentTerms { get; set; }

    [JsonProperty("refunds")]
    public object?[]? Refunds { get; set; }

    [JsonProperty("shipping_address")]
    public Address? ShippingAddress { get; set; }

    [JsonProperty("shipping_lines")]
    public ShippingLine[]? ShippingLines { get; set; }
}
