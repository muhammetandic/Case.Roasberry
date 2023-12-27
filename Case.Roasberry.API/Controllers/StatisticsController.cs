using Case.Roasberry.Application.Features.Statistics.Queries.BesSellerProducts;
using Case.Roasberry.Application.Features.Statistics.Queries.DailySales;
using Case.Roasberry.Application.Features.Statistics.Queries.MonthlySales;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Case.Roasberry.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StatisticsController : ControllerBase
{
    private readonly IMediator _mediator;

    public StatisticsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("best-seller-products")]
    public async Task<ActionResult> GetBestSellerProducts()
    {
        var result = await _mediator.Send(new BestSellerProductsQuery());
        return Ok(result);
    }

    [HttpGet("daily-sales")]
    public async Task<IActionResult> GetDailySales()
    {
        var result = await _mediator.Send(new DailySalesQuery());
        return Ok(result);
    }

    [HttpGet("monthly-sales")]
    public async Task<IActionResult> GetMonthlySales()
    {
        var result = await _mediator.Send(new MonthlySalesQuery());
        return Ok(result);
    }
}
