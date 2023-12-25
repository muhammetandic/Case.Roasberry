using Case.Roasberry.Infrastructure.Shopify.Constants;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Case.Roasberry.Infrastructure.Shopify;
public class ShopifyProxy : IShopifyProxy
{
    private HttpClient _client;
    private ShopifySettings _settings;

    public ShopifyProxy(IHttpClientFactory factory, IOptions<ShopifySettings> options)
    {
        _settings = options.Value;
        _client = factory.CreateClient();
        _client.BaseAddress = new Uri(ShopifyConstants.BaseAddress);
        _client.DefaultRequestHeaders.Add("Accept", "application/json");
        _client.DefaultRequestHeaders.Add("X-Shopify-Access-Token", _settings.AccessToken);
    }

    public async Task<T?> GetAsync<T>(string url)
    {
        var result = await _client.GetAsync(url);
        var str = await result.Content.ReadAsStringAsync();
        var rst = JsonConvert.DeserializeObject<T>(str);
        return rst;
    }

}
