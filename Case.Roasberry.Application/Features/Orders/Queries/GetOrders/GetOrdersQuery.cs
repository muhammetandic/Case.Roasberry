using Case.Roasberry.Application.Features.Orders.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Orders.Queries.GetOrders;
public class GetOrdersQuery : IRequest<List<OrderDto>>
{
}
