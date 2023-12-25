using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class Fulfillment : ShopifyObject
{
    [JsonProperty("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonProperty("line_items")]
    public IEnumerable<LineItem> LineItems { get; set; }

    [JsonProperty("order_id")]
    public long? OrderId { get; set; }

    [JsonProperty("receipt")]
    public object Receipt { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("location_id")]
    public long? LocationId { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("notify_customer")]
    public bool? NotifyCustomer { get; set; }

    [JsonProperty("destination")]
    public Address Destination { get; set; }

    [JsonProperty("tracking_company")]
    public string TrackingCompany { get; set; }

    [JsonProperty("tracking_number")]
    public string TrackingNumber { get; set; }

    [JsonProperty("tracking_numbers")]
    public IEnumerable<string> TrackingNumbers { get; set; }

    [JsonProperty("tracking_url")]
    public string TrackingUrl { get; set; }

    [JsonProperty("tracking_urls")]
    public IEnumerable<string> TrackingUrls { get; set; }

    [JsonProperty("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonProperty("variant_inventory_management")]
    public string VariantInventoryManagement { get; set; }

    [JsonProperty("service")]
    public string Service { get; set; }

    [JsonProperty("shipment_status")]
    public string ShipmentStatus { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}