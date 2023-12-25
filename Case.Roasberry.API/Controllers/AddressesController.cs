using Case.Roasberry.Application.Features.Addresses.Commands.CreateAddress;
using Case.Roasberry.Application.Features.Addresses.Commands.DeleteAddress;
using Case.Roasberry.Application.Features.Addresses.Commands.UpdateAddress;
using Case.Roasberry.Application.Features.Addresses.Queries.GetAddressById;
using Case.Roasberry.Application.Features.Addresses.Queries.GetAddresses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Case.Roasberry.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AddressesController : ControllerBase
{
    private readonly IMediator _mediator;

    public AddressesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetAddressesQuery());
        return Ok(result);
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _mediator.Send(new GetAddressByIdQuery(id));
        return Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateAddressCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] UpdateAddressCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _mediator.Send(new DeleteAddressCommand(id));
        return NoContent();
    }
}
