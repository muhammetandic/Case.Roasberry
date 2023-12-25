using Case.Roasberry.Application.Features.Orderlines.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Orderlines.Queries.GetOrderlineById;
public class GetOrderlineByIdQuery : IRequest<OrderlineDto>
{
    public Guid Id { get; set; }

    public GetOrderlineByIdQuery(Guid id)
    {
        Id = id;
    }
}
