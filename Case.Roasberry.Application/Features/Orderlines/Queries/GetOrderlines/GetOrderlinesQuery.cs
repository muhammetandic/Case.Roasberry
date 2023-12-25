using Case.Roasberry.Application.Features.Orderlines.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Orderlines.Queries.GetOrderlines;
public class GetOrderlinesQuery : IRequest<List<OrderlineDto>>
{
}
