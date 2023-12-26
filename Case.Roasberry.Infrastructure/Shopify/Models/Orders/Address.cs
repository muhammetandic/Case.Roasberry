﻿using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Orders;

public class Address
{
    [JsonProperty("first_name")]
    public string? FirstName { get; set; }

    [JsonProperty("address1")]
    public string? Address1 { get; set; }

    [JsonProperty("phone")]
    public string? Phone { get; set; }

    [JsonProperty("city")]
    public string? City { get; set; }

    [JsonProperty("zip")]
    public string? Zip { get; set; }

    [JsonProperty("province")]
    public string? Province { get; set; }

    [JsonProperty("country")]
    public string? Country { get; set; }

    [JsonProperty("last_name")]
    public string? LastName { get; set; }

    [JsonProperty("address2")]
    public object? Address2 { get; set; }

    [JsonProperty("company")]
    public string? Company { get; set; }

    [JsonProperty("latitude")]
    public object? Latitude { get; set; }

    [JsonProperty("longitude")]
    public object? Longitude { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("country_code")]
    public string? CountryCode { get; set; }

    [JsonProperty("province_code")]
    public string? ProvinceCode { get; set; }

    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; }

    [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
    public long? CustomerId { get; set; }

    [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
    public string? CountryName { get; set; }

    [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Default { get; set; }
}
