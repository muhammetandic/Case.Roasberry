
namespace Case.Roasberry.Infrastructure.Shopify;
public interface IShopifyProxy
{
    Task<T?> GetAsync<T>(string url);
}
