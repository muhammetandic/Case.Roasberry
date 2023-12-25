using Case.Roasberry.Infrastructure.Shopify.Models.Shared;
using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;
public class Address : ShopifyObject
{
    [JsonProperty("address1")]
    public string Address1 { get; set; }

    [JsonProperty("address2")]
    public string Address2 { get; set; }

    [JsonProperty("city")]
    public string City { get; set; }

    [JsonProperty("company")]
    public string Company { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("country_code")]
    public string CountryCode { get; set; }

    [JsonProperty("country_name")]
    public string CountryName { get; set; }

    [JsonProperty("default")]
    public bool? Default { get; set; }

    [JsonProperty("first_name")]
    public string FirstName { get; set; }

    [JsonProperty("last_name")]
    public string LastName { get; set; }

    [JsonProperty("latitude")]
    public decimal? Latitude { get; set; }

    [JsonProperty("longitude")]
    public decimal? Longitude { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("phone")]
    public string Phone { get; set; }

    [JsonProperty("province")]
    public string Province { get; set; }

    [JsonProperty("province_code")]
    public string ProvinceCode { get; set; }

    [JsonProperty("zip")]
    public string Zip { get; set; }
}
