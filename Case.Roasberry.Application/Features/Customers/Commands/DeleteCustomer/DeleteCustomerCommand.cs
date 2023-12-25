using MediatR;

namespace Case.Roasberry.Application.Features.Customers.Commands.DeleteCustomer;
public class DeleteCustomerCommand : IRequest
{
    public Guid Id { get; set; }

    public DeleteCustomerCommand(Guid id)
    {
        Id = id;
    }
}
