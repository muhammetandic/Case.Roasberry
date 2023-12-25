using Case.Roasberry.Application.Contracts.Persistence;
using MediatR;

namespace Case.Roasberry.Application.Features.Customers.Commands.DeleteCustomer;
public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand>
{
    private readonly ICustomerRepository _customerRepository;
    public DeleteCustomerCommandHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
    {
        await _customerRepository.DeleteAsync(request.Id);
    }
}
