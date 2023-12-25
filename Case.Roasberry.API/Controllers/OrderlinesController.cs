using Case.Roasberry.Application.Features.Orderlines.Commands.CreateOrderline;
using Case.Roasberry.Application.Features.Orderlines.Commands.DeleteOrderline;
using Case.Roasberry.Application.Features.Orderlines.Commands.UpdateOrderline;
using Case.Roasberry.Application.Features.Orderlines.Queries.GetOrderlineById;
using Case.Roasberry.Application.Features.Orderlines.Queries.GetOrderlines;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Case.Roasberry.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrderlinesController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrderlinesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetOrderlinesQuery());
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _mediator.Send(new GetOrderlineByIdQuery(id));
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateOrderlineCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] UpdateOrderlineCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _mediator.Send(new DeleteOrderlineCommand(id));
        return NoContent();
    }
}
