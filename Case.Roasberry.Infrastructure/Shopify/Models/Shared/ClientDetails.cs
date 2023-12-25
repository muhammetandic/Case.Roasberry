using Newtonsoft.Json;

namespace Case.Roasberry.Infrastructure.Shopify.Models.Shared;
public class ClientDetails
{
    [JsonProperty("accept_language")]
    public string AcceptLanguage { get; set; }

    [JsonProperty("browser_height")]
    public int? BrowserHeight { get; set; }

    [JsonProperty("browser_ip")]
    public string BrowserIp { get; set; }

    [JsonProperty("browser_width")]
    public int? BrowserWidth { get; set; }

    [JsonProperty("session_hash")]
    public string SessionHash { get; set; }

    [JsonProperty("user_agent")]
    public string UserAgent { get; set; }
}