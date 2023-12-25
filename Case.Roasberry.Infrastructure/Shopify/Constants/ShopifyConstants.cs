namespace Case.Roasberry.Infrastructure.Shopify.Constants;
public static class ShopifyConstants
{
    public const string BaseAddress = "https://roasberry.myshopify.com";
    public const string Authentication = "/admin/api/2021-07/shop.json";
    public const string GetCustomers = "/admin/api/2023-10/customers.json";
    public const string GetProducts = "/admin/api/2023-10/products.json";
    public const string GetOrders = "/admin/api/2023-10/orders.json?status=any";
}
