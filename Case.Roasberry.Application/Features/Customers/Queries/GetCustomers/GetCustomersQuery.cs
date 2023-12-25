using Case.Roasberry.Application.Features.Customers.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Customers.Queries.GetCustomers;
public class GetCustomersQuery : IRequest<List<CustomerDto>>
{
}
