using Case.Roasberry.Infrastructure.Shopify.Constants;
using Case.Roasberry.Infrastructure.Shopify.Models.ApiResponses;

namespace Case.Roasberry.Infrastructure.Shopify;
public class ShopifyClient : IShopifyClient
{
    private readonly IShopifyProxy _proxy;

    public ShopifyClient(IShopifyProxy proxy)
    {
        _proxy = proxy;
    }

    public async Task GetProductsAsync()
    {
        var result = await _proxy.GetAsync<GetProductsTesponse>(ShopifyConstants.GetProducts);
    }

    public async Task GetOrdersAsync()
    {
        var result = await _proxy.GetAsync<GetOrdersResponse>(ShopifyConstants.GetOrders);
    }
}
