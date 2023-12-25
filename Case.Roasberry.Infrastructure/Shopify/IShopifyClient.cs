
namespace Case.Roasberry.Infrastructure.Shopify;
public interface IShopifyClient
{
    Task GetOrdersAsync();
    Task GetProductsAsync();
}
