using Case.Roasberry.Infrastructure.Shopify;
using Case.Roasberry.Infrastructure.Shopify.Constants;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Case.Roasberry.Infrastructure;
public static class InfrastructureServiceRegistration
{
    public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<ShopifySettings>(configuration.GetSection("Shopify"));
        services.AddHttpClient();
        services.AddScoped<IShopifyProxy, ShopifyProxy>();
        services.AddScoped<IShopifyClient, ShopifyClient>();
    }
}
