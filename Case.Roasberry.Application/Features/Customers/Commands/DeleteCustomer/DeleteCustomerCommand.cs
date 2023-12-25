using MediatR;

namespace Case.Roasberry.Application.Features.Customers.Commands.DeleteCustomer;
public class DeleteCustomerCommand : IRequest
{
    public required Guid Id { get; set; }
}
