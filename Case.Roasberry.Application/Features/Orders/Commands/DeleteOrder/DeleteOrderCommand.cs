using MediatR;

namespace Case.Roasberry.Application.Features.Orders.Commands.DeleteOrder;
public class DeleteOrderCommand : IRequest
{
    public Guid Id { get; set; }
}
