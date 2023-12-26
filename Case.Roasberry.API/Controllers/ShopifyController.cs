using Case.Roasberry.Infrastructure;
using Case.Roasberry.Infrastructure.Shopify;
using Case.Roasberry.Infrastructure.Shopify.Models.Orders;
using Microsoft.AspNetCore.Mvc;

namespace Case.Roasberry.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ShopifyController : ControllerBase
{
    private readonly IShopifyClient _client;
    private readonly IOrderService _orderService;
    public ShopifyController(IShopifyClient client, IOrderService orderService)
    {
        _client = client;
        _orderService = orderService;
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

    [HttpPost("order-webhook")]
    public async Task SaveOrders([FromBody] Order data)
    {
        await _orderService.PersistOrder(data);
    }
}
