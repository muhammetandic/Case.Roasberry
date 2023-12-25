using AutoMapper;
using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Exceptions;
using Case.Roasberry.Application.Features.Customers.Shared;
using Case.Roasberry.Core.Entities;
using MediatR;

namespace Case.Roasberry.Application.Features.Customers.Commands.CreateCustomer;
public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CustomerDto>
{
    private readonly IMapper _mapper;
    private readonly ICustomerRepository _customerRepository;

    public CreateCustomerCommandHandler(IMapper mapper, ICustomerRepository customerRepository)
    {
        _mapper = mapper;
        _customerRepository = customerRepository;
    }

    public async Task<CustomerDto> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateCustomerValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        var customer = _mapper.Map<Customer>(request);
        customer = await _customerRepository.InsertAsync(customer);

        return _mapper.Map<CustomerDto>(customer);
    }
}
