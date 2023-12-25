using Case.Roasberry.Application.Features.Customers.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Customers.Queries.GetCustomerById;
public class GetCustomerByIdQuery : IRequest<CustomerDto>
{
    public Guid Id { get; set; }

    public GetCustomerByIdQuery(Guid id)
    {
        Id = id;
    }
}
