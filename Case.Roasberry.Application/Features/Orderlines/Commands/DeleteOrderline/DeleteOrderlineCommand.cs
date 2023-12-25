using MediatR;

namespace Case.Roasberry.Application.Features.Orderlines.Commands.DeleteOrderline;
public class DeleteOrderlineCommand : IRequest
{
    public Guid Id { get; set; }
}
