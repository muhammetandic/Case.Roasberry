using Case.Roasberry.Application.Features.Products.Commands.CreateProduct;
using Case.Roasberry.Infrastructure.Shopify;
using Case.Roasberry.Infrastructure.Shopify.Models.ApiResponses;
using Case.Roasberry.Infrastructure.Shopify.Models.Orders;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Case.Roasberry.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ShopifyController : ControllerBase
{
    private readonly IShopifyClient _client;
    private IMediator _mediator;

    public ShopifyController(IShopifyClient client, IMediator mediator)
    {
        _client = client;
        _mediator = mediator;
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
    public async Task SaveOrders([FromBody] Order ordersData)
    {
        var product = new CreateProductCommand()
        {
            Name = "Deneme",
            Discount = 0,
            UnitPrice = 10,
            Category = "Test",
            Properties = JsonConvert.SerializeObject(ordersData)
        };
        await _mediator.Send(product);
    }
}
