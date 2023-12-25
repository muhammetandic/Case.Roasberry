using Case.Roasberry.Application.Features.Orders.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Orders.Queries.GetOrderById;
public class GetOrderByIdQuery : IRequest<OrderDto>
{
    public Guid Id { get; set; }

    public GetOrderByIdQuery(Guid id)
    {
        Id = id;
    }
}
