using Case.Roasberry.Infrastructure.Shopify;
using Microsoft.AspNetCore.Mvc;

namespace Case.Roasberry.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ShopifyController : ControllerBase
{
    private readonly IShopifyClient _client;

    public ShopifyController(IShopifyClient client)
    {
        _client = client;
    }

    [HttpGet("getProducts")]
    public async Task Get()
    {
        await _client.GetProductsAsync();
    }

    [HttpGet("getOrders")]
    public async Task GetOrders()
    {
        await _client.GetOrdersAsync();
    }
}
